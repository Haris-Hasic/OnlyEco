using eZdravaIshrana_API.Models;
using eZdravaIshrana_UI.Util;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_UI.Storage
{
    public partial class AddSkladiste : Form
    {
        WebApiHelper skladisteService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        int brojacKlik = 0;
        public Skladista skladiste;
        int skladisteID = 0;
        int editbrojac = 0;
        GMapOverlay marrkers;
        GMarkerGoogle selektovaniMarker=null;
        bool klikno = false;
        public AddSkladiste()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(43.343815, 17.807964);
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

                map.Overlays.Add(marrkers);
            }
            else
            {

            }
        }
        public AddSkladiste(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = skladisteService.GetResponseID(id);
            skladiste = response.Content.ReadAsAsync<Skladista>().Result;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(Convert.ToDouble(skladiste.Longitude), Convert.ToDouble(skladiste.Latitude));
            map.MinZoom = 3;
            map.MaxZoom = 95;
            map.Zoom = 15;
            skladisteID = id;
            if (response.IsSuccessStatusCode)
            {
                HttpResponseMessage response1 = skladisteService.GetResponse();
                List<Skladista> skladiste1 = response1.Content.ReadAsAsync<List<Skladista>>().Result;

                if (response1.IsSuccessStatusCode)
                {
                    marrkers = new GMapOverlay("Markeri");

                    foreach (var x in skladiste1)
                    {
                        
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
                        if (x.SkladisteID == id)
                        {
                            selektovaniMarker = marker;
                        }
                        marrkers.Markers.Add(marker);
                    }

                    map.Overlays.Add(marrkers);
                }
                else
                {

                }
                brojacKlik++;
                LoadDate();


            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }

        }

        private void LoadDate()
        {
            nazivtxt.Text = skladiste.Naziv;
            adresatxt.Text = skladiste.Adresa;
            opistxt.Text = skladiste.Opis;
            txtLng.Text = skladiste.Longitude;
            txtLat.Text = skladiste.Latitude;

        }

        private void AddSkladiste_Load(object sender, EventArgs e)
        {

            
       

        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var test = sender;
            GMapControl abv = (GMapControl)test;
            klikno = true;
            string lat = abv.Position.Lat.ToString();
            string lng = abv.Position.Lng.ToString();
            txtLat.Text = lat;
            txtLng.Text = lng;
            if (brojacKlik == 0 )
            {
                PointLatLng novi = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));
                GMarkerGoogle marker = new GMarkerGoogle(novi, GMarkerGoogleType.blue_dot);
                marrkers.Markers.Add(marker);
                map.Overlays.Clear();
                map.Overlays.Add(marrkers);
                brojacKlik++;
            }
            else 
            {
                PointLatLng novi = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));
                GMarkerGoogle marker = new GMarkerGoogle(novi, GMarkerGoogleType.blue_dot);
                if (selektovaniMarker == null || editbrojac!=0) { 
                    marrkers.Markers.Remove(marrkers.Markers[marrkers.Markers.Count - 1]);

                }
                else { 
                    marrkers.Markers.Remove(selektovaniMarker);
                    editbrojac++;
                }
                marrkers.Markers.Add(marker);
                map.Overlays.Clear();
                map.Overlays.Add(marrkers);            
            }
            

        }

        private void spasibtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (skladiste == null)
                    skladiste = new Skladista();
                skladiste.Naziv = nazivtxt.Text;
                skladiste.Opis = opistxt.Text;
                skladiste.Adresa = adresatxt.Text;
                if (klikno == true) { 
                skladiste.Longitude = txtLat.Text;
                skladiste.Latitude = txtLng.Text;
                }
                HttpResponseMessage response;
                DialogResult = DialogResult.OK;
                if (skladiste.SkladisteID == 0)
                    response = skladisteService.PostResponse(skladiste);
                else
                {
                 
                    response = skladisteService.PutResponse(skladiste.SkladisteID, skladiste);
                }
                if (response.IsSuccessStatusCode)
                {
                    if (skladiste.SkladisteID == 0)
                        MessageBox.Show("Skladište uspjesno dodat ! (" + response.Content.ReadAsAsync<Skladista>().Result.SkladisteID + ")");
                    else
                        MessageBox.Show("Skladište uspjesno updatovan ! ");

                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
                ClearInput();
                this.Close();
            }
        }

        private void ClearInput()
        {
            nazivtxt.Text = opistxt.Text = adresatxt.Text = "";
        }

        private void nazivtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivtxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivtxt, Global.GetMessage("dnaziv_req"));
            }
            else if (nazivtxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivtxt, Global.GetMessage("dnaziv_len"));
            }
            else
            {
                errorProvider.SetError(nazivtxt, "");
            }
        }

        private void adresatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresatxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(adresatxt, Global.GetMessage("dadresa_req"));
            }
            else if (adresatxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(adresatxt, Global.GetMessage("dadresa_len"));
            }
            else
            {
                errorProvider.SetError(adresatxt, "");
            }
        }

        private void opistxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opistxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(opistxt, Global.GetMessage("opis_req"));
            }
            else
            {
                errorProvider.SetError(opistxt, "");
            }
        }

        private void odstanibtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void txtLat_Validating(object sender, CancelEventArgs e)
        {
            if (brojacKlik==0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLat, Global.GetMessage("LatLong_err"));
            }
            else
            {
                errorProvider.SetError(txtLat, "");
            }
        }

        private void txtLng_Validating(object sender, CancelEventArgs e)
        {
            if (brojacKlik == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLng, Global.GetMessage("LatLong_err"));
            }
            else
            {
                errorProvider.SetError(txtLng, "");
            }
        }
    }
}
