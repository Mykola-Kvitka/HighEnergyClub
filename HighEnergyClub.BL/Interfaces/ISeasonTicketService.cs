using HighEnergyClub.BL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Interfaces
{
    public interface ISeasonTicketService
    {
        Task CreateAsync(SeasonTicket request);
        Task<int> GetCountAsync();
        Task<IEnumerable<SeasonTicket>> GetPagedAsync(int page = 1, int pageSize = 15);
        Task<IEnumerable<SeasonTicket>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task<SeasonTicket> GetAsync(Guid id);
        Task UpdateAsync(SeasonTicket request);

    }
}
