using System.Collections.ObjectModel;

namespace StarWars_Web_App.Models
{
    public class FilmModel
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public List<string> characters { get; set; }
        public ObservableCollection<PersonModel.Root> persons { get; set; } = new ObservableCollection<PersonModel.Root>();
        public List<string> planets { get; set; }
        public ObservableCollection<HomeWorldModel> worlds { get; set; } = new ObservableCollection<HomeWorldModel>();
        public List<string> starships { get; set; }

        public ObservableCollection<StarShipModel> starShips { get; set; } = new ObservableCollection<StarShipModel>();
        public List<string> vehicles { get; set; }
        public ObservableCollection<VehicelsModel> vehicelsModels { get; set; } = new ObservableCollection<VehicelsModel>();
        public List<string> species { get; set; }
        public ObservableCollection<SpeciesModel> Species { get; set; } = new ObservableCollection<SpeciesModel>();
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }
}
