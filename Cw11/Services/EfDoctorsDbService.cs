using Cw11.Controllers;
using Cw11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Services
{
    public class EfDoctorsDbService : IDoctorsDbService
    {
        private readonly SampleDbContext _context;
        public EfDoctorsDbService(SampleDbContext context)
        {
            _context = context;
        }

        public void Add(Doctor doctor)
        {
            _context.Add(doctor);
        }

        public void Delete(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public IActionResult Details()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList();
        }
    }
}
