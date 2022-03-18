using Authentication.Application.Catalog.Dtos.Pictur;
using Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Application.Catalog
{
    public interface IPicturService
    {
        Task<int> Create(PicturCreateRequest request);

        Task<List<PicturGetAll>> GetAll();
        
        Task<Pictur> GetById(int PicturId);
    }
}
