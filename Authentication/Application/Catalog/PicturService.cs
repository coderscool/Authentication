using Authentication.Application.Catalog.Dtos.Pictur;
using Authentication.Data.EF;
using Authentication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Application.Catalog
{
    public class PicturService : IPicturService 
    {
        private readonly AuthenticationDbContext _context;
        public PicturService(AuthenticationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(PicturCreateRequest request)
        {
            var pictur = new Pictur()
            {
                Title = request.Title,
            };
            _context.Picturs.Add(pictur);
            await _context.SaveChangesAsync();
            return pictur.PicturId;
        }

        public async Task<List<PicturGetAll>> GetAll()
        {
            var query = from p in _context.Picturs
                        select new { p };

            var data = await query.Select(x => new PicturGetAll()
            {
                PicturId = x.p.PicturId,
                Title = x.p.Title
            }).ToListAsync();

            return data;
        }

        public async Task<Pictur> GetById(int PicturId)
        {
            var pictur = await _context.Picturs.FindAsync(PicturId);
            return pictur;
        }
    }
}
