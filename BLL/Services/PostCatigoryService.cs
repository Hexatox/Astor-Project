using BLL.Services.IServices;
using DAL.Entities;
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

        public void AssignPostToCatigories(int postId, IList<int> Catigories)
        {
            foreach (var catigory in Catigories)
            {
                postCatigoryRepository.Add(new PostCatigory { PostId = postId, CatigoryId = catigory });
            }
            postCatigoryRepository.Save();
        }

        public async Task AssignPostToCatigoriesAsync(int postId, IList<int> Catigories)
        {
            for (int i = 0; i < Catigories.Count; i++)
            {
                await postCatigoryRepository.AddAsync(new PostCatigory { PostId = postId, CatigoryId = Catigories[i] });
            }
            await postCatigoryRepository.SaveAsync();
        }

        public void AssignPostToCatigory(int postId , int CatigoryId)
        {
            postCatigoryRepository.Add (new PostCatigory { PostId = postId, CatigoryId = CatigoryId });
            postCatigoryRepository.Save();
        }

        public async Task AssignPostToCatigoryAsync(int postId, int CatigoryId)
        {
            await postCatigoryRepository.AddAsync(new PostCatigory { PostId = postId, CatigoryId = CatigoryId });
            postCatigoryRepository.Save();
        }
    }
}
