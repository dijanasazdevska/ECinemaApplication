using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ECinema.Web.Models.DomainModels.Enumerations;

namespace ECinema.Web.Models.DomainModels
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime MovieDate { get; set; }
        public float TicketPrice { get; set; }
        public Movie movie { get; set; }

    }
}
