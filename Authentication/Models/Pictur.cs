using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models
{
    public class Pictur
    {
        public int PicturId { get; set; }
        public string Title { get; set; }
        public int UsId { get; set; }
        public User User { get; set; }
    }
}
