using Application.DTOs;
using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DialoguesController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly IMapperService _mapperService;
        private readonly IGenerateDialogueService _generateDialogueService;

        public DialoguesController(
            ILogger<CategoriesController> logger, 
            IMapperService mapperService, 
            IGenerateDialogueService generateDialogueService)
        {
            _logger = logger;
            _mapperService = mapperService;
            _generateDialogueService = generateDialogueService;
        }

        //POST /dialogues/generate
        [HttpPost("generate")]
        public async Task<IActionResult> GenerateDialogue([FromBody] GenerateDialogueDto dto)
        {
            var entity = await _generateDialogueService.GenerateDialogue();
            var output = _mapperService.ConvertToDto(entity);

            return Ok(output);
        }

        //[HttpGet("{dialogueId}")]
        //public ActionResult<Object> GetDialogue(int dialogueId)
        //{
        //    return null;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Object>>> GetDialogues()
        //{
        //    return null;
        //}

        //[HttpPost]
        //public ActionResult<Object> AddDialogue([FromBody] Object dialogueDto)
        //{
        //    return null;
        //}

        //[HttpPut("{dialogueId}")]
        //public ActionResult<Object> UpdateTopic(int dialogueId, Object dialogueDto)
        //{
        //    return null;
        //}

        //[HttpDelete("{dialogueId}")]
        //public ActionResult<Object> DeleteDialogue(int dialogueId)
        //{
        //    return null;
        //}
    }
}