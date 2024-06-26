﻿using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MessegeRepository : Repository<Messege>, IMessegeRepository
    {
        private readonly AppDbContext appDbContext;
        public MessegeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Messege>> GetAllNavs()
        {
            var items = await appDbContext.Messeges
                .Include(p => p.User)
                
                .ToListAsync();
            return items;
        }
    }
}
