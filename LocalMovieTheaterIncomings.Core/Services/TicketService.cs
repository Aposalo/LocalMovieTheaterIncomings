using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Repositories.Interfaces;
using LocalMovieTheaterIncomings.Core.Services.Interfaces;

namespace LocalMovieTheaterIncomings.Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public IEnumerable<Ticket?> GetAllSold() => _ticketRepo.GetAllSold();
    }
}
