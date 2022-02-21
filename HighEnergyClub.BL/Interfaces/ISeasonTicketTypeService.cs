using HighEnergyClub.BL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Interfaces
{
    public interface ISeasonTicketTypeService
    {
        Task CreateAsync(SeasonTicketType request);
        Task<int> GetCountAsync();
        Task<IEnumerable<SeasonTicketType>> GetPagedAsync(int page = 1, int pageSize = 15);
        Task<IEnumerable<SeasonTicketType>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task<SeasonTicketType> GetAsync(Guid id);
        Task UpdateAsync(SeasonTicketType request);
    }
}
