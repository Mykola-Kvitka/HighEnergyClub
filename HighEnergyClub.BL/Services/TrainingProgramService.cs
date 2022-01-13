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
    public class TrainingProgramService : ITrainingProgramService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingProgramService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task CreateAsync(TrainingProgram request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrainingProgram>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TrainingProgram> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrainingProgram>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TrainingProgram request)
        {
            throw new NotImplementedException();
        }
    }
}
