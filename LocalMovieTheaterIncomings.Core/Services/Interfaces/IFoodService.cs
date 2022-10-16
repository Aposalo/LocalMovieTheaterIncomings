using LocalMovieTheaterIncomings.Core.Models;

namespace LocalMovieTheaterIncomings.Core.Services.Interfaces
{
    public interface IFoodService
    {
        IEnumerable<FoodItem> GetAllSold();
    }
}
