using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw11.Models;
using Cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorsDbService _context;

        public DoctorController(IDoctorsDbService context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {

            return Ok(_context.GetDoctors());
        }

        [Route("addDoctor")]
        [HttpPost]
        public void Add(Doctor doctor)
        {
            _context.Add(doctor);

        }
        [HttpDelete]
        public void Delete(int id)
        {
            _context.Delete(id);
        }
        [HttpPut]
        public void Edit(int id)
        {
            _context.se
        }



    }
}