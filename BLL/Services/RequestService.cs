using BLL.Services.IServices;
using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository requestRepository;
        public RequestService(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }
    }
}
