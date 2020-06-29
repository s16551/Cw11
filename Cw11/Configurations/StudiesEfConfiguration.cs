using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Configurations
{
    public class DoctorsEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            var dictDoctors = new List<Doctor>();

            dictDoctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Roman",
                LastName = "Kowalski",
                Email = "r.kowalski@gmail.com",
                Prescription = null
            });

            dictDoctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Pawel",
                LastName = "Kowalski",
                Email = "p.kowalski@gmail.com",
                Prescription = null
            });

        }
    }
}
