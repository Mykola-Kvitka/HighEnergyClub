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
    public class TrainingProgramService : ITrainingProgramService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingProgramService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// need add student trainer dependency
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task CreateAsync(SaveTrainingProgram request)
        {
            var requestEntity = _mapper.Map<SaveTrainingProgram, TrainingProgramEntity>(request);

            var result = (await _unitOfWork.TrainingPrograms.CreateAsync(requestEntity)).Id;

            await ProcessProgramExercisesDependencyAdding(request, result);
        }   

        public async Task DeleteAsync(Guid id)
        {
            await _unitOfWork.TrainingPrograms.DeleteAsync(id);

            await ProcessProgramExercisesDependencyRemove(id);
        }

        public async Task<IEnumerable<TrainingProgramDisplay>> GetAllAsync()
        {
            var result = await _unitOfWork.TrainingPrograms.GetAllAsync();

            var trainingProgram = _mapper.Map<List<TrainingProgramEntity>, List<TrainingProgramDisplay>>(result);

            await ProcessTrainingProgramExerciseGetting(trainingProgram);

            return trainingProgram;
        }


        public async Task<TrainingProgramDisplay> GetAsync(Guid id)
        {
            var result = await _unitOfWork.TrainingPrograms.GetAsync(id);

            var trainingProgram = _mapper.Map<TrainingProgramEntity, TrainingProgramDisplay>(result);

            //TODO:
           // await ProcessTrainingProgramExerciseGetting(trainingProgram);

            return trainingProgram;
        }

        public async Task<int> GetCountAsync()
        {
            return await _unitOfWork.TrainingPrograms.GetCountAsync();
        }

        public async Task<IEnumerable<TrainingProgram>> GetPagedAsync(int page = 1, int pageSize = 15)
        {
            var TrainingPrograms = await _unitOfWork.TrainingPrograms.GetPagedAsync(page, pageSize);

            return _mapper.Map<IEnumerable<TrainingProgramEntity>, IEnumerable<TrainingProgram>>(TrainingPrograms);
        }

        public async Task UpdateAsync(TrainingProgram request)
        {
            throw new NotImplementedException();
        }
        private async Task ProcessProgramExercisesDependencyAdding(SaveTrainingProgram request, Guid result)
        {
            foreach (var item in request.ExerciseEntityID)
            {
                var entity = new TrainingProgramExerciseEntity()
                {
                    ExerciseEntityID = item,
                    TrainingProgramID = result,
                    Approaches = request.Approaches,
                    NumberRepitions = request.NumberRepitions,
                    Weight = request.Weight
                };

                await _unitOfWork.TrainingProgramExercises.CreateAsync(entity);
            }
        }
        private async Task ProcessProgramExercisesDependencyRemove(Guid id)
        {
            var result = await _unitOfWork.TrainingProgramExercises.FindAsync(program => program.TrainingProgramID == id);

            foreach (var item in result)
            {
                await _unitOfWork.TrainingProgramExercises.DeleteAsync(item.Id);
            }
        }
        private async Task ProcessTrainingProgramExerciseGetting(IEnumerable<TrainingProgramDisplay> trainingProgram)
        {
            foreach (var item in trainingProgram)
            {
                 item.trainingProgramExercises.AddRange(
                     (IEnumerable<TrainingProgramExercise>)
                     (await _unitOfWork.TrainingProgramExercises
                     .FindAsync(a => a.TrainingProgramID == item.Id))
                     );
            }       
        }


    }
}
