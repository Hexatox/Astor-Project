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
    public class PostServices : IPostService
    {
        private readonly IPostRepository postRepository;
        public PostServices(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

		public void AddPost(Post post)
		{
			postRepository.Add(post);
            postRepository.Save();
		}

		public async Task AddPostAsync(Post post)
		{
            await postRepository.AddAsync(post);
            await postRepository.SaveAsync();
		}

		/// <summary>
		/// Create Post 
		/// </summary>
		/// <param name="post"></param>
		public void CreatePost(Post post)
        {
            post.PostDate = DateTime.Now;
            postRepository.Add(post);
        }
        /// <summary>
        /// Create Post Async
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public async Task CreatePostAsync(Post post)
        {
            post.PostDate = DateTime.Now;
            await postRepository.AddAsync(post);
        }
        /// <summary>
        /// Delete Post that has the same id and authorId (for specific Author)
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public bool DeletePost(int postId, string authorId)
        {
            Post? post = postRepository.Find(postId);
            if (post == null || post.UserId != authorId) 
            {
                return false;
            }  
            postRepository.Remove(post);
            postRepository.Save();  
            return true;
        }
        /// <summary>
        /// Delete Post that has the same id and authorId (for specific Author) Async
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public async Task<bool> DeletePostAsync(int postId, string authorId)
        {
            Post? post = await postRepository.FindAsync(postId);
            if (post == null || post.UserId != authorId)
            {
                return false;
            }
            await postRepository.RemoveAsync(post);
            await postRepository.SaveAsync();
            return true;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return postRepository.GetAll();
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await postRepository.GetAllAsync();
        }
        /// <summary>
        /// Get Page page number base 0 
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public IEnumerable<Post> GetPage(int pageNumber)
        {
            IEnumerable<Post> posts = postRepository.GetAll();
            return posts.Skip((pageNumber) * 10).Take(10);
        }
        /// <summary>
        /// Get Page Async page number base 0 
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Post>> GetPageAsync(int pageNumber)
        {
            IEnumerable<Post> posts = await postRepository.GetAllNavs();
            return await Task.FromResult(posts.Skip((pageNumber) * 10).Take(10));
        }
        /// <summary>
        /// get post by id 
        /// </summary>
        /// <param name="postId">post Id</param>
        /// <returns></returns>
        /// <exception cref="Exception">Throws Exception when Post is not Exist</exception>
        public Post GetPostById(int postId)
        {
            var post = postRepository.Find(postId);
            if (post == null)
            {
                throw new Exception("Post not found");
            }
            return post;
        }
        /// <summary>
        /// get post by id async 
        /// </summary>
        /// <param name="postId">post Id</param>
        /// <returns></returns>
        /// <exception cref="Exception">Throws Exception when Post is not Exist</exception>
        public async Task<Post> GetPostByIdAsync(int postId)
        {
            var post = await postRepository.GetBy(postId);
            if (post == null)
            {
                throw new Exception("Post not found");
            }
            return post;
        }

        public IEnumerable<Post> GetPostsByAuthorId(string authorId)
        {
            var posts = postRepository.Filter(p => p.UserId == authorId);
            return posts;
        }

        public async Task<IEnumerable<Post>> GetPostsByAuthorIdAsync(string authorId)
        {
            return await postRepository.FilterAsync(p => p.UserId == authorId);
        }
        public bool UpdatePost(Post post, string authorId)
        {
            if (post.UserId != authorId)
            {
                return false;
            }   
            postRepository.Update (post);
            postRepository.Save();
            return true;
        }

        public async Task<bool> UpdatePostAsync(Post post, string authorId)
        {
            if (post.UserId != authorId)
            {
                return false;
            }
            await postRepository.UpdateAsync(post);
            await postRepository.SaveAsync();
            return true;
        }
    }
}
