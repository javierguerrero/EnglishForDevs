using Application.DTOs;
using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly IGetTopicsService _getTopicsService;
        private readonly IMapperService _mapperService;

        public TopicsController(
            ILogger<CategoriesController> logger,
            IGetTopicsService getTopicsService,
            IMapperService mapperService)
        {
            _logger = logger;
            _getTopicsService = getTopicsService;
            _mapperService = mapperService;
        }

        //[HttpGet("{topicId}")]
        //public ActionResult<Object> GetTopic(int topicId)
        //{
        //    return null;
        //}

        //[HttpGet("{categoryId}")]
        //public async Task<IActionResult> GetTopics(int categoryId)
        //{
        //    var entities = await _getTopicsService.GetTopics(categoryId);
        //    var results = new List<TopicDto>();

        //    foreach (var entity in entities)
        //    {
        //        results.Add(_mapperService.ConvertToDto(entity));
        //    }

        //    return Ok(results);
        //}

        //[HttpPost]
        //public ActionResult<Object> AddTopic([FromBody] Object topicDto)
        //{
        //    return null;
        //}

        //[HttpPut("{categoryId}")]
        //public ActionResult<Object> UpdateTopic(int topicId, Object topicDto)
        //{
        //    return null;
        //}

        //[HttpDelete("{categoryId}")]
        //public ActionResult<Object> DeleteTopic(int topicId)
        //{
        //    return null;
        //}
    }
}