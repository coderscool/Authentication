using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public List<Pictur> Picturs { get; set; }
    }
}
