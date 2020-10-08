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
using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.EntityFrameworkCore;
using AutoMapper.AspNet.OData;
using System;

namespace EfCoreAutomapperOdata.Server.Controllers
{
    public class CourseController : ODataController
    {
        protected readonly BlazorContext _context;
        protected readonly IMapper _mapper;

        public CourseController(BlazorContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ODataRoute("Courses")]
        public async Task<IActionResult> Get(ODataQueryOptions<CourseDto> options)
        {
            return Ok(await _context.Course.GetAsync(_mapper, options));
        }

        [HttpGet]
        [ODataRoute("Courses({id})")]
        public async Task<IActionResult> Get([FromODataUri] int id, ODataQueryOptions<CourseDto> options)
        {
            return Ok((await _context.Course.GetAsync(_mapper, options)).Where(s => s.Id == id).ToList());
        }
    }
}
