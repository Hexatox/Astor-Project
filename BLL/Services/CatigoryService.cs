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
    public class CatigoryService : ICatigoryService
    {
        private readonly ICatigoryRepository catigoryRepository;
        public CatigoryService(ICatigoryRepository catigoryRepository)
        {
            this.catigoryRepository = catigoryRepository;
        }

        public bool Add(Catigory catigory)
        {
            if (catigoryRepository.GetCatigoryByName (catigory.CatigoryName) != null)
            {
                return false;
            }
            catigoryRepository.Add(catigory);
            return true;
        }

        public async Task<bool> AddAsync(Catigory catigory)
        {
            var catigoryExist = await catigoryRepository.GetCatigoryByNameAsync(catigory.CatigoryName);
            if (catigoryExist != null)
            {
                return false;
            }
            await catigoryRepository.AddAsync(catigory);
            return true;
        }

        public Catigory? Find(int id)
        {
            return catigoryRepository.GetCatigoryById(id);
        }

        public Task<Catigory?> FindAsync(int id)
        {
            return catigoryRepository.GetCatigoryByIdAsync(id);
        }

        public IEnumerable<Catigory> GetAll()
        {
            return catigoryRepository.GetAll();
        }

        public async Task<IEnumerable<Catigory>> GetAllAsync()
        {
            return await catigoryRepository.GetAllAsync();
        }

        public bool Remove(int id)
        {
            return catigoryRepository.Remove(catigoryRepository.GetCatigoryById(id));
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await catigoryRepository.RemoveAsync(await catigoryRepository.GetCatigoryByIdAsync(id));
        }
        // Add methods here
    }
}
