using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IRequestRepository : IRepository <Entities.Request>
    {
        public Task<List<Request>> GetAllNavs();
        public Task<Request> GetBy (int id);
    }
}
