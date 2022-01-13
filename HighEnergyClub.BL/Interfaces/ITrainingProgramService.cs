using HighEnergyClub.BL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Interfaces
{
    public interface ITrainingProgramService
    {
        Task CreateAsync(TrainingProgram request);
        Task<int> GetCountAsync();
        Task<IEnumerable<TrainingProgram>> GetPagedAsync(int page = 1, int pageSize = 15);
        Task<IEnumerable<TrainingProgram>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task<TrainingProgram> GetAsync(Guid id);
        Task UpdateAsync(TrainingProgram request);

    }
}
