using MyApp.DTOs;

namespace MyApp.Services
{
    public class ExampleService
    {
        private readonly List<ExampleDto> _exampleDtoList = new();

        public ExampleDto CreateExampleDtoByName(string name)
        {
            var exampleDto = new ExampleDto
            {
                Name = name,
                Number = new Random().Next(10)
            };

            _exampleDtoList.Add(exampleDto);
            return exampleDto;
        }

        public ExampleDto CreateExampleDto(ExampleDto exampleDto)
        {
            _exampleDtoList.Add(exampleDto);
            return exampleDto;
        }

        public List<ExampleDto> GetExampleDtoList()
        {
            return _exampleDtoList;
        }
    }
}