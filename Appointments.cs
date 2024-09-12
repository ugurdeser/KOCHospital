using KOCHospital.Context;
using KOCHospital.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOCHospital
{
    public partial class Appointments : Form
    {
        HospitalContext dbcontext = new HospitalContext();
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            DataTable dtHours = new DataTable();

            dtHours.Columns.Add("Id", typeof(int));
            dtHours.Columns.Add("Hours", typeof(string));

            dtHours.NewRow();
            dtHours.Rows.Add(0, "Lütfen Saat Seçiniz");
            dtHours.Rows.Add(1, "09:00");
            dtHours.Rows.Add(2, "10:00");
            dtHours.Rows.Add(3, "11:00");
            dtHours.Rows.Add(4, "12:00");
            dtHours.Rows.Add(5, "13:00");
            dtHours.Rows.Add(6, "14:00");
            dtHours.Rows.Add(7, "15:00");
            dtHours.Rows.Add(8, "16:00");
            dtHours.Rows.Add(9, "17:00");

            cbx_Hours.ValueMember = "Id";
            cbx_Hours.DisplayMember = "Hours";

            cbx_Hours.DataSource = dtHours;


        }
    }
}
