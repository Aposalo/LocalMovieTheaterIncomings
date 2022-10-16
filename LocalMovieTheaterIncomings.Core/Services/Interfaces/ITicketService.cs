using LocalMovieTheaterIncomings.Core.Models;

namespace LocalMovieTheaterIncomings.Core.Services.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<Ticket?> GetAllSold();
    }
}
