using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Repositories.Interfaces;
using LocalMovieTheaterIncomings.Core.Services.Interfaces;

namespace LocalMovieTheaterIncomings.Core.Services
{
    public class FinancialsService : IFinancialsService
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IFoodRepository _foodRepo;

        public FinancialsService(ITicketRepository ticketRepo,
                                 IFoodRepository foodRepo)
        {
            _ticketRepo = ticketRepo;
            _foodRepo = foodRepo;
        }

        public decimal? GetTotalSold()
        {
            var foodSold = _foodRepo.GetAllSold().Sum(x => x.Profit);
            var ticketsSold = _ticketRepo.GetAllSold().Sum(x => x.Profit);

            return foodSold + ticketsSold;
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            var foodSold = _foodRepo.GetAllSold();
            var ticketsSold = _ticketRepo.GetAllSold();

            //Calculate Average Stats
            stats.AverageTicketProfit = ticketsSold.Sum(x => x.Profit) / ticketsSold.Sum(x => x.Quantity);
            stats.AverageFoodItemProfit = foodSold.Sum(x => x.Profit) / foodSold.Sum(x => x.Quantity);

            return stats;
        }
    }
}
