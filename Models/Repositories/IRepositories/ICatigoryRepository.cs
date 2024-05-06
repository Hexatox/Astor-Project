using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface ICatigoryRepository : IRepository<Catigory>
    {
        public Task<Catigory?> GetCatigoryByNameAsync(string name);
        public Catigory? GetCatigoryByName(string name);
        public Task<Catigory?> GetCatigoryByIdAsync(int id);
        public Catigory? GetCatigoryById(int id);
    }
}
