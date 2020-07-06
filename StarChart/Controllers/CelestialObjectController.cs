using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StarChart.Data;

namespace StarChart.Controllers
{
    [ApiController]
    [Route("")]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id:int}")]

        public IActionResult GetById(int id)
        {
            return NotFound();
        }
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            return NotFound();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("CelestialObjects");
        }
    }
}
