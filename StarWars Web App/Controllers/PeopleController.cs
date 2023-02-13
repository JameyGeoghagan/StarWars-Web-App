using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StarWars_Web_App.Models;
using StarWars_Web_App.Services;

namespace StarWars_Web_App.Controllers
{
    public class PeopleController : Controller
    {
        private ApiService apiService = new ApiService(); 

        public async Task<IActionResult> Index(string searchName)
        {
            PeopleModel.Root model = new PeopleModel.Root();
            if(searchName == null)
            {
                 model = await apiService.PeopleAPICall(); 
            }
            else
            {
                model = await apiService.SearchPeopleAPICall(searchName);
            }
                     

            return View(model);
        }

        public async Task<IActionResult> PersonByUrl(string Url)
        {
            PersonModel.Root model = new PersonModel.Root();
            model = await apiService.GetPersonByID(Url);

            return View(model);
        }

  
    }
}
