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
    public class ExerciseService : IExerciseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ExerciseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(Exercise request)
        {
            var requestEntity = _mapper.Map<Exercise, ExerciseEntity>(request);

            await _unitOfWork.Exercises.CreateAsync(requestEntity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var request = await GetAsync(id);

            await _unitOfWork.Exercises.DeleteAsync(id);
        }

        public async Task<IEnumerable<Exercise>> GetAllAsync()
        {
            var exercises = await _unitOfWork.Exercises.GetAllAsync();

            return _mapper.Map<IEnumerable<ExerciseEntity>, IEnumerable<Exercise>>(exercises);
        }

        public async Task<Exercise> GetAsync(Guid id)
        {
            var exercises = await _unitOfWork.Exercises.GetAsync(id);

            return _mapper.Map<ExerciseEntity, Exercise>(exercises);
        }

        public async Task<int> GetCountAsync()
        {
            return await _unitOfWork.Exercises.GetCountAsync();
        }

        public async Task<IEnumerable<Exercise>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            var orgonizers = await _unitOfWork.Exercises.GetPagedAsync(page, pageSize);

            return _mapper.Map<IEnumerable<ExerciseEntity>, IEnumerable<Exercise>>(orgonizers);
        }

        public async Task UpdateAsync(Exercise request)
        {
            var requestEntity = _mapper.Map<Exercise, ExerciseEntity>(request);

            await _unitOfWork.Exercises.UpdateAsync(requestEntity);
        }
    }
}
