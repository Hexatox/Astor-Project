﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface ICommentRepository : IRepository <Comment>
    {
        public Task<List<Comment>> GetAllNavs();
    }
}
