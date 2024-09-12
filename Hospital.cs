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
    public partial class Hospital : Form
    {

        HospitalContext dbcontext = new HospitalContext();

        public Hospital()
        {
            InitializeComponent();

            dgw_Department.DataSource = dbcontext.Departments.ToList();
            Department_Refresh();
            Doctor_Refresh();
            ComboBox_Refresh();
        }



        private void btn_Department_Add_Click(object sender, EventArgs e)
        {
            Department department = new Department();


            department.DepartmentName = txt_DepartmentName.Text;
            department.DepartmentDescription = txt_DepartmentDescription.Text;

            dbcontext.Departments.Add(department);

            dbcontext.SaveChanges();

            dgw_Department.DataSource = null;
            dgw_Department.DataSource = dbcontext.Departments.ToList();
            ComboBox_Refresh();

        }

        private void btn_Department_Update_Click(object sender, EventArgs e)
        {
            int selectedDepartmentId = 0;

            try
            {
                selectedDepartmentId = Convert.ToInt32(dgw_Department.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz departmanı seçiniz.");
                return;
            }

            Department department = dbcontext.Departments.Where(d => d.ID == selectedDepartmentId).FirstOrDefault();

            department.DepartmentName = txt_DepartmentName.Text;

            department.DepartmentDescription = txt_DepartmentDescription.Text;

            dbcontext.SaveChanges();
            dgw_Department.DataSource = null;
            dgw_Department.DataSource = dbcontext.Departments.ToList();
            ComboBox_Refresh();
        }


        private void dgw_Department_Click(object sender, EventArgs e)
        {
            string selectedDepartmentName = "";
            string SelectedDepartmentDescription = "";

            try
            {
                selectedDepartmentName = dgw_Department.CurrentRow.Cells[1].Value.ToString();
                SelectedDepartmentDescription = dgw_Department.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }

            txt_DepartmentName.Text = selectedDepartmentName;
            txt_DepartmentDescription.Text = SelectedDepartmentDescription;
            ComboBox_Refresh();
        }

        private void btn_Department_Delete_Click(object sender, EventArgs e)
        {
            int selectedDepartmentId = 0;
            try
            {
                selectedDepartmentId = Convert.ToInt32(dgw_Department.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen silmek istediğiniz departmanı seçiniz.");
                return;
            }
            Department department = dbcontext.Departments.Where(d => d.ID == selectedDepartmentId).FirstOrDefault();
            dbcontext.Departments.Remove(department);
            dbcontext.SaveChanges();
            dgw_Department.DataSource = null;
            dgw_Department.DataSource = dbcontext.Departments.ToList();
            ComboBox_Refresh();
        }

        private void ComboBox_Refresh()
        {
            DataTable dtDepartment = new DataTable();

            dtDepartment.Columns.Add("Id", typeof(int));
            dtDepartment.Columns.Add("Depatman Adi", typeof(string));

            dtDepartment.Rows.Add(0, "Lütfen Departman Seçiniz");

            foreach (var item in dbcontext.Departments)
            {
                dtDepartment.Rows.Add(item.ID, item.DepartmentName);
            }

            cbx_DepartmentList.ValueMember = "Id";
            cbx_DepartmentList.DisplayMember = "Depatman Adi";

            cbx_DepartmentList.DataSource = dtDepartment;
        }

        private void btn_Doctor_Add_Click(object sender, EventArgs e)
        {
            int selectedDepartmentId = 0;

            try
            {
                selectedDepartmentId = Convert.ToInt32(cbx_DepartmentList.SelectedValue);
                if (selectedDepartmentId == 0)
                {
                    MessageBox.Show("Departman Seciniz!");
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }


            Doctor doctor = new Doctor();

            try
            {
                doctor.DepartmentId = selectedDepartmentId;
                doctor.DoctorName = txt_DoctorName.Text;
                doctor.DoctorSurname = txt_DoctorSurname.Text;
                doctor.DoctorPhone = txt_DoctorPhone.Text;
                Convert.ToInt64(txt_DoctorPhone.Text);

                if (txt_DoctorName.Text == "")
                {
                    MessageBox.Show("Lutfen en fazla 50 karakterden olusan bir Ad giriniz");
                    return;
                }
                if (txt_DoctorSurname.Text == "")
                {
                    MessageBox.Show("Lutfen en fazla 50 karakterden olusan bir Soyad giriniz");
                    return;
                }

                if (txt_DoctorPhone.Text == "")
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir telefon numarasi giriniz");
                    return;
                }
                else if (txt_DoctorPhone.Text.Length > 11)
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir telefon numarasi giriniz");
                    return;
                }
                else if (txt_DoctorPhone.Text.Length < 11)
                {
                    MessageBox.Show("Lutfen en fazla 11 karakterden olusan bir telefon numarasi giriniz");
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lutfen eksik bilgileri giriniz");
                return;
            }

            dbcontext.Doctors.Add(doctor);
            dbcontext.SaveChanges();

            Doctor_Refresh();



        }

        private void btn_Doctor_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Doctor_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Refresh()
        {

            var Departments = dbcontext.Departments.ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Departman Adı");
            dt.Columns.Add("Doktor Adı");
            dt.Columns.Add("Doktor Soyadı");
            dt.Columns.Add("Doktor Telefon");


            DataRow dr = dt.NewRow();

            foreach (var item in dbcontext.Doctors)
            {
                dr = dt.NewRow();
                dr["Id"] = item.ID;
                dr["Departman Adı"] = Departments.Where(d => d.ID == item.DepartmentId).FirstOrDefault().DepartmentName;
                dr["Doktor Adı"] = item.DoctorName;
                dr["Doktor Soyadı"] = item.DoctorSurname;
                dr["Doktor Telefon"] = item.DoctorPhone;
                dt.Rows.Add(dr);

            }


            dgw_Doctors.DataSource = dt;
        }

        private void Department_Refresh()
        {
            
            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Departman Adı");
            dt.Columns.Add("Departman Açıklaması");

            DataRow dr = dt.NewRow();

            foreach (var item in dbcontext.Departments)
            {
                dr = dt.NewRow();
                dr["Id"] = item.ID;
                dr["Departman Adı"] = item.DepartmentName;
                dr["Departman Açıklaması"] = item.DepartmentDescription;
                dt.Rows.Add(dr);

            }
            dgw_Department.DataSource = dt;

        }
    }
}
