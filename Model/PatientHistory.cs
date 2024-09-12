using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCHospital.Model
{
    [Table("PatientHistory")]
    public class PatientHistory
    {
        [Key]
        public int ID { get; set; }
        public int PatientId { get; set; }
        public string DoctorId { get; set; }
        public string DoctorComment { get; set; }
        public string Diagnosis { get; set; }
        public DateTime Date { get; set; }

    }
}