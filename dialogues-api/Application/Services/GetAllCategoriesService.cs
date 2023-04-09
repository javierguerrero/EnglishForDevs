using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GetAllCategoriesService : IGetAllCategoriesService
    {
        private readonly ICategoryRepository _repository;

        public GetAllCategoriesService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _repository.GetAllAsync();
        }
    }
}
