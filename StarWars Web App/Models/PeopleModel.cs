using System.Collections.ObjectModel;

namespace StarWars_Web_App.Models
{
    public class PeopleModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Result
        {
            public string name { get; set; }
            public string height { get; set; }
            public string mass { get; set; }
            public string hair_color { get; set; }
            public string skin_color { get; set; }
            public string eye_color { get; set; }
            public string birth_year { get; set; }
            public string gender { get; set; }
            public string homeworld { get; set; }
            public List<string> films { get; set; }
            public List<string> species { get; set; }
            public List<string> vehicles { get; set; }

            public ObservableCollection<VehicelsModel> Vehicels { get; set; } = new ObservableCollection<VehicelsModel>();
            public List<string> starships { get; set; }
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }
        }

        public class Root
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public List<Result> results { get; set; }
        }


    }
}
