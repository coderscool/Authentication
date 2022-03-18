using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Application.Catalog.Dtos.Pictur
{
    public class PicturCreateRequest
    {
        public int PicturId { get; set; }
        public string Title { get; set; }
    }
}
