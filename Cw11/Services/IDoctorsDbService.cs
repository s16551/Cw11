using Cw11.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Services
{
    public interface IDoctorsDbService
    {
        public IEnumerable<Doctor> GetDoctors();

        public void Add(Doctor doctor);

        public void Delete(int id);

        public IActionResult Details();

    }
}
