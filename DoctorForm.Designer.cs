namespace PatientManagementSystem
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            label1 = new Label();
            label2 = new Label();
            txtDocName = new TextBox();
            label3 = new Label();
            txtSpecial = new TextBox();
            label4 = new Label();
            txtDocPhone = new TextBox();
            btnAddDoctor = new Button();
            btnClear = new Button();
            label5 = new Label();
            dgvDoctors = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 30);
            label1.Name = "label1";
            label1.Size = new Size(279, 39);
            label1.TabIndex = 0;
            label1.Text = "Add New Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 99);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            // 
            // txtDocName
            // 
            txtDocName.Location = new Point(240, 97);
            txtDocName.Name = "txtDocName";
            txtDocName.Size = new Size(421, 27);
            txtDocName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 153);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 3;
            label3.Text = "Specialization : ";
            // 
            // txtSpecial
            // 
            txtSpecial.Location = new Point(240, 151);
            txtSpecial.Name = "txtSpecial";
            txtSpecial.Size = new Size(254, 27);
            txtSpecial.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 201);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 5;
            label4.Text = "Phone : ";
            // 
            // txtDocPhone
            // 
            txtDocPhone.Location = new Point(240, 202);
            txtDocPhone.Name = "txtDocPhone";
            txtDocPhone.Size = new Size(254, 27);
            txtDocPhone.TabIndex = 6;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.BackColor = SystemColors.HotTrack;
            btnAddDoctor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDoctor.ForeColor = SystemColors.HighlightText;
            btnAddDoctor.Location = new Point(181, 252);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(148, 50);
            btnAddDoctor.TabIndex = 7;
            btnAddDoctor.Text = "Add Doctor";
            btnAddDoctor.UseVisualStyleBackColor = false;
            btnAddDoctor.Click += btnAddDoctor_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(385, 252);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 50);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(240, 315);
            label5.Name = "label5";
            label5.Size = new Size(253, 39);
            label5.TabIndex = 9;
            label5.Text = "Doctor Records";
            // 
            // dgvDoctors
            // 
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(67, 373);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.Size = new Size(628, 223);
            dgvDoctors.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(551, 30);
            button1.Name = "button1";
            button1.Size = new Size(144, 46);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(758, 608);
            Controls.Add(button1);
            Controls.Add(dgvDoctors);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnAddDoctor);
            Controls.Add(txtDocPhone);
            Controls.Add(label4);
            Controls.Add(txtSpecial);
            Controls.Add(label3);
            Controls.Add(txtDocName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDocName;
        private Label label3;
        private TextBox txtSpecial;
        private Label label4;
        private TextBox txtDocPhone;
        private Button btnAddDoctor;
        private Button btnClear;
        private Label label5;
        private DataGridView dgvDoctors;
        private Button button1;
    }
}