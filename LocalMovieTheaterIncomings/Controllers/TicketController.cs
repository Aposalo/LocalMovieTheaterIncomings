using LocalMovieTheaterIncomings.Core.Models;
using LocalMovieTheaterIncomings.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocalMovieTheaterIncomings.Controllers
{
    
    [Produces("application/json")]
    [Route("Ticket")]
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
    
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [Route("~/GetAllSold")]
        [HttpGet]
        public IEnumerable<Ticket?> GetAllSold()
        {
            return _ticketService.GetAllSold();
        }

        public IActionResult Index()
        {
            return View(GetAllSold());
        }
    }
}

