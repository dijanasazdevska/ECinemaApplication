using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ECinema.Web.Models.Identity
{
    public class ECinemaApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
