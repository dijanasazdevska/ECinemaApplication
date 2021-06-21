using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECinema.Web.Models.DomainModels
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  Birthday { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ActorsInMovies> ActorsInMovies { get; set; }
    }
}
