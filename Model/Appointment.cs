using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCHospital.Model
{
    [Table("Appointment")]
    public class Appointment
    {
        [Key]
        public int ID { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public string AppointmentHoursId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentStatus { get; set; }

    }

}
