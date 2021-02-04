using eZdravaIshrana_PCL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
///using Xamarin.Essentials;

namespace eZdravaIshrana_UI.Util
{
    public class OSRMRouteService
    {
        private readonly string baseRouteUrl1 = "http://router.project-osrm.org/route/v1/driving/";
        private readonly string baseRouteUrl = "https://api.mapbox.com/directions/v5/mapbox/driving/";
        
        private HttpClient _httpClient;

        public OSRMRouteService() 
        {
            _httpClient = new HttpClient();
        }
        public async Task<RouteHlpClass> GetRouteHlpAsync(LatLong skladiste, LatLong desitination)
        {
       
            if (skladiste == null || desitination == null)
            { return null; }

            if (skladiste != null || desitination != null)
            {
                //string url = string.Format(baseRouteUrl) + $"{originLocation.Longitude},{originLocation.Latitude};" +
                //                                            $"{desitinationLocation.Longitude},{desitinationLocation.Latitude}?overview=full&geometries=polyline&steps=false";
                string url = string.Format(baseRouteUrl) + $"{skladiste.Lat}%2C{skladiste.Lng}%3B" +
                                                               $"{desitination.Lat}%2C{desitination.Lng}?alternatives=true&geometries=polyline&steps=true&access_token=pk.eyJ1IjoicnVsZXJpeCIsImEiOiJjazlsaDEzZjEwNXFiM2VwYndzNzV4bTV3In0.tM9RGRD9pW7Y2oZP4WTxJQ";
                var reposne = await _httpClient.GetAsync(url);
                var json = await reposne.Content.ReadAsStringAsync();
                if (reposne.IsSuccessStatusCode)
                {
                   
                    var result = JsonConvert.DeserializeObject<RouteHlpClass>(json);
                    return result;
                }

            }
            else
            {
                return null;
            }
            return null;
        }
    }
}
