using BLL.Services.IServices;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LikeService : ILikeService 
    {
        private readonly ILikeRepository likeRepository;
        public LikeService(ILikeRepository likeRepository)
        {
            this.likeRepository = likeRepository;
        }

        public void AddLike(int postId, string userId)
        {
            if (likeRepository.Find(new { PostId = postId, UserId = userId }) != null)
            {
                return;
            }
            likeRepository.Add(new Like { PostId = postId, UserId = userId });
            likeRepository.Save();
        }

        public async Task AddLikeAsync(int postId, string userId)
        {
            if (await likeRepository.FindAsync(new { PostId = postId, UserId = userId }) != null)
            {
                return;
            }
            await likeRepository.AddAsync(new Like { PostId = postId, UserId = userId });
            await likeRepository.SaveAsync();
        }

        public void RemoveLike(int postId, string userId)
        {
            var like = likeRepository.Find(new { PostId = postId, UserId = userId });
            if (like != null)
            {
                likeRepository.Remove(like);
                likeRepository.Save();
            }
        }

        public async Task RemoveLikeAsync(int postId, string userId)
        {
            var like = await likeRepository.FindAsync(new { PostId = postId, UserId = userId });
            if (like != null)
            {
                await likeRepository.RemoveAsync(like);
                await likeRepository.SaveAsync();
            }
        }
        // Add methods here
    }
}
