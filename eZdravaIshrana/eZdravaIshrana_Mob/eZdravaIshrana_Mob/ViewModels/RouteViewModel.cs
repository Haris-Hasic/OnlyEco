using eZdravaIshrana_Mob.Views;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using static eZdravaIshrana_PCL.Model.RouteHlpClass;


using eZdravaIshrana_Mob.ViewModels;
using System.Net.Http;
using Validation;
using System.Windows.Input;

namespace eZdravaIshrana_Mob.ViewModels
{
    public class RouteViewModel : BaseViewModel, INotifyPropertyChanged
    {
        int _pinCreatedCount = 0;

        readonly ObservableCollection<Location> _locations;
        public IEnumerable Locations => _locations;


        private string _origin;
        public string Origin
        {
            get { return _origin; }
            set { _origin = value; OnPropertyChanged("Origin"); }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        private string _destination;
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; OnPropertyChanged("Destination"); }
        }
        public LatLong Destinacija { get; set; } = new LatLong();
        public LatLong Skladiste { get; set; } = new LatLong();

        private string _routeDuration;
        public string RouteDuration
        {
            get { return _routeDuration; }
            set { _routeDuration = value; OnPropertyChanged("RouteDuration"); }
        }

        private string _routeDistance;
        public string RouteDistance
        {
            get { return _routeDistance; }
            set { _routeDistance = value; OnPropertyChanged("RouteDistance"); }
        }

        public static Xamarin.Forms.Maps.Map mapa;
        public Command GetRouteCommand { get; }
        private OSRMRouteService services;
        private RouteHlpClass dr;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Skladista> Skladistalist { get; set; } = new ObservableCollection<Skladista>();

        public RouteViewModel()
        {
            HttpResponseMessage response;
            WebApiHelper skladisteService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
            List<Skladista> skla = new List<Skladista>();


            response = skladisteService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                skla = response.Content.ReadAsAsync<List<Skladista>>().Result;
            }

            _locations = new ObservableCollection<Location>();

            foreach (Skladista x in skla)
            {
                if (x.Latitude != null && x.Longitude != null)
                {
                    Location a = new Location(x.Naziv, x.Adresa, new Position(Convert.ToDouble(x.Longitude), Convert.ToDouble(x.Latitude)));
                 
                    _locations.Add(a);
                }
                Skladistalist.Add(x);
            }
            mapa = new Xamarin.Forms.Maps.Map();
            services = new OSRMRouteService();
            dr = new RouteHlpClass();
            GetRouteCommand = new Command(async () => await loadRouteAsync(Skladiste, Destinacija));
            RouteDistance = RouteDuration = "0";
        }

        private async Task loadRouteAsync(LatLong Skladiste, LatLong destination)
        {

            string message = string.Empty;
            var current = Xamarin.Essentials.Connectivity.NetworkAccess;

            try
            {
                if (current != Xamarin.Essentials.NetworkAccess.Internet)
                {
                    Exception a = new Exception("Niste povezani na internet");
                    throw a;
                  
                }
                List<Route> routes = new List<Route>();
                List<LatLong> locations = new List<LatLong>();
                List<Step> steps = new List<Step>();
                List<Intersection> intersections = new List<Intersection>();
                List<Leg> legs = new List<Leg>();

               
                if (destination != null)
                {
                    dr = await services.GetRouteHlpAsync(Skladiste, destination);
                    if (dr != null)
                    {

                        await Task.Delay(1000);
                        routes = dr.Routes.ToList();

                        RouteDuration = Math.Round((Double)routes[0].Duration / 60, 0).ToString();
                        RouteDistance = Math.Round((Double)routes[0].Distance / 1000, 1).ToString();

                        Global.aktivnaNarudzba.UdaljenostRute = RouteDistance;
                        Global.aktivnaNarudzba.VrijemeRute = RouteDuration;
                        Global._udaljenosthlp = RouteDistance;
                        Global._vrijemethlp = RouteDuration;

                   
                        foreach (var route in routes)
                        {
                            legs = route.Legs.ToList();
                        }
                        foreach (var leg in legs)
                        {
                            steps = leg.Steps.ToList();
                        }
                        foreach (var step in steps)
                        {
                            var intersectionsLocal = step.Intersections.ToList();
                            foreach (var inter in intersectionsLocal)
                            {
                                intersections.Add(inter);
                            }
                        }
                        foreach (var inter in intersections)
                        {
                            LatLong p = new LatLong();
                            p.Lat = inter.Location[0];
                            p.Lng = inter.Location[1];
                            locations.Add(p);
                        }


                        Polyline polyline = new Polyline
                        {
                            StrokeColor = System.Drawing.Color.Red,
                            StrokeWidth = 5,
                        };

                        mapa.MapElements.Clear();

                        foreach (var latlong in locations)
                        {
                            polyline.Geopath.Add(new Position(latlong.Lng, latlong.Lat));

                        }
                        mapa.MapElements.Add(polyline);


                    }
                }
            }
            catch (Exception)
            {
                RouteDistance = "Out of range ";
            }


        }

        public void AddLocation(double longitude, double latitude)
        {
            if (_pinCreatedCount == 0)
            {
                
                _locations.Add(new Location("Odabrana destinacija", "//*", new Position(longitude, latitude)));
                _pinCreatedCount++;
                
            }
            else
            {
                _locations[_locations.Count() - 1].Position = new Position(longitude, latitude);
            }
        }
        public void RemoveLastPin()
        {
            _pinCreatedCount--;
            _locations.Remove(_locations[_locations.Count() - 1]);
            Destinacija = null;

        }
    }
}
