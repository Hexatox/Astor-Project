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
    public class RequestRepository : Repository<Request> , IRequestRepository
    {
        private readonly AppDbContext appDbContext;
        public RequestRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Request>> GetAllNavs()
        {
            var items = await appDbContext.Requests
                .Include(p => p.User)
                .Include(p => p.Admin)
                
                .ToListAsync();
            return items;
        }

        public async Task<Request> GetBy(int id)
        {
            var item = await appDbContext.Requests
                .Include(p => p.User)
                .Include(p => p.Admin)
                .FirstOrDefaultAsync(p => p.RequestId == id);
            return item;
        }
    }
}
