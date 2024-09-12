namespace KOCHospital
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            patientMenuToolStripMenuItem = new ToolStripMenuItem();
            hospitalMenuToolStripMenuItem = new ToolStripMenuItem();
            appointmentMenuToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { patientMenuToolStripMenuItem, hospitalMenuToolStripMenuItem, appointmentMenuToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1364, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // patientMenuToolStripMenuItem
            // 
            patientMenuToolStripMenuItem.Name = "patientMenuToolStripMenuItem";
            patientMenuToolStripMenuItem.Size = new Size(90, 20);
            patientMenuToolStripMenuItem.Text = "Patient Menu";
            patientMenuToolStripMenuItem.Click += patientMenuToolStripMenuItem_Click;
            // 
            // hospitalMenuToolStripMenuItem
            // 
            hospitalMenuToolStripMenuItem.Name = "hospitalMenuToolStripMenuItem";
            hospitalMenuToolStripMenuItem.Size = new Size(97, 20);
            hospitalMenuToolStripMenuItem.Text = "Hospital Menu";
            hospitalMenuToolStripMenuItem.Click += hospitalMenuToolStripMenuItem_Click;
            // 
            // appointmentMenuToolStripMenuItem
            // 
            appointmentMenuToolStripMenuItem.Name = "appointmentMenuToolStripMenuItem";
            appointmentMenuToolStripMenuItem.Size = new Size(124, 20);
            appointmentMenuToolStripMenuItem.Text = "Appointment Menu";
            appointmentMenuToolStripMenuItem.Click += appointmentMenuToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 815);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1364, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 837);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Koc Hospital Patient Tracking System";
            Load += MainMenu_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem hospitalMenuToolStripMenuItem;
        private ToolStripMenuItem patientMenuToolStripMenuItem;
        private ToolStripMenuItem appointmentMenuToolStripMenuItem;
    }
}



