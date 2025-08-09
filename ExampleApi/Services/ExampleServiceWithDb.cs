using MyApp.DTOs;
using MyApp.Data;

namespace MyApp.Services
{
    public class ExampleServiceWithDb
    {
        private readonly AppDbContext _context;

        public ExampleServiceWithDb(AppDbContext context)
        {
            _context = context;
        }

        public ExampleDto CreateExampleDtoByName(string name)
        {
            var exampleDto = new ExampleDto
            {
                Name = name,
                Number = new Random().Next(10)
            };

            _context.Examples.Add(exampleDto);
            _context.SaveChanges();

            return exampleDto;
        }

        public ExampleDto CreateExampleDto(ExampleDto exampleDto)
        {
            _context.Examples.Add(exampleDto);
            _context.SaveChanges();

            return exampleDto;
        }

        public List<ExampleDto> GetExampleDtoList()
        {
            return _context.Examples.ToList();
        }
    }
}