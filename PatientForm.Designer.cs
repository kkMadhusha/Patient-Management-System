namespace PatientManagementSystem
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            cmbGender = new ComboBox();
            label4 = new Label();
            dtpDOB = new DateTimePicker();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            btnAddPatient = new Button();
            label7 = new Label();
            dgvPatients = new DataGridView();
            btnClear = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 29);
            label1.Name = "label1";
            label1.Size = new Size(286, 39);
            label1.TabIndex = 0;
            label1.Text = "Add New Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(223, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(421, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 137);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 3;
            label3.Text = "Gender : ";
            label3.UseMnemonic = false;
            label3.Click += label3_Click;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(223, 138);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(272, 28);
            cmbGender.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 184);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 5;
            label4.Text = "Date of Birth : ";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(223, 184);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(272, 27);
            dtpDOB.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 233);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 7;
            label5.Text = "Phone : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(223, 231);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(272, 27);
            txtPhone.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(94, 279);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 9;
            label6.Text = "Address : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(223, 280);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(272, 85);
            txtAddress.TabIndex = 10;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = SystemColors.HotTrack;
            btnAddPatient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPatient.ForeColor = SystemColors.HighlightText;
            btnAddPatient.Location = new Point(532, 320);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(162, 45);
            btnAddPatient.TabIndex = 11;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(236, 379);
            label7.Name = "label7";
            label7.Size = new Size(259, 39);
            label7.TabIndex = 12;
            label7.Text = "Patient Records";
            // 
            // dgvPatients
            // 
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(69, 421);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(600, 212);
            dgvPatients.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(532, 265);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(163, 42);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.HotTrack;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(552, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 46);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(742, 645);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(dgvPatients);
            Controls.Add(label7);
            Controls.Add(btnAddPatient);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(dtpDOB);
            Controls.Add(label4);
            Controls.Add(cmbGender);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Load += PatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private ComboBox cmbGender;
        private Label label4;
        private DateTimePicker dtpDOB;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtAddress;
        private Button btnAddPatient;
        private Label label7;
        private DataGridView dgvPatients;
        private Button btnClear;
        private Button btnBack;
    }
}