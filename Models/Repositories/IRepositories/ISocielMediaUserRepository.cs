using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface ISocielMediaUserRepository : IRepository <SocielMediaUser>
    {
        public Task<List<SocielMediaUser>> GetAllNavs();

    }
}
