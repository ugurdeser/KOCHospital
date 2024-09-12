using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCHospital.Model
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime PatientBirthDate { get; set; }
        public string PatientGender { get; set; }
        public string GovernmentId { get; set; }
        public string PatientPhone { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PatientHistory> PatientHistories { get; set; }


    }
}
