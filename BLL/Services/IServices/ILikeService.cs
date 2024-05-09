using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IServices
{
    public interface ILikeService : IService
    {
        // here the methods that will be implemented in the LikeService class
        void AddLike (int postId, string userId);
        Task AddLikeAsync(int postId, string userId);
        void RemoveLike(int postId, string userId);
        Task RemoveLikeAsync(int postId, string userId);
    }
}
