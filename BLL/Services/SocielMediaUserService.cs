using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SocielMediaUserService : ISocielMediaUserService
    {
        private readonly ISocielMediaUserRepository socielMediaUserRepository;
        public SocielMediaUserService(ISocielMediaUserRepository socielMediaUserRepository)
        {
            this.socielMediaUserRepository = socielMediaUserRepository;
        }
    }
}
