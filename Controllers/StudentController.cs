using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace automapper_sample.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public Student Get()
        {
            StudentDTO studentDTO = new StudentDTO()
            {
                Name = "Student 1",
                Age = 25,
                CurrentCity = "Chicago",
                Address = new AddressDTO ()
                {
                    State = "IL",
                    Country = "US"
                }
            };

            return _mapper.Map<Student>(studentDTO);
        }
    }
}
