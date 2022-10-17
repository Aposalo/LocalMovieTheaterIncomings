using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

namespace LocalMovieTheaterIncomings.Core.Repositories {
    
    public class FoodRepository : IFoodRepository {

        public override IEnumerable<FoodItem> GetAllSold()
        {
            return Items.ToList();
        }
    }
}
