using System.Collections.ObjectModel;

namespace StarWars_Web_App.Models
{
    public class PersonModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
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

            public HomeWorldModel HomeWorld { get; set; } = new HomeWorldModel();
            public List<string> films { get; set; }

            public ObservableCollection<FilmModel> Film { get; set; } = new ObservableCollection<FilmModel>();
            public List<object> species { get; set; }
            public ObservableCollection<SpeciesModel> Species { get; set; } = new ObservableCollection<SpeciesModel>();
            public List<string> vehicles { get; set; }
            public ObservableCollection<VehicelsModel> Vehicels { get; set; } = new ObservableCollection<VehicelsModel>();
            public List<string> starships { get; set; }
            public ObservableCollection<StarShipModel> Starships { get; set; } = new ObservableCollection<StarShipModel>();
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }
        }
    }
}
