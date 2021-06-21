using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECinema.Web.Models.DomainModels;

namespace ECinema.Web.Models.DTO
{
    public class CreateTicketDto
    {
        public Ticket ticket { get; set; }
        public IEnumerable<Movie> AllMovies { get; set; }
        public IEnumerable<Actor> AllActors { get; set; }
        public Guid movieId { get; set; }
    }
}
