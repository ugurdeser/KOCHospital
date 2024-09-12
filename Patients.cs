using KOCHospital.Context;
using KOCHospital.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOCHospital
{
    public partial class Patients : Form
    {
        HospitalContext hospitalContext = new HospitalContext();


        public Patients()
        {
            InitializeComponent();

            var appointment = hospitalContext.Appointments.FirstOrDefault(x=>x.ID==4);
            var patient = appointment.Patient.PatientName;

            var appointment1 = hospitalContext.Appointments
                    .Include(a => a.Patient) // Patient verisini de yükler
                    .FirstOrDefault(x => x.ID == 4);

            var patient1 = appointment1.Patient.PatientName;

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Dogum Tarihi");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("T.C. Kimlik No");


            var patientList = from patient in hospitalContext.Patients.ToList()
                              select new
                              {
                                  patient.ID,
                                  patient.PatientName,
                                  patient.PatientLastName,
                                  patient.PatientBirthDate,
                                  patient.PatientGender,
                                  patient.PatientPhone,
                                  patient.GovernmentId
                              };

            DataRow dataRow = dt.NewRow();

            foreach (var item in patientList)
            {
                dataRow = dt.NewRow();
                dataRow["ID"] = item.ID;
                dataRow["Ad"] = item.PatientName;
                dataRow["Soyad"] = item.PatientLastName;
                dataRow["Dogum Tarihi"] = item.PatientBirthDate;
                dataRow["Cinsiyet"] = item.PatientGender;
                dataRow["Telefon"] = item.PatientPhone;
                dataRow["T.C. Kimlik No"] = item.GovernmentId;
                dt.Rows.Add(dataRow);
            }

            dgw_PatientList.DataSource = dt;

            cbx_Gender.Items.Add("Erkek");
            cbx_Gender.Items.Add("Kadın");

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {


            Patient patient = new Patient();

            patient.PatientName = txt_FirstName.Text;
            if (txt_FirstName.Text == "")
            {
                MessageBox.Show("Lutfen en fazla 50 karakterden olusan bir Ad giriniz");
                return;
            }
            patient.PatientLastName = txt_LastName.Text;

            if (txt_LastName.Text == "")
            {
                MessageBox.Show("Lutfen en fazla 50 karakterden olusan bir Soyad giriniz");
                return;
            }
            patient.PatientBirthDate = dtp_BirthDate.Value;

            if (dtp_BirthDate.Value == null)
            {
                MessageBox.Show("Lutfen bir tarih seciniz");
                return;
            }

            patient.PatientGender = cbx_Gender.Text;

            if (cbx_Gender.Text == "")
            {
                MessageBox.Show("Lutfen bir cinsiyet seciniz");
                return;
            }

            try
            {
                Convert.ToInt64(txt_Phone.Text);
                patient.PatientPhone = txt_Phone.Text;

                if (txt_Phone.Text == "")
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir telefon numarasi giriniz");
                    return;
                }
                else if (txt_Phone.Text.Length > 11)
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir telefon numarasi giriniz");
                    return;
                }
                else if (txt_Phone.Text.Length < 11)
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir telefon numarasi giriniz");
                    return;
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Lutfen sadece rakam giriniz");
                return;

            }


            try
            {
                patient.GovernmentId = txt_GovermentId.Text;
                if (txt_GovermentId.Text == "")
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir T.C. kimlik numarasi giriniz");
                    return;
                }
                else if (txt_GovermentId.Text.Length > 11)
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir T.C. kimlik numarasi giriniz");
                    return;
                }
                else if (txt_GovermentId.Text.Length < 11)
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir T.C. kimlik numarasi giriniz");
                    return;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lutfen sadece rakam giriniz");
                return;

            }




            hospitalContext.Patients.Add(patient);

            hospitalContext.SaveChanges();

            Patients_Load(sender, e);


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int deleteID = (int)dgw_PatientList.CurrentRow.Cells[0].Value;

            Patient patient = hospitalContext.Patients.Find(deleteID);

            hospitalContext.Patients.Remove(patient);

            hospitalContext.SaveChanges();

            Patients_Load(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            var selectedID = 0;
            try
            {
                selectedID = Convert.ToInt32(dgw_PatientList.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Olustu!");
            }
            DataTable dt = new DataTable();
            dgw_PatienHistoryList.DataSource = null;

            var patientHistory = hospitalContext.PatientHistories.Where(x => x.PatientId == selectedID).ToList();

            if (patientHistory != null)
            {
                dt.Columns.Add("ID");
                dt.Columns.Add("Tarih");
                dt.Columns.Add("Doktor ID");
                dt.Columns.Add("Doktor Yorumu");
                dt.Columns.Add("Teşhis");



                DataRow dataRow = dt.NewRow();

                foreach (var item in patientHistory)
                {
                    dataRow = dt.NewRow();
                    dataRow["ID"] = item.ID;
                    dataRow["Tarih"] = item.Date;
                    dataRow["Doktor ID"] = item.DoctorId;
                    dataRow["Doktor Yorumu"] = item.DoctorComment;
                    dataRow["Teşhis"] = item.Diagnosis;
                    dt.Rows.Add(dataRow);
                }

                dgw_PatienHistoryList.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Hasta Kayitlarina ulasilamamistir.");
            }

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgw_PatientList.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Dogum Tarihi");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("T.C. Kimlik No");


            var patientList = hospitalContext.Patients.ToList();

            var searchList = from patient in hospitalContext.Patients.ToList()
                             where patient.PatientName.Contains(txt_Search.Text)
                             select patient;

            DataRow dataRow = dt.NewRow();





            dgw_PatientList.DataSource = dt;

            if (txt_Search == null)
            {

                foreach (var item in patientList)
                {
                    dataRow = dt.NewRow();
                    dataRow["ID"] = item.ID;
                    dataRow["Ad"] = item.PatientName;
                    dataRow["Soyad"] = item.PatientLastName;
                    dataRow["Dogum Tarihi"] = item.PatientBirthDate;
                    dataRow["Cinsiyet"] = item.PatientGender;
                    dataRow["Telefon"] = item.PatientPhone;
                    dataRow["T.C. Kimlik No"] = item.GovernmentId;
                    dt.Rows.Add(dataRow);
                }
                dgw_PatientList.DataSource = dt;

            }
            else
            {
                foreach (var item in searchList)
                {
                    dataRow = dt.NewRow();
                    dataRow["ID"] = item.ID;
                    dataRow["Ad"] = item.PatientName;
                    dataRow["Soyad"] = item.PatientLastName;
                    dataRow["Dogum Tarihi"] = item.PatientBirthDate;
                    dataRow["Cinsiyet"] = item.PatientGender;
                    dataRow["Telefon"] = item.PatientPhone;
                    dataRow["T.C. Kimlik No"] = item.GovernmentId;
                    dt.Rows.Add(dataRow);
                }

                dgw_PatientList.DataSource = dt;
            }
        }
    }
}
