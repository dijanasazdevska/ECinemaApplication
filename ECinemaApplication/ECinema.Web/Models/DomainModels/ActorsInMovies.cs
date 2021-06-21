using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECinema.Web.Models.DomainModels
{
    public class ActorsInMovies
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public Actor actor { get; set; }
        public Movie movie { get; set; }
    }
}
