namespace KOCHospital
{
    partial class Hospital
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
            gb_DoctorAdd = new GroupBox();
            label6 = new Label();
            txt_DoctorPhone = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbx_DepartmentList = new ComboBox();
            txt_DoctorSurname = new TextBox();
            txt_DoctorName = new TextBox();
            btn_Doctor_Delete = new Button();
            btn_Doctor_Update = new Button();
            btn_Doctor_Add = new Button();
            groupBox1 = new GroupBox();
            btn_Department_Delete = new Button();
            btn_Department_Update = new Button();
            btn_Department_Add = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_DepartmentDescription = new TextBox();
            txt_DepartmentName = new TextBox();
            dgw_Department = new DataGridView();
            dgw_Doctors = new DataGridView();
            gb_DoctorAdd.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Department).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Doctors).BeginInit();
            SuspendLayout();
            // 
            // gb_DoctorAdd
            // 
            gb_DoctorAdd.Controls.Add(label6);
            gb_DoctorAdd.Controls.Add(txt_DoctorPhone);
            gb_DoctorAdd.Controls.Add(label5);
            gb_DoctorAdd.Controls.Add(label3);
            gb_DoctorAdd.Controls.Add(label4);
            gb_DoctorAdd.Controls.Add(cbx_DepartmentList);
            gb_DoctorAdd.Controls.Add(txt_DoctorSurname);
            gb_DoctorAdd.Controls.Add(txt_DoctorName);
            gb_DoctorAdd.Controls.Add(btn_Doctor_Delete);
            gb_DoctorAdd.Controls.Add(btn_Doctor_Update);
            gb_DoctorAdd.Controls.Add(btn_Doctor_Add);
            gb_DoctorAdd.Location = new Point(12, 264);
            gb_DoctorAdd.Name = "gb_DoctorAdd";
            gb_DoctorAdd.Size = new Size(308, 310);
            gb_DoctorAdd.TabIndex = 0;
            gb_DoctorAdd.TabStop = false;
            gb_DoctorAdd.Text = "Doktor Ekle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 213);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 16;
            label6.Text = "Doktor Telefon";
            // 
            // txt_DoctorPhone
            // 
            txt_DoctorPhone.Location = new Point(110, 210);
            txt_DoctorPhone.Name = "txt_DoctorPhone";
            txt_DoctorPhone.Size = new Size(170, 23);
            txt_DoctorPhone.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 162);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 14;
            label5.Text = "Doktor Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 111);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Doktor Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 60);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Departman Adı";
            // 
            // cbx_DepartmentList
            // 
            cbx_DepartmentList.FormattingEnabled = true;
            cbx_DepartmentList.Location = new Point(110, 57);
            cbx_DepartmentList.Name = "cbx_DepartmentList";
            cbx_DepartmentList.Size = new Size(170, 23);
            cbx_DepartmentList.TabIndex = 13;
            // 
            // txt_DoctorSurname
            // 
            txt_DoctorSurname.Location = new Point(110, 159);
            txt_DoctorSurname.Name = "txt_DoctorSurname";
            txt_DoctorSurname.Size = new Size(170, 23);
            txt_DoctorSurname.TabIndex = 12;
            // 
            // txt_DoctorName
            // 
            txt_DoctorName.Location = new Point(110, 108);
            txt_DoctorName.Name = "txt_DoctorName";
            txt_DoctorName.Size = new Size(170, 23);
            txt_DoctorName.TabIndex = 10;
            // 
            // btn_Doctor_Delete
            // 
            btn_Doctor_Delete.Location = new Point(205, 267);
            btn_Doctor_Delete.Name = "btn_Doctor_Delete";
            btn_Doctor_Delete.Size = new Size(75, 23);
            btn_Doctor_Delete.TabIndex = 9;
            btn_Doctor_Delete.Text = "Sil";
            btn_Doctor_Delete.UseVisualStyleBackColor = true;
            btn_Doctor_Delete.Click += btn_Doctor_Delete_Click;
            // 
            // btn_Doctor_Update
            // 
            btn_Doctor_Update.Location = new Point(124, 267);
            btn_Doctor_Update.Name = "btn_Doctor_Update";
            btn_Doctor_Update.Size = new Size(75, 23);
            btn_Doctor_Update.TabIndex = 8;
            btn_Doctor_Update.Text = "Güncelle";
            btn_Doctor_Update.UseVisualStyleBackColor = true;
            btn_Doctor_Update.Click += btn_Doctor_Update_Click;
            // 
            // btn_Doctor_Add
            // 
            btn_Doctor_Add.Location = new Point(43, 267);
            btn_Doctor_Add.Name = "btn_Doctor_Add";
            btn_Doctor_Add.Size = new Size(75, 23);
            btn_Doctor_Add.TabIndex = 7;
            btn_Doctor_Add.Text = "Ekle";
            btn_Doctor_Add.UseVisualStyleBackColor = true;
            btn_Doctor_Add.Click += btn_Doctor_Add_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Department_Delete);
            groupBox1.Controls.Add(btn_Department_Update);
            groupBox1.Controls.Add(btn_Department_Add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_DepartmentDescription);
            groupBox1.Controls.Add(txt_DepartmentName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 246);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bölüm Ekle";
            // 
            // btn_Department_Delete
            // 
            btn_Department_Delete.Location = new Point(205, 203);
            btn_Department_Delete.Name = "btn_Department_Delete";
            btn_Department_Delete.Size = new Size(75, 23);
            btn_Department_Delete.TabIndex = 6;
            btn_Department_Delete.Text = "Sil";
            btn_Department_Delete.UseVisualStyleBackColor = true;
            btn_Department_Delete.Click += btn_Department_Delete_Click;
            // 
            // btn_Department_Update
            // 
            btn_Department_Update.Location = new Point(124, 203);
            btn_Department_Update.Name = "btn_Department_Update";
            btn_Department_Update.Size = new Size(75, 23);
            btn_Department_Update.TabIndex = 5;
            btn_Department_Update.Text = "Güncelle";
            btn_Department_Update.UseVisualStyleBackColor = true;
            btn_Department_Update.Click += btn_Department_Update_Click;
            // 
            // btn_Department_Add
            // 
            btn_Department_Add.Location = new Point(43, 203);
            btn_Department_Add.Name = "btn_Department_Add";
            btn_Department_Add.Size = new Size(75, 23);
            btn_Department_Add.TabIndex = 4;
            btn_Department_Add.Text = "Ekle";
            btn_Department_Add.UseVisualStyleBackColor = true;
            btn_Department_Add.Click += btn_Department_Add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 115);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 60);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Departman Adı";
            // 
            // txt_DepartmentDescription
            // 
            txt_DepartmentDescription.Location = new Point(117, 112);
            txt_DepartmentDescription.Name = "txt_DepartmentDescription";
            txt_DepartmentDescription.Size = new Size(170, 23);
            txt_DepartmentDescription.TabIndex = 1;
            // 
            // txt_DepartmentName
            // 
            txt_DepartmentName.Location = new Point(117, 57);
            txt_DepartmentName.Name = "txt_DepartmentName";
            txt_DepartmentName.Size = new Size(170, 23);
            txt_DepartmentName.TabIndex = 0;
            // 
            // dgw_Department
            // 
            dgw_Department.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Department.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Department.Location = new Point(326, 21);
            dgw_Department.Name = "dgw_Department";
            dgw_Department.Size = new Size(447, 553);
            dgw_Department.TabIndex = 2;
            dgw_Department.Click += dgw_Department_Click;
            // 
            // dgw_Doctors
            // 
            dgw_Doctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Doctors.Location = new Point(779, 21);
            dgw_Doctors.Name = "dgw_Doctors";
            dgw_Doctors.Size = new Size(573, 553);
            dgw_Doctors.TabIndex = 3;
            // 
            // Hospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 837);
            Controls.Add(dgw_Doctors);
            Controls.Add(dgw_Department);
            Controls.Add(groupBox1);
            Controls.Add(gb_DoctorAdd);
            Name = "Hospital";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hospital";
            gb_DoctorAdd.ResumeLayout(false);
            gb_DoctorAdd.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Department).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Doctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_DoctorAdd;
        private GroupBox groupBox1;
        private TextBox txt_DepartmentName;
        private DataGridView dgw_Department;
        private DataGridView dgw_Doctors;
        private TextBox txt_DepartmentDescription;
        private Label label1;
        private Label label2;
        private Button btn_Department_Update;
        private Button btn_Department_Add;
        private Button btn_Department_Delete;
        private Button btn_Doctor_Delete;
        private Button btn_Doctor_Update;
        private Button btn_Doctor_Add;
        private TextBox txt_DoctorName;
        private TextBox txt_DoctorSurname;
        private ComboBox cbx_DepartmentList;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_DoctorPhone;
    }
}