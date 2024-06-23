using AthleteManagementApp.Data;
using AthleteManagementApp.Models.Domain;
using AthleteManagementApp.Services;
using Microsoft.EntityFrameworkCore;

namespace AthleteManagementApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AthleteManagementSystemDbContext _athleteManagementSystemDbContext;

        public CategoryRepository(AthleteManagementSystemDbContext athleteManagementSystemDbContext)
        {
            this._athleteManagementSystemDbContext = athleteManagementSystemDbContext;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var records = await _athleteManagementSystemDbContext.Categories.ToListAsync();

            return records;
        }

        public async Task<Category> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> AddAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
