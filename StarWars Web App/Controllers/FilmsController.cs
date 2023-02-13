using Microsoft.AspNetCore.Mvc;
using StarWars_Web_App.Models;
using StarWars_Web_App.Services;

namespace StarWars_Web_App.Controllers
{
    public class FilmsController : Controller
    {
        private ApiService apiService = new ApiService();
        public async Task<IActionResult> Index()
        {
            FilmsListModel.Root model = new FilmsListModel.Root();
            model = await apiService.GetAllFilms();
            return View(model);
        }

        public async Task<IActionResult> MovieByUrl (string url)
        {
            FilmModel model = new FilmModel();
            model = await apiService.GetFilmByUrl(url);

            return View(model);
        }
    }
}
