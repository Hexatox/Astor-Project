using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<Post> GetBy(int Id);
        public Task<List<Post>> GetAllNavs();
        Task<Post> GetAllByAsync(string id);
    }
}
