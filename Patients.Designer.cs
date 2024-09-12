namespace KOCHospital
{
    partial class Patients
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
            groupBox1 = new GroupBox();
            dtp_BirthDate = new DateTimePicker();
            cbx_Gender = new ComboBox();
            txt_LastName = new TextBox();
            txt_GovermentId = new TextBox();
            txt_Phone = new TextBox();
            txt_FirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_Ad = new Label();
            btn_Delete = new Button();
            btn_Add = new Button();
            dgw_PatientList = new DataGridView();
            dgw_PatienHistoryList = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            txt_Search = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_PatientList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_PatienHistoryList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Controls.Add(dtp_BirthDate);
            groupBox1.Controls.Add(cbx_Gender);
            groupBox1.Controls.Add(txt_LastName);
            groupBox1.Controls.Add(txt_GovermentId);
            groupBox1.Controls.Add(txt_Phone);
            groupBox1.Controls.Add(txt_FirstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_Ad);
            groupBox1.Controls.Add(btn_Delete);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 574);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // dtp_BirthDate
            // 
            dtp_BirthDate.Location = new Point(24, 288);
            dtp_BirthDate.Name = "dtp_BirthDate";
            dtp_BirthDate.Size = new Size(251, 23);
            dtp_BirthDate.TabIndex = 15;
            // 
            // cbx_Gender
            // 
            cbx_Gender.FormattingEnabled = true;
            cbx_Gender.Location = new Point(114, 130);
            cbx_Gender.Name = "cbx_Gender";
            cbx_Gender.Size = new Size(161, 23);
            cbx_Gender.TabIndex = 14;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(114, 89);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(161, 23);
            txt_LastName.TabIndex = 13;
            // 
            // txt_GovermentId
            // 
            txt_GovermentId.Location = new Point(114, 212);
            txt_GovermentId.Name = "txt_GovermentId";
            txt_GovermentId.Size = new Size(161, 23);
            txt_GovermentId.TabIndex = 12;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(114, 171);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(161, 23);
            txt_Phone.TabIndex = 11;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(114, 48);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(161, 23);
            txt_FirstName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 174);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefon No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 215);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "TC Kimlik No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 133);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Cinsiyet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 260);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "DogumTarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 92);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Soyad";
            // 
            // lbl_Ad
            // 
            lbl_Ad.AutoSize = true;
            lbl_Ad.Location = new Point(24, 51);
            lbl_Ad.Name = "lbl_Ad";
            lbl_Ad.Size = new Size(22, 15);
            lbl_Ad.TabIndex = 3;
            lbl_Ad.Text = "Ad";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(157, 525);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(118, 23);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(24, 525);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(118, 23);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Ekle";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgw_PatientList
            // 
            dgw_PatientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_PatientList.BorderStyle = BorderStyle.Fixed3D;
            dgw_PatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_PatientList.Location = new Point(315, 46);
            dgw_PatientList.Name = "dgw_PatientList";
            dgw_PatientList.Size = new Size(872, 241);
            dgw_PatientList.TabIndex = 1;
            dgw_PatientList.Click += dataGridView1_Click;
            // 
            // dgw_PatienHistoryList
            // 
            dgw_PatienHistoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_PatienHistoryList.BorderStyle = BorderStyle.Fixed3D;
            dgw_PatienHistoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_PatienHistoryList.Location = new Point(315, 373);
            dgw_PatienHistoryList.Name = "dgw_PatienHistoryList";
            dgw_PatienHistoryList.Size = new Size(872, 213);
            dgw_PatienHistoryList.TabIndex = 2;
            dgw_PatienHistoryList.Click += dataGridView1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(676, 8);
            label6.Name = "label6";
            label6.Size = new Size(150, 28);
            label6.TabIndex = 14;
            label6.Text = "HASTA LISTESI";
            label6.Click += dataGridView1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(670, 333);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 15;
            label7.Text = "HASTA GECMISI";
            label7.Click += dataGridView1_Click;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(24, 361);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(249, 23);
            txt_Search.TabIndex = 16;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 597);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgw_PatienHistoryList);
            Controls.Add(dgw_PatientList);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Patients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patients";
            WindowState = FormWindowState.Maximized;
            Load += Patients_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_PatientList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_PatienHistoryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Add;
        private Label label1;
        private Label lbl_Ad;
        private Button btn_Delete;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_gender;
        private TextBox txt_GovermentId;
        private TextBox txt_Phone;
        private TextBox textBox2;
        private TextBox txt_FirstName;
        private DataGridView dgw_PatientList;
        private DataGridView dgw_PatienHistoryList;
        private Label label6;
        private Label label7;
        private TextBox txt_LastName;
        private ComboBox cbx_Gender;
        private DateTimePicker dtp_BirthDate;
        private TextBox txt_Search;
    }
}