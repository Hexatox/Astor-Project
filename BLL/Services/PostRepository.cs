using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PostRepository : IPostServices
    {
        private readonly IPostRepository postRepository;
        public PostRepository(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
    }
}
