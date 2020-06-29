using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly SampleDbContext _context;

        public DoctorController(SampleDbContext context)
        {
            _context = context;
        }

        public IActionResult GetDoctors()
        {

            return Ok(_context.Doctor.ToList());
        }
    }
}