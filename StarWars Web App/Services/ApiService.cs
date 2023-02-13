using Newtonsoft.Json;
using StarWars_Web_App.Models;
using static System.Net.WebRequestMethods;

namespace StarWars_Web_App.Services
{
    public class ApiService
    {
        public ApiService() { }

        public async Task<PeopleModel.Root> PeopleAPICall()
        {
            PeopleModel.Root model = new PeopleModel.Root();
            PeopleModel.Root more = new PeopleModel.Root();
            HttpClient httpClient = new HttpClient();
            var url = "https://swapi.dev/api/people/";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                model = JsonConvert.DeserializeObject<PeopleModel.Root>(await response.Content.ReadAsStringAsync());
            }
            var moreUrl = "https://swapi.dev/api/people/?page=2";
            var moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }

            moreUrl = "https://swapi.dev/api/people/?page=3";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }
            moreUrl = "https://swapi.dev/api/people/?page=4";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }

            moreUrl = "https://swapi.dev/api/people/?page=5";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }

            moreUrl = "https://swapi.dev/api/people/?page=6";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }

            moreUrl = "https://swapi.dev/api/people/?page=7";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }

            moreUrl = "https://swapi.dev/api/people/?page=8";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }

            moreUrl = "https://swapi.dev/api/people/?page=9";
            moreResponse = await httpClient.GetAsync(moreUrl);
            if (moreResponse.IsSuccessStatusCode)
            {
                more = JsonConvert.DeserializeObject<PeopleModel.Root>(await moreResponse.Content.ReadAsStringAsync());
                foreach (var item in more.results)
                {
                    model.results.Add(item);
                }
            }



            return model;
        }

        public async Task<PeopleModel.Root> SearchPeopleAPICall(string searchName)
        {
            PeopleModel.Root model = new PeopleModel.Root();
            HttpClient httpClient = new HttpClient();
            var url = $"https://swapi.dev/api/people/?search={searchName}";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                model = JsonConvert.DeserializeObject<PeopleModel.Root>(await response.Content.ReadAsStringAsync());
            }

            return model;
        }

        public async Task<PersonModel.Root> GetPersonByID(string Uri)
        {
            HttpClient httpClient = new HttpClient();
            PersonModel.Root model = new PersonModel.Root();
            FilmModel filmModel = new FilmModel();
            VehicelsModel vehicelsModel = new VehicelsModel();
            StarShipModel starShipModel = new StarShipModel();
            HomeWorldModel homeWorld = new HomeWorldModel();
            SpeciesModel species = new SpeciesModel();

            var Url = Uri;
            var response = await httpClient.GetAsync(Url);
            if(response.IsSuccessStatusCode)
            {
                model = JsonConvert.DeserializeObject<PersonModel.Root>(await response.Content.ReadAsStringAsync());
            }

            foreach(var movie in model.films)
            {
                
                var url = movie;
                var MovieResponse = await httpClient.GetAsync(url);
                if (MovieResponse.IsSuccessStatusCode)
                {
                    filmModel = JsonConvert.DeserializeObject<FilmModel>(await MovieResponse.Content.ReadAsStringAsync());
                    model.Film.Add(filmModel);
                }
            }

            foreach(var x in model.vehicles)
            {
                var url = x;
                var vehicledResponse = await httpClient.GetAsync(url);
                if (vehicledResponse.IsSuccessStatusCode)
                {
                    vehicelsModel = JsonConvert.DeserializeObject<VehicelsModel>(await vehicledResponse.Content.ReadAsStringAsync());
                    model.Vehicels.Add(vehicelsModel);
                }
            }

            foreach(var S in model.starships)
            {
                var url = S;
                var starShipResponse = await httpClient.GetAsync(url);
                if(starShipResponse.IsSuccessStatusCode)
                {
                    starShipModel = JsonConvert.DeserializeObject<StarShipModel>(await starShipResponse.Content.ReadAsStringAsync());
                    model.Starships.Add(starShipModel);
                }
            }

            var HomeWorldUrl = model.homeworld;
            var HomeWorldResponse = await httpClient.GetAsync(HomeWorldUrl);
            if (HomeWorldResponse.IsSuccessStatusCode)
            {
                homeWorld = JsonConvert.DeserializeObject<HomeWorldModel>(await HomeWorldResponse.Content.ReadAsStringAsync());
                model.HomeWorld = homeWorld;
            }

            foreach (var sp in model.species)
            {
                var speciesUrl = sp.ToString();
                var speciesResponse = await httpClient.GetAsync(speciesUrl);
                if (speciesResponse.IsSuccessStatusCode) 
                {
                    species = JsonConvert.DeserializeObject<SpeciesModel>(await speciesResponse.Content.ReadAsStringAsync());
                    model.Species.Add(species);
                }
            }
       

            

            return model;
        }

        public async Task<FilmsListModel.Root> GetAllFilms()
        {
            var model = new FilmsListModel.Root();
            var httpClient = new HttpClient();

            var filmsUrl = "https://swapi.dev/api/films/";
            var filmsResponse = await httpClient.GetAsync(filmsUrl);
            if(filmsResponse.IsSuccessStatusCode)
            {
                model = JsonConvert.DeserializeObject<FilmsListModel.Root>(await filmsResponse.Content.ReadAsStringAsync());
            }

            return model;
        }

        public async Task<FilmModel> GetFilmByUrl(string url)
        {
            FilmModel model = new FilmModel();
            PersonModel.Root person = new PersonModel.Root();
            HomeWorldModel homeWorld = new HomeWorldModel();
            SpeciesModel species = new SpeciesModel();
            StarShipModel starShip = new StarShipModel();
            VehicelsModel vehicels = new VehicelsModel();
            var httpClient = new HttpClient();

            var filmUrl = url;
            var filmResponse = await httpClient.GetAsync(filmUrl);
            if(filmResponse.IsSuccessStatusCode)
            {
                model = JsonConvert.DeserializeObject<FilmModel>(await filmResponse.Content.ReadAsStringAsync());
            }

            foreach(var p in model.characters)
            {
                var personUrl = p;
                var personResponse = await httpClient.GetAsync(personUrl);
                if(personResponse.IsSuccessStatusCode)
                {
                    person = JsonConvert.DeserializeObject<PersonModel.Root>(await personResponse.Content.ReadAsStringAsync());
                    model.persons.Add(person);
                }
            }

            foreach(var w in model.planets)
            {
                var worldUrl = w;
                var worldResponse = await httpClient.GetAsync(worldUrl);
                if(worldResponse.IsSuccessStatusCode)
                {
                    homeWorld = JsonConvert.DeserializeObject<HomeWorldModel>(await worldResponse.Content.ReadAsStringAsync());
                    model.worlds.Add(homeWorld);
                }

            }

            foreach(var s in model.species)
            {
                var speciesUrl = s;
                var speciesResponse = await httpClient.GetAsync(speciesUrl);
                if(speciesResponse.IsSuccessStatusCode)
                {
                    species = JsonConvert.DeserializeObject<SpeciesModel>(await speciesResponse.Content.ReadAsStringAsync());
                    model.Species.Add(species);
                }
            }

            foreach(var SH in model.starships)
            {
                var starshipsUrl = SH;
                var starshipResponse = await httpClient.GetAsync(starshipsUrl);
                if(starshipResponse.IsSuccessStatusCode)
                {
                    starShip = JsonConvert.DeserializeObject<StarShipModel>(await starshipResponse.Content.ReadAsStringAsync());
                    model.starShips.Add(starShip);
                }
            }

            foreach(var v in model.vehicles)
            {
                var vehiclesUrl = v;
                var vehiclesResponse = await httpClient.GetAsync(vehiclesUrl);
                if (vehiclesResponse.IsSuccessStatusCode)
                {
                    vehicels = JsonConvert.DeserializeObject<VehicelsModel>(await vehiclesResponse.Content.ReadAsStringAsync());
                    model.vehicelsModels.Add(vehicels);
                }
            }

            return model;
        }

    }
}
