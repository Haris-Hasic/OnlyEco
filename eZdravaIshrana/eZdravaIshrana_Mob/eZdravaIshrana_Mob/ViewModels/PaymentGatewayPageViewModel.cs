using Acr.UserDialogs;
using eZdravaIshrana_Mob.Views;
using eZdravaIshrana_Mob.Models;
using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eZdravaIshrana_PCL.Models;
using System.Net.Http;
using eZdravaIshrana_PCL.Util;
using eZdravaIshrana_PCL.Model;

namespace eZdravaIshrana_Mob.ViewModels
{
    public class PaymentGatewayPageViewModel : BindableBase
    {
        #region Variable
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property
        private string StripeTestApiKey = "pk_test_51Gr5N1JkcFRZvQTprNkaT6r4f2zLOy7IwrMZ1ii7DlpjKMLscYvwem48hg8cj2faeExJndZD4fYu9j1q2FISQrAr00BMDzgmTm";
        private string StripeSecretApiKey = "sk_test_51Gr5N1JkcFRZvQTpknaaXWNEEMFYCvuqSWn3mcGmYuKHfvTa4Ckm1WGTxVpcEzuFO4OszxMu5mYIVw5wHiS4ubk200LZFbdpZK";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        double _iznos = 0;
        public double Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property

        #region Constructor

        public PaymentGatewayPageViewModel()
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            if (Global.CCplaceno == false)
            {
                CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            try
            {
                UserDialogs.Instance.ShowLoading("Plaćanje u toku...");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();

                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Podaci o kartici nisu validni", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");


            }

            if (IsTransectionSuccess)
            {
              
                HttpResponseMessage narudzaResponse;
                // GetBrojNarudzbi
                narudzaResponse = narudzbeService.GetActionResponseNoP("GetBrojNarudzbi");
                int broj = narudzaResponse.Content.ReadAsAsync<int>().Result;

                foreach (var x in Global.av)
                {
                    Global.aktivnaNarudzba.NarudzbaStavke.Add(x);
                }
                Global.aktivnaNarudzba.PayByCard = true;

                Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;
                Global.aktivnaNarudzba.BrojNarudzbe = "Br" + broj.ToString();
                Global.aktivnaNarudzba.Latitude = Global.destinacijaPin.Lat.ToString();
                Global.aktivnaNarudzba.Longitude = Global.destinacijaPin.Lng.ToString();
                Global.aktivnaNarudzba.IznosSaPDV = Convert.ToDecimal(Iznos);

                Global.aktivnaNarudzba.IznosBezPDV = Convert.ToDecimal(Iznos - (Iznos * 0.17));
                    if (Global.popustaktivan == true) { 
                    kupciService.PutResponse(Global.prijavljeniKupac.KupacID, Global.prijavljeniKupac);
                        Global.popustaktivan = false;
                    }
                    narudzaResponse = narudzbeService.PostResponse(Global.aktivnaNarudzba);
                Global.CCplaceno = true;
             
                Global.aktivnaNarudzba = new eZdravaIshrana_PCL.Model.Narudzbe();
                Global.av.Clear();
               
                Global.av = new System.Collections.ObjectModel.ObservableCollection<NarudzbaStavke>();
                Global.destinacijaPin = new LatLong();
                    Global.aktivnaNarudzba.Ukupno = 0;
                UserDialogs.Instance.Alert("Your payment was successfull", "Payment success", "OK");
                UserDialogs.Instance.HideLoading();
        
            }
            else
            {

                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                //kada kartica nije tacna
            }

            }
            else
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Stanje, Narudžba već procesirana", "Plaćanje uspješno", "OK");
             
            }

        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeTestApiKey);
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = Global.prijavljeniKupac.KorisnickoIme +" : "+Global.aktivnaNarudzba.BrojNarudzbe,
                        AddressLine1 = "Adresa 1",
                        AddressLine2 = "",
                        AddressCity = "",
                        AddressZip = "",
                        AddressState = "",
                        AddressCountry = "Bosnia and Herzegovina",
                        Currency = "bam",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecretApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = ((long)Iznos) * 100,
                    Currency = "bam",
                    Description = "Charge for " + Global.prijavljeniKupac.KorisnickoIme,// Global.PrijavljeniKlijent.KorisnickoIme,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = Global.prijavljeniKupac.Email,
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

        #endregion Method
    }
}

