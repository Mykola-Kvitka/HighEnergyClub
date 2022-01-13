using AutoMapper;
using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Models;
using HighEnergyClub.DAL.Interfaces;
using HighEnergyClub.DAL.Models;
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

        public async Task CreateAsync(SeasonTicket request)
        {
            var requestEntity = _mapper.Map<SeasonTicket, SeasonTicketEntity>(request);

            await _unitOfWork.SeasonTickets.CreateAsync(requestEntity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var request = await GetAsync(id);

            await _unitOfWork.Exercises.DeleteAsync(id);
        }

        public async Task<IEnumerable<SeasonTicket>> GetAllAsync()
        {
            var seasonTicketEntities = await _unitOfWork.SeasonTickets.GetAllAsync();

            return _mapper.Map<IEnumerable<SeasonTicketEntity>, IEnumerable<SeasonTicket>>(seasonTicketEntities);
        }

        public async Task<SeasonTicket> GetAsync(Guid id)
        {
            var seasonTicketEntities = await _unitOfWork.SeasonTickets.GetAsync(id);

            return _mapper.Map<SeasonTicketEntity, SeasonTicket>(seasonTicketEntities);
        }

        public async Task<int> GetCountAsync()
        {
            return await _unitOfWork.SeasonTickets.GetCountAsync();
        }

        public async Task<IEnumerable<SeasonTicket>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            var seasonTicketEntities = await _unitOfWork.SeasonTickets.GetPagedAsync(page, pageSize);

            return _mapper.Map<IEnumerable<SeasonTicketEntity>, IEnumerable<SeasonTicket>>(seasonTicketEntities);
        }

        public async Task UpdateAsync(SeasonTicket request)
        {
            var requestEntity = _mapper.Map<SeasonTicket, SeasonTicketEntity>(request);

            await _unitOfWork.SeasonTickets.UpdateAsync(requestEntity);
        }
    }
}
