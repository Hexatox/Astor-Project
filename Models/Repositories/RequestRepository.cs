using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
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
    }
}
