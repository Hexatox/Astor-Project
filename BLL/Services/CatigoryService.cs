using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CatigoryService : ICatigoryService
    {
        private readonly ICatigoryRepository catigoryRepository;
        public CatigoryService(ICatigoryRepository catigoryRepository)
        {
            this.catigoryRepository = catigoryRepository;
        }
        // Add methods here
    }
}
