using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCHospital.Model
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

    }
}
