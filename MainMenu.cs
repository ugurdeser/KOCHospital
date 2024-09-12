using System;
using System.Configuration;
using System.Configuration.Provider;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KOCHospital
{
    public partial class MainMenu : Form
    {
        private int childFormNumber = 0;
        public MainMenu()
        {
            InitializeComponent();


        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void patientMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Patients>().Count() == 1)
            {
                Application.OpenForms.OfType<Patients>().First().Focus();
            }
            else
            {
                Patients patientForm = new Patients();
                patientForm.StartPosition = FormStartPosition.CenterScreen;
                patientForm.WindowState = FormWindowState.Maximized;
                patientForm.MdiParent = this;
                patientForm.Show();
            }


        }

        private void hospitalMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Hospital>().Count() == 1)
            {
                Application.OpenForms.OfType<Hospital>().First().Focus();
            }
            else
            {
                Hospital hospitalForm = new Hospital();
                hospitalForm.StartPosition = FormStartPosition.CenterScreen;
                hospitalForm.WindowState = FormWindowState.Maximized;
                hospitalForm.MdiParent = this;
                hospitalForm.Show();
            }
        }

        private void appointmentMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Appointments>().Count() == 1)
            {
                Application.OpenForms.OfType<Appointments>().First().Focus();
            }
            else
            {
                Appointments appointmentForm = new Appointments();
                appointmentForm.StartPosition = FormStartPosition.CenterScreen;
                appointmentForm.WindowState = FormWindowState.Maximized;
                appointmentForm.MdiParent = this;
                appointmentForm.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}

