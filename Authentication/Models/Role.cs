using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
