using LocalMovieTheaterIncomings.Core.Models;

namespace LocalMovieTheaterIncomings.Core.Services.Interfaces
{
    public interface IFinancialsService
    {
        decimal? GetTotalSold();
        FinancialStats GetStats();
    }
}
