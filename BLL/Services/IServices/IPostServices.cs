using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IServices
{
    public interface IPostService : IService
    {
        
        IEnumerable<Post> GetAllPosts();
        Task<IEnumerable<Post>> GetAllPostsAsync();
        IEnumerable<Post> GetPage(int pageNumber);
        Task<IEnumerable<Post>> GetPageAsync(int pageNumber);
        void CreatePost(Post post);
        Task CreatePostAsync(Post post);
        bool UpdatePost(Post post , string authorId);
        Task<bool> UpdatePostAsync(Post post , string authorId);
        bool DeletePost(int postId , string authorId);
        Task<bool> DeletePostAsync(int postId , string authorId);
        Post GetPostById(int postId);
        Task<Post> GetPostByIdAsync(int postId);
        IEnumerable<Post> GetPostsByAuthorId(string authorId);
        Task<IEnumerable<Post>> GetPostsByAuthorIdAsync(string authorId);
        //IEnumerable<Post> GetPostsInCatigory(int catigoryId);
        //Task<IEnumerable<Post>> GetPostsInCatigoryAsync(int catigoryId);
        //IEnumerable<Post> GetPostsInCatigories(List<int> catigories);
        //Task<IEnumerable<Post>> GetPostsInCatigoriesAsync(List<int> catigories);
    }
}
