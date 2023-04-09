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
    public class GetTopicsService : IGetTopicsService
    {
        private readonly ITopicRepository _repository;

        public GetTopicsService(ITopicRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Topic>> GetTopics(int categoryId)
        {
            return await _repository.GetAllAsync(categoryId);
        }
    }
}
