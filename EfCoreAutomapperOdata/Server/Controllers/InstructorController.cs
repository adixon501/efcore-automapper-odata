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
    public class InstructorController : ODataController
    {
        protected readonly BlazorContext _context;
        protected readonly IMapper _mapper;

        public InstructorController(BlazorContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ODataRoute("Instructors")]
        public async Task<IActionResult> Get(ODataQueryOptions<InstructorDto> options)
        {
            return Ok(await _context.Instructor.GetAsync(_mapper, options));
        }

        [HttpGet]
        [ODataRoute("Instructors({id})")]
        public async Task<IActionResult> GetAsync([FromODataUri] int id, ODataQueryOptions<InstructorDto> options)
        {
            return Ok((await _context.Instructor.GetAsync(_mapper, options)).Where(s => s.Id == id).ToList());
        }
    }
}