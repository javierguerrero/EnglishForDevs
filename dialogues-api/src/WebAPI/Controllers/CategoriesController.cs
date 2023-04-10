using Application.DTOs;
using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly IMapperService _mapperService;
        private readonly IGetAllCategoriesService _getAllCategoriesService;
        private readonly IGetTopicsService _getTopicsService;

        public CategoriesController(
            ILogger<CategoriesController> logger,
            IGetAllCategoriesService getAllCategoriesService,
            IGetTopicsService getTopicsService,
            IMapperService mapperService)
        {
            _logger = logger;
            _getAllCategoriesService = getAllCategoriesService;
            _getTopicsService = getTopicsService;
            _mapperService = mapperService;
        }

        //GET /categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var entities = await _getAllCategoriesService.GetAllCategories();
            
            var output = new List<CategoryDto>();
            foreach (var entity in entities)
            {
                output.Add(_mapperService.ConvertToDto(entity));
            }

            return Ok(output);
        }

        //GET /categories/5/topics
        [HttpGet("{categoryId}/topics")]
        public async Task<IActionResult> GetTopics(int categoryId)
        {
            var entities = await _getTopicsService.GetTopics(categoryId);

            var output = new List<TopicDto>();
            foreach (var entity in entities)
            {
                output.Add(_mapperService.ConvertToDto(entity));
            }

            return Ok(output);
        }


        //[HttpGet("{categoryId}")]
        //public ActionResult<Object> GetCategory(int categoryId)
        //{
        //    return null;
        //}

        //[HttpPost]
        //public ActionResult<Object> AddCategory([FromBody] Object categoryDto)
        //{
        //    return null;
        //}

        //[HttpPut("{categoryId}")]
        //public ActionResult<Object> UpdateCategory(int categoryId, Object categoryDto)
        //{
        //    return null;
        //}

        //[HttpDelete("{categoryId}")]
        //public ActionResult<Object> DeleteCategory(int categoryId)
        //{
        //    return null;
        //}
    }
}