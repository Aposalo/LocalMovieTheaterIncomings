using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

namespace LocalMovieTheaterIncomings.Core.Repositories
{
    public class TicketRepository  : ITicketRepository  {

        public override IEnumerable<Ticket> GetAllSold()
        {
            return Tickets.ToList();
        }

    }
}
