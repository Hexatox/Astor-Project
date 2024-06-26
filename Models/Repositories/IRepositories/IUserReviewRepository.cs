﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IUserReviewRepository : IRepository<UserReview>
    {
        public Task<List<UserReview>> GetAllNavs();
    }
}
