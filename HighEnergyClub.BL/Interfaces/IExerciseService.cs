using HighEnergyClub.BL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Interfaces
{
    public interface IExerciseService
    {
        Task CreateAsync(Exercise request);
        Task<int> GetCountAsync();
        Task<IEnumerable<Exercise>> GetPagedAsync(int page = 1, int pageSize = 15);
        Task<IEnumerable<Exercise>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task<Exercise> GetAsync(Guid id);
        Task UpdateAsync(Exercise request);

    }
}
