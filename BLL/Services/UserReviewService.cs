using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserReviewService : IUserReviewService
    {
        private readonly IUserReviewRepository userReviewRepository;
        public UserReviewService(IUserReviewRepository userReviewRepository)
        {
            this.userReviewRepository = userReviewRepository;
        }
    }
}
