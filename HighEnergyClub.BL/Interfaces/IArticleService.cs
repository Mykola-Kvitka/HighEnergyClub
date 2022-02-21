using HighEnergyClub.BL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Interfaces
{
    public interface IArticleService
    {
        Task CreateAsync(SaveArticle request);
        Task<int> GetCountAsync();
        Task<IEnumerable<Article>> GetPagedAsync(int page = 1, int pageSize = 15);
        Task<IEnumerable<Article>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task<Article> GetAsync(Guid id);
        Task UpdateAsync(UpdateArticle request);

    }
}
