using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw11.Models
{
    public partial class PrescriptionMedicament
    {
        [Key]
        public int Id { get; set; }
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
        public string Details { get; set; }
        [ForeignKey("IdMedicament")]
        public virtual Medicament IdMedicamentNavigation { get; set; }
        [ForeignKey("IdPrescription")]
        public virtual Prescription IdPrescriptionNavigation { get; set; }
    }
}
