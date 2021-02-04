using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_UI.Util
{
    public class LatLong
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public partial class RouteHlpClass
    {
        [JsonProperty("routes")]
        public List<Route> Routes { get; set; }

        [JsonProperty("waypoints")]
        public List<Waypoint> Waypoints { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public partial class Route
    {
        [JsonProperty("geometry")]
        public string Geometry { get; set; }

        [JsonProperty("legs")]
        public List<Leg> Legs { get; set; }

        [JsonProperty("weight_name")]
        public string WeightName { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    public partial class Leg
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("steps")]
        public List<Step> Steps { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    public partial class Step
    {
        [JsonProperty("intersections")]
        public List<Intersection> Intersections { get; set; }

        [JsonProperty("driving_side")]
        public string DrivingSide { get; set; }

        [JsonProperty("geometry")]
        public string Geometry { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("maneuver")]
        public Maneuver Maneuver { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }
    }

    public partial class Intersection
    {
        [JsonProperty("out", NullValueHandling = NullValueHandling.Ignore)]
        public long? Out { get; set; }

        [JsonProperty("entry")]
        public List<bool> Entry { get; set; }

        [JsonProperty("bearings")]
        public List<long> Bearings { get; set; }

        [JsonProperty("location")]
        public List<double> Location { get; set; }

        [JsonProperty("in", NullValueHandling = NullValueHandling.Ignore)]
        public long? In { get; set; }
    }

    public partial class Maneuver
    {
        [JsonProperty("bearing_after")]
        public long BearingAfter { get; set; }

        [JsonProperty("bearing_before")]
        public long BearingBefore { get; set; }

        [JsonProperty("location")]
        public List<double> Location { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Waypoint
    {
        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public List<double> Location { get; set; }
    }
}


