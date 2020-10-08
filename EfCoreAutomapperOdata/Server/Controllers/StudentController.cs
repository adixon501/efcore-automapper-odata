using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using EfCoreAutomapperOdata.Server.Data;
using Microsoft.AspNet.OData.Routing;
using AutoMapper;
using Microsoft.AspNet.OData.Query;
using EfCoreAutomapperOdata.Shared.Models;
using EfCoreAutomapperOdata.Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper.AspNet.OData;

namespace EfCoreAutomapperOdata.Server.Controllers
{
    public class StudentController : ODataController
    {
        protected readonly BlazorContext _context;
        protected readonly IMapper _mapper;

        public StudentController(BlazorContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ODataRoute("Students")]
        public async Task<IActionResult> Get(ODataQueryOptions<StudentDto> options)
        {
            return Ok((await _context.Student.GetAsync(_mapper, options)).ToList());
        }

        [HttpGet]
        [ODataRoute("Students({id})")]
        public async Task<IActionResult> Get([FromODataUri] int id, ODataQueryOptions<StudentDto> options)
        {
            return Ok((await _context.Student.GetAsync(_mapper, options)).Single(s => s.Id == id));
        }
    }
}
