using Microsoft.AspNetCore.Mvc;
using MyApp.DTOs;
using MyApp.Services;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("api/example")]
    public class ExampleDtoController : ControllerBase
    {
        private readonly ExampleServiceWithDb _exampleService;

        public ExampleDtoController(ExampleServiceWithDb exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpPost("create")]
        public ActionResult<ExampleDto> Create([FromBody] ExampleDto exampleDto)
        {
            return _exampleService.CreateExampleDto(exampleDto);
        }

        [HttpGet("name/{name}")]
        public ActionResult<ExampleDto> Get(string name)
        {
            return _exampleService.CreateExampleDtoByName(name);
        }

        [HttpGet("list")]
        public ActionResult<List<ExampleDto>> List()
        {
            return _exampleService.GetExampleDtoList();
        }
    }
}