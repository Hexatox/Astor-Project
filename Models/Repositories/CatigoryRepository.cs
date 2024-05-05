using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CatigoryRepository : Repository<Catigory>, ICatigoryRepository
    {
        private readonly AppDbContext appDbContext;
        public CatigoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Catigory? GetCatigoryById(int id)
        {
            return Find(id);
        }

        public async Task<Catigory?> GetCatigoryByIdAsync(int id)
        {
            return await appDbContext.Catigories.FindAsync(id);
        }

        public Catigory? GetCatigoryByName(string name)
        {
            return appDbContext.Catigories.FirstOrDefault(c => c.CatigoryName == name);
        }

        public async Task<Catigory?> GetCatigoryByNameAsync(string name)
        {
            return await appDbContext.Catigories.FirstOrDefaultAsync(c => c.CatigoryName == name);
        }
    }

}
