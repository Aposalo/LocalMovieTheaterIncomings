using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocalMovieTheaterIncomings.Controllers
{ 
    
    [Produces("application/json")]
    [Route("Food")]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [Route("~/GetAllSold")]
        [HttpGet]
        public IEnumerable<FoodItem> GetAllSold()
        {
            return _foodService.GetAllSold();
        }

        public IActionResult Index()
        {
            
            return View(GetAllSold());
        }
    }
}