using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MessegeService : IMessegeService
    {
        private readonly IMessegeRepository messegeRepository;
        public MessegeService(IMessegeRepository messegeRepository)
        {
            this.messegeRepository = messegeRepository;
        }
    }
}
