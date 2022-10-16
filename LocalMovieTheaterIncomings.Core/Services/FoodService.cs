using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Repositories.Interfaces;
using LocalMovieTheaterIncomings.Core.Services.Interfaces;

namespace LocalMovieTheaterIncomings.Core.Services
{
    public class FoodService : IFoodService 
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public IEnumerable<FoodItem> GetAllSold() => _foodRepo.GetAllSold();
    }
}
