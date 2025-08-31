
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerManaging.Models;
namespace DealerManaging.Services
{
    public interface IDaiLyService
    {
        Task<DaiLy> GetDaiLyById(int id);
        Task<IEnumerable<DaiLy>> GetAllDaiLy();
        Task<IEnumerable<DaiLy>> GetDaiLyPage(int offset, int size = 20);
        Task<int> GetTotalPages(int size = 20);
        Task AddDaiLy(DaiLy daiLy);
        Task UpdateDaiLy(DaiLy daiLy);
        Task DeleteDaiLy(int id);
        Task<DaiLy> GetDaiLyByTenDaiLy(string tenDaiLy);
        Task<int> GenerateAvailableId();
        Task<List<DaiLy>> GetDaiLysByIdsAsync(IEnumerable<int> ids);
        Task<int> GetTotalDaiLyUpToMonthYear(int month, int year);
        Task<DateTime?> GetEarliestDaiLyDateAsync();
    }
}
