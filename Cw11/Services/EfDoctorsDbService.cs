using Cw11.Controllers;
using Cw11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            _context.Doctor.Add(doctor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            
            var doctor = _context.Doctor.Find(id);

            if (doctor != null)
            {
                _context.Doctor.Remove(doctor);
                _context.SaveChanges();
            }
        }

        public void Update(Doctor doctor)
        {
            var newDoctor = _context.Doctor.Single(d => d.IdDoctor == doctor.IdDoctor);
            if (newDoctor != null)
            {
                newDoctor.FirstName = doctor.FirstName;
                newDoctor.LastName = doctor.LastName;
                newDoctor.Prescription = doctor.Prescription;
                _context.SaveChanges();
            }

        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList();
        }
    }
}
