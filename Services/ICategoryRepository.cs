using AthleteManagementApp.Models.Domain;

namespace AthleteManagementApp.Services
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetAsync(Guid id);
        Task<Category> AddAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Guid id);
    }
}
