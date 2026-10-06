namespace PatientManagementSystem
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            label1 = new Label();
            label2 = new Label();
            cmbPatient = new ComboBox();
            label3 = new Label();
            cmbDoctor = new ComboBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            cmbStatus = new ComboBox();
            btnBook = new Button();
            btnClear = new Button();
            dgvAppointments = new DataGridView();
            label6 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 25);
            label1.Name = "label1";
            label1.Size = new Size(311, 39);
            label1.TabIndex = 0;
            label1.Text = "Book Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "Patient : ";
            // 
            // cmbPatient
            // 
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(239, 91);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(416, 28);
            cmbPatient.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 134);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "Doctor : ";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(239, 135);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(416, 28);
            cmbDoctor.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 185);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 5;
            label4.Text = "Date : ";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(239, 185);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(268, 27);
            dtpDate.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 233);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 7;
            label5.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.Location = new Point(239, 233);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(268, 28);
            cmbStatus.TabIndex = 8;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.HotTrack;
            btnBook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = SystemColors.HighlightText;
            btnBook.Location = new Point(155, 287);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(191, 42);
            btnBook.TabIndex = 9;
            btnBook.Text = "Book Appointment";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(394, 287);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(191, 42);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(80, 421);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(619, 185);
            dgvAppointments.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(213, 351);
            label6.Name = "label6";
            label6.Size = new Size(344, 39);
            label6.TabIndex = 12;
            label6.Text = "Appointment Records";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.HotTrack;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(555, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 45);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 618);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(dgvAppointments);
            Controls.Add(btnClear);
            Controls.Add(btnBook);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(cmbDoctor);
            Controls.Add(label3);
            Controls.Add(cmbPatient);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbPatient;
        private Label label3;
        private ComboBox cmbDoctor;
        private Label label4;
        private DateTimePicker dtpDate;
        private Label label5;
        private ComboBox cmbStatus;
        private Button btnBook;
        private Button btnClear;
        private DataGridView dgvAppointments;
        private Label label6;
        private Button btnBack;
    }
}