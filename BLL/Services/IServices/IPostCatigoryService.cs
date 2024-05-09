using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IServices
{
    public interface IPostCatigoryService : IService
    {
        public void AssignPostToCatigory(int postId, int CatigoryId);
        public Task AssignPostToCatigoryAsync(int postId, int CatigoryId);
        public void AssignPostToCatigories(int postId, IList<int> Catigories);
        public Task AssignPostToCatigoriesAsync(int postId, IList<int> Catigories);
        
    }
}
