namespace PatientManagementSystem
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            label1 = new Label();
            btnLogout = new Button();
            btnPatientManagement = new Button();
            btnDoctorManagement = new Button();
            btnAppointments = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(49, 26);
            label1.Name = "label1";
            label1.Size = new Size(426, 92);
            label1.TabIndex = 0;
            label1.Text = "Hospital Management\r\nSystem\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.HotTrack;
            btnLogout.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.HighlightText;
            btnLogout.Location = new Point(558, 48);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 44);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPatientManagement
            // 
            btnPatientManagement.BackColor = SystemColors.HotTrack;
            btnPatientManagement.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPatientManagement.ForeColor = SystemColors.HighlightText;
            btnPatientManagement.Location = new Point(49, 197);
            btnPatientManagement.Name = "btnPatientManagement";
            btnPatientManagement.Size = new Size(294, 50);
            btnPatientManagement.TabIndex = 2;
            btnPatientManagement.Text = "Patient Management";
            btnPatientManagement.UseVisualStyleBackColor = false;
            btnPatientManagement.Click += btnPatientManagement_Click;
            // 
            // btnDoctorManagement
            // 
            btnDoctorManagement.BackColor = SystemColors.HotTrack;
            btnDoctorManagement.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoctorManagement.ForeColor = SystemColors.HighlightText;
            btnDoctorManagement.Location = new Point(396, 197);
            btnDoctorManagement.Name = "btnDoctorManagement";
            btnDoctorManagement.Size = new Size(317, 50);
            btnDoctorManagement.TabIndex = 3;
            btnDoctorManagement.Text = "Doctor Management";
            btnDoctorManagement.UseVisualStyleBackColor = false;
            btnDoctorManagement.Click += btnDoctorManagement_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = SystemColors.HotTrack;
            btnAppointments.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAppointments.ForeColor = SystemColors.HighlightText;
            btnAppointments.Location = new Point(244, 291);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(241, 53);
            btnAppointments.TabIndex = 4;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(766, 450);
            Controls.Add(btnAppointments);
            Controls.Add(btnDoctorManagement);
            Controls.Add(btnPatientManagement);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnPatientManagement;
        private Button btnDoctorManagement;
        private Button btnAppointments;
    }
}