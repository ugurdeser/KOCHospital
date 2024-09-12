using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCHospital.Model
{
    [Table("Doctor")]
    public class Doctor
    {

        [Key]
        public int ID { get; set; }
        public int DepartmentId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string DoctorPhone { get; set; }


    }
}
