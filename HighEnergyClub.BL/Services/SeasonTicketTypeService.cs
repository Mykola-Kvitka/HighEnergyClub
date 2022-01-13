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
    public class SeasonTicketTypeService : ISeasonTicketTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SeasonTicketTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(SeasonTicketType request)
        {
            var requestEntity = _mapper.Map<SeasonTicketType, SeasonTicketTypeEntity>(request);

            await _unitOfWork.SeasonTicketTypes.CreateAsync(requestEntity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var request = await GetAsync(id);

            await _unitOfWork.SeasonTicketTypes.DeleteAsync(id);
        }

        public async Task<IEnumerable<SeasonTicketType>> GetAllAsync()
        {
            var SeasonTicketTypes = await _unitOfWork.SeasonTicketTypes.GetAllAsync();

            return _mapper.Map<IEnumerable<SeasonTicketTypeEntity>, IEnumerable<SeasonTicketType>>(SeasonTicketTypes);
        }

        public async Task<SeasonTicketType> GetAsync(Guid id)
        {
            var SeasonTicketTypes = await _unitOfWork.SeasonTicketTypes.GetAsync(id);

            return _mapper.Map<SeasonTicketTypeEntity, SeasonTicketType>(SeasonTicketTypes);
        }

        public async Task<int> GetCountAsync()
        {
            return await _unitOfWork.SeasonTicketTypes.GetCountAsync();
        }

        public async Task<IEnumerable<SeasonTicketType>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            var SeasonTicketTypes = await _unitOfWork.SeasonTicketTypes.GetPagedAsync(page, pageSize);

            return _mapper.Map<IEnumerable<SeasonTicketTypeEntity>, IEnumerable<SeasonTicketType>>(SeasonTicketTypes);
        }

        public async Task UpdateAsync(SeasonTicketType request)
        {
            var requestEntity = _mapper.Map<SeasonTicketType, SeasonTicketTypeEntity>(request);

            await _unitOfWork.SeasonTicketTypes.UpdateAsync(requestEntity);
        }
    }
}
