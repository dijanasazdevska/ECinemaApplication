using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ECinema.Web.Models.DomainModels.Enumerations;

namespace ECinema.Web.Models.DomainModels
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string MovieName { get; set; }
        public string MovieImage { get; set; }
        public string Language { get; set; }

        public MovieGenre Genre { get; set; }

        public virtual ICollection<ActorsInMovies> ActorsInMovies { get; set; }
        public virtual  ICollection<Ticket> Tickets { get; set; }
    }
}
