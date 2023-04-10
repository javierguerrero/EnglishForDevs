using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        public readonly ApplicationContext _context;

        public TopicRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Topic entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Topic>> GetAllAsync(int categoryId)
        {
            var results = await _context.Topics
                            .Where(t => t.CategoryId == categoryId)
                            .ToListAsync();
            return results;
        }

        public Task<Topic> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}