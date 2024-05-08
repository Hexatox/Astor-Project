using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IServices
{
    public interface ICatigoryService : IService
    {
        // here the methods that will be implemented in the CatigoryService class
        IEnumerable<Catigory> GetAll();
        Task<IEnumerable<Catigory>> GetAllAsync();
        Catigory? Find(int id);
        Task<Catigory?> FindAsync(int id);
        bool Add(Catigory catigory);
        Task<bool> AddAsync(Catigory catigory);
        bool Remove(int id);
        Task<bool> RemoveAsync(int id);
    }
}
