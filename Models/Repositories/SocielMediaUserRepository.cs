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
    public class SocielMediaUserRepository : Repository<SocielMediaUser> , ISocielMediaUserRepository
    {
        private readonly AppDbContext appDbContext;
        public SocielMediaUserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }
    }
}
