using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task CreateAsync(Category entity);
        Task DeleteAsync(int id);
    }
}
