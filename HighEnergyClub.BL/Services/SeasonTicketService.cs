using AutoMapper;
using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Models;
using HighEnergyClub.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Services
{
    class SeasonTicketService : ISeasonTicketService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SeasonTicketService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task CreateAsync(SeasonTicket request)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SeasonTicket>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SeasonTicket> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SeasonTicket>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SeasonTicket request)
        {
            throw new NotImplementedException();
        }
    }
}
