namespace KOCHospital
{
    partial class Appointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbx_Hours = new ComboBox();
            cbx_Doctor = new ComboBox();
            dtp_Appointment = new DateTimePicker();
            groupBox1 = new GroupBox();
            cbx_Department = new ComboBox();
            dgw_Appointment = new DataGridView();
            btn_AppointmentAdd = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            dgw_PatientSelecter = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Appointment).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_PatientSelecter).BeginInit();
            SuspendLayout();
            // 
            // cbx_Hours
            // 
            cbx_Hours.FormattingEnabled = true;
            cbx_Hours.Location = new Point(585, 54);
            cbx_Hours.Name = "cbx_Hours";
            cbx_Hours.Size = new Size(167, 23);
            cbx_Hours.TabIndex = 0;
            // 
            // cbx_Doctor
            // 
            cbx_Doctor.FormattingEnabled = true;
            cbx_Doctor.Location = new Point(239, 54);
            cbx_Doctor.Name = "cbx_Doctor";
            cbx_Doctor.Size = new Size(167, 23);
            cbx_Doctor.TabIndex = 1;
            // 
            // dtp_Appointment
            // 
            dtp_Appointment.Location = new Point(412, 54);
            dtp_Appointment.Name = "dtp_Appointment";
            dtp_Appointment.Size = new Size(167, 23);
            dtp_Appointment.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_AppointmentAdd);
            groupBox1.Controls.Add(cbx_Department);
            groupBox1.Controls.Add(dtp_Appointment);
            groupBox1.Controls.Add(cbx_Hours);
            groupBox1.Controls.Add(cbx_Doctor);
            groupBox1.Location = new Point(12, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(862, 112);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randevu Al";
            // 
            // cbx_Department
            // 
            cbx_Department.FormattingEnabled = true;
            cbx_Department.Location = new Point(66, 54);
            cbx_Department.Name = "cbx_Department";
            cbx_Department.Size = new Size(167, 23);
            cbx_Department.TabIndex = 4;
            // 
            // dgw_Appointment
            // 
            dgw_Appointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Appointment.Location = new Point(12, 273);
            dgw_Appointment.Name = "dgw_Appointment";
            dgw_Appointment.Size = new Size(862, 409);
            dgw_Appointment.TabIndex = 5;
            // 
            // btn_AppointmentAdd
            // 
            btn_AppointmentAdd.Location = new Point(377, 83);
            btn_AppointmentAdd.Name = "btn_AppointmentAdd";
            btn_AppointmentAdd.Size = new Size(75, 23);
            btn_AppointmentAdd.TabIndex = 5;
            btn_AppointmentAdd.Text = "Randevu Al";
            btn_AppointmentAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(862, 137);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasta Getir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Departman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 36);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(668, 36);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "Saat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 36);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 19);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 0;
            label5.Text = "Hasta TC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 19);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 2;
            label6.Text = "Hasta Ad";
            // 
            // dgw_PatientSelecter
            // 
            dgw_PatientSelecter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_PatientSelecter.Location = new Point(18, 78);
            dgw_PatientSelecter.Name = "dgw_PatientSelecter";
            dgw_PatientSelecter.Size = new Size(850, 65);
            dgw_PatientSelecter.TabIndex = 7;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 694);
            Controls.Add(dgw_PatientSelecter);
            Controls.Add(groupBox2);
            Controls.Add(dgw_Appointment);
            Controls.Add(groupBox1);
            Name = "Appointments";
            Text = "Appointment";
            Load += Appointment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Appointment).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_PatientSelecter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbx_Hours;
        private ComboBox cbx_Doctor;
        private DateTimePicker dtp_Appointment;
        private GroupBox groupBox1;
        private DataGridView dgw_Appointment;
        private ComboBox cbx_Department;
        private Button btn_AppointmentAdd;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private DataGridView dgw_PatientSelecter;
    }
}