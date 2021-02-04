using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using eZdravaIshrana_API.Models;
using eZdravaIshrana_API.Util;
using eZdravaIshrana_UI.Util;
using System.Net.Http;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_UI.Orders
{
    public partial class DetailsForm : Form
    {
        private List<PointLatLng> _points;
        WebApiHelper narudzbeServices = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
       // WebApiHelper narudzbeStavkeServices = new WebApiHelper("http://localhost:2618/", "api/NarudzbaStavke");
        WebApiHelper izlaziServices = new WebApiHelper("http://localhost:2618/", "api/Izlazi");
        WebApiHelper skladisteService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        WebApiHelper dostavljaciService = new WebApiHelper("http://localhost:2618/", "api/Dostavljaci");
        public Narudzbe AktivnaNarudzba { get; set; }
        public Skladista NarucenoSkladiste { get; set; }
        public esp_Narudzbe_SelectAktivne_Result narudzba { get; set; }

        GMapOverlay marrkers;
        GMarkerGoogle selektovaniMarker = null;
    
        public DetailsForm(esp_Narudzbe_SelectAktivne_Result narudzba)
        {
             InitializeComponent();
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCiLq7oFsOeQAhlmf6KxhsIAwDUDbJ-W0M";

            if (narudzba!=null)
               this.narudzba = narudzba;
           
            _points = new List<PointLatLng>();
            HttpResponseMessage response2 = narudzbeServices.GetResponseID(narudzba.NarudzbaID);
            if (response2.IsSuccessStatusCode)
            {
                AktivnaNarudzba = response2.Content.ReadAsAsync<Narudzbe>().Result;
                HttpResponseMessage response1 = skladisteService.GetResponseID(AktivnaNarudzba.SkladisteID);
                if (response1.IsSuccessStatusCode)
                {
                    NarucenoSkladiste = response1.Content.ReadAsAsync<Skladista>().Result;
                    _points.Add(new PointLatLng(Convert.ToDouble(NarucenoSkladiste.Longitude),
                                                Convert.ToDouble(NarucenoSkladiste.Latitude)));
                    _points.Add(new PointLatLng(Convert.ToDouble(AktivnaNarudzba.Latitude),
                                              Convert.ToDouble(AktivnaNarudzba.Longitude)));
                }
            }
        


            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(Convert.ToDouble(NarucenoSkladiste.Longitude), Convert.ToDouble(NarucenoSkladiste.Latitude));
            map.MinZoom = 3;
            map.MaxZoom = 95;
            map.Zoom = 15;
            HttpResponseMessage response = skladisteService.GetResponse();
            List<Skladista> skladiste = response.Content.ReadAsAsync<List<Skladista>>().Result;

            if (response.IsSuccessStatusCode)
            {
                marrkers = new GMapOverlay("Markeri");

                foreach (var x in skladiste)
                {
                    if (x.SkladisteID == NarucenoSkladiste.SkladisteID) {

                        PointLatLng novi2 = new PointLatLng(Convert.ToDouble(_points[0].Lat), Convert.ToDouble(_points[0].Lng));
                        GMarkerGoogle marker2 = new GMarkerGoogle(novi2, GMarkerGoogleType.red_pushpin);
                        marker2.ToolTipText = $"Odabrano Skladiste: , \n " +
                            $"Longitude: {_points[0].Lat}, \n " +
                             $"Latitude: {_points[0].Lng},  ";
                        var tooltip2 = new GMapToolTip(marker2);
                        tooltip2.Fill = new SolidBrush(Color.LightGoldenrodYellow);
                        tooltip2.Foreground = new SolidBrush(Color.Black);
                        tooltip2.Offset = new Point(50, -25);
                        tooltip2.Stroke = new Pen(new SolidBrush(Color.Black));

                        marker2.ToolTip = tooltip2;
                        marrkers.Markers.Add(marker2);
                    }
                    else {
                    PointLatLng novi = new PointLatLng(Convert.ToDouble(x.Longitude), Convert.ToDouble(x.Latitude));
                    GMarkerGoogle marker = new GMarkerGoogle(novi, GMarkerGoogleType.blue_dot);
                    marker.ToolTipText = $"Naziv skladišta: {x.Adresa}, \n " +
                        $"Longitude: {x.Latitude}, \n " +
                         $"Latitude: {x.Longitude},  ";
                    var tooltip = new GMapToolTip(marker);
                    tooltip.Fill = new SolidBrush(Color.DarkBlue);
                    tooltip.Foreground = new SolidBrush(Color.White);
                    tooltip.Offset = new Point(40, -20);
                    tooltip.Stroke = new Pen(new SolidBrush(Color.Red));

                    marker.ToolTip = tooltip;

                    marrkers.Markers.Add(marker);
                    }
                }

                

                PointLatLng novi3 = new PointLatLng(Convert.ToDouble(_points[1].Lat), Convert.ToDouble(_points[1].Lng));
                GMarkerGoogle marker3 = new GMarkerGoogle(novi3, GMarkerGoogleType.red_pushpin);
                marker3.ToolTipText = $"Korisnik: , \n " +
                    $"Longitude: {_points[1].Lat}, \n " +
                     $"Latitude: {_points[1].Lng},  ";
                var tooltip3 = new GMapToolTip(marker3);
                tooltip3.Fill = new SolidBrush(Color.LightGoldenrodYellow);
                tooltip3.Foreground = new SolidBrush(Color.Black);
                tooltip3.Offset = new Point(50, -25);
                tooltip3.Stroke = new Pen(new SolidBrush(Color.Black));

               
                marker3.ToolTip = tooltip3;
             
                marrkers.Markers.Add(marker3);



                map.Overlays.Add(marrkers);
            }
            else
            {

            }
           


        }


        private void DetailsForm_Load(object sender, EventArgs e)
        {
            BindForm();
            BindDost();
        }

        private void BindDost()
        {
            HttpResponseMessage response = dostavljaciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Dostavljaci> dostavljaci = response.Content.ReadAsAsync<List<Dostavljaci>>().Result;
                dostavljaci.Insert(0, new Dostavljaci());
                skladistecmb.DataSource = dostavljaci;
                skladistecmb.DisplayMember = "Naziv";
                skladistecmb.ValueMember = "DostavljacID";
            }
        }

        private void BindForm()
        {
            brojNarudzbelbl.Text = narudzba.BrojNarudzbe;
            datumlbl.Text = narudzba.Datum.ToShortDateString();
            kupaclbl.Text = narudzba.Kupac;
            iznoslbl.Text = narudzba.Iznos + " KM.";
            lblUdaljenost.Text = AktivnaNarudzba.UdaljenostRute + " km.";
            lblvrijem.Text = AktivnaNarudzba.VrijemeRute + " min.";
            HttpResponseMessage response = narudzbeServices.GetActionResponse("GetStavkeNarudzbe", narudzba.NarudzbaID.ToString());
            
            if (response.IsSuccessStatusCode)
            {
                stavkeNarudzbeGrid.DataSource = response.Content.ReadAsAsync<List<esp_NarudbeStavke_SelectByNarudzbaID_Result>>().Result;
                
                stavkeNarudzbeGrid.Columns[0].Visible = false;
                stavkeNarudzbeGrid.Columns[1].Visible = false;
                stavkeNarudzbeGrid.Columns[4].Visible = false;
            }
        }

        private void procesirajbtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Narudzbe naru = new Narudzbe();
                HttpResponseMessage response2 = narudzbeServices.GetResponseID(narudzba.NarudzbaID);
                if (response2.IsSuccessStatusCode)
                {
                    naru = response2.Content.ReadAsAsync<Narudzbe>().Result;
                }

                Izlazi izlaz = new Izlazi();
                izlaz.PayByCard = naru.PayByCard;
                izlaz.KupacID = naru.KupacID;
                izlaz.VrijemeRute = naru.VrijemeRute;
                izlaz.UdaljenostRute = naru.UdaljenostRute;
                izlaz.DostavljacID = Convert.ToInt32(skladistecmb.SelectedValue);//odraditi u combobox ILI STAVITI PO SKLADISTU DA ODABERE DOSTAVLJACA
                izlaz.SkladisteID = Convert.ToInt32(naru.SkladisteID);
                izlaz.UdaljenostRute = naru.UdaljenostRute;
                izlaz.NarudzbaID = narudzba.NarudzbaID;
                izlaz.IznosSaPDV = Convert.ToDecimal(naru.IznosSaPDV);
                izlaz.IznosBezPDV = Convert.ToDecimal(naru.IznosBezPDV);
                izlaz.BrojRacuna = naru.BrojNarudzbe;
                izlaz.Datum = naru.Datum;
                izlaz.Zakljucen = false;
                izlaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                
                izlaz.Latitude = naru.Latitude;
                izlaz.Longitude = naru.Longitude;
                HttpResponseMessage response = narudzbeServices.PutResponse(naru.NarudzbaID,naru);
                HttpResponseMessage response3 = izlaziServices.PostResponse(izlaz);
                DialogResult = DialogResult.OK;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno ste procesirali narudžbu. ");
                    this.Close();
                }
            }
        }

        private void skladistecmb_Validating(object sender, CancelEventArgs e)
        {
            if (skladistecmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(skladistecmb, Global.GetMessage("skladiste_req"));
            }
            else
            {
                errorProvider.SetError(skladistecmb, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
