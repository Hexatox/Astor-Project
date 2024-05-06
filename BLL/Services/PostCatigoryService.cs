using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PostCatigoryService : IPostCatigoryService
    {
        private readonly IPostCatigoryRepository postCatigoryRepository;
        public PostCatigoryService(IPostCatigoryRepository postCatigoryRepository)
        {
            this.postCatigoryRepository = postCatigoryRepository;
        }
    }
}
