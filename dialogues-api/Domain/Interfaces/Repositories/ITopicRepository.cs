using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ITopicRepository
    {
        Task<Topic> GetAsync(int id);
        Task<IEnumerable<Topic>> GetAllAsync(int categoryId);
        Task CreateAsync(Topic entity);
        Task DeleteAsync(int id);
    }
}
