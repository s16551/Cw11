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

        public void Delete(int id)
        {

            var doctor = _context.Doctor.ToList().Find(x => x.IdDoctor == id);
            _context.Doctor.ToList().Remove(doctor);
        }

        public void Put(int id, Doctor doctor)
        {
            var doctorToUpdate = _context.Doctor.ToList().Find(x => x.IdDoctor == id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList();
        }
    }
}
