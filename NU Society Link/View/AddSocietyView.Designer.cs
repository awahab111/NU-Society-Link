﻿namespace NU_Society_Link.View
{
    partial class AddSocietyView
    {
        // ...

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnBrowseLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblSupervisorContact;
        private System.Windows.Forms.TextBox txtSupervisorContact;
        private System.Windows.Forms.Label lblSupervisorEmail;
        private System.Windows.Forms.TextBox txtSupervisorEmail;
        private System.Windows.Forms.Label lblSupervisorDesignation;
        private System.Windows.Forms.TextBox txtSupervisorDesignation;
        private System.Windows.Forms.Label lblSupervisorDepartment;
        private System.Windows.Forms.TextBox txtSupervisorDepartment;
        private System.Windows.Forms.Label lblSupervisorFaculty;
        private System.Windows.Forms.TextBox txtSupervisorFaculty;

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblSupervisor = new Label();
            txtSupervisor = new TextBox();
            lblLogo = new Label();
            btnBrowseLogo = new Button();
            pbLogo = new PictureBox();
            btnSave = new Button();
            lblDescription = new Label();
            lblType = new Label();
            txtType = new TextBox();
            lblSupervisorContact = new Label();
            txtSupervisorContact = new TextBox();
            lblSupervisorEmail = new Label();
            txtSupervisorEmail = new TextBox();
            lblSupervisorDesignation = new Label();
            txtSupervisorDesignation = new TextBox();
            lblSupervisorDepartment = new Label();
            txtSupervisorDepartment = new TextBox();
            lblSupervisorFaculty = new Label();
            txtSupervisorFaculty = new TextBox();
            txtDescription = new RichTextBox();
            flaglbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 24);
            txtName.TabIndex = 1;
            // 
            // lblSupervisor
            // 
            lblSupervisor.AutoSize = true;
            lblSupervisor.Location = new Point(20, 51);
            lblSupervisor.Name = "lblSupervisor";
            lblSupervisor.Size = new Size(68, 17);
            lblSupervisor.TabIndex = 2;
            lblSupervisor.Text = "Supervisor:";
            // 
            // txtSupervisor
            // 
            txtSupervisor.Location = new Point(108, 44);
            txtSupervisor.Name = "txtSupervisor";
            txtSupervisor.Size = new Size(200, 24);
            txtSupervisor.TabIndex = 3;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(20, 81);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(37, 17);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "Logo:";
            // 
            // btnBrowseLogo
            // 
            btnBrowseLogo.BackColor = Color.FromArgb(4, 59, 72);
            btnBrowseLogo.FlatStyle = FlatStyle.Popup;
            btnBrowseLogo.ForeColor = Color.WhiteSmoke;
            btnBrowseLogo.Location = new Point(108, 78);
            btnBrowseLogo.Name = "btnBrowseLogo";
            btnBrowseLogo.Size = new Size(75, 26);
            btnBrowseLogo.TabIndex = 5;
            btnBrowseLogo.Text = "Browse";
            btnBrowseLogo.UseVisualStyleBackColor = false;
            btnBrowseLogo.Click += btnBrowseLogo_Click;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(390, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(169, 145);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(4, 59, 72);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(390, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 26);
            btnSave.TabIndex = 7;
            btnSave.Text = "Done";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(390, 182);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(72, 17);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 118);
            lblType.Name = "lblType";
            lblType.Size = new Size(36, 17);
            lblType.TabIndex = 10;
            lblType.Text = "Type:";
            // 
            // txtType
            // 
            txtType.Location = new Point(108, 111);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 24);
            txtType.TabIndex = 11;
            // 
            // lblSupervisorContact
            // 
            lblSupervisorContact.AutoSize = true;
            lblSupervisorContact.Location = new Point(7, 164);
            lblSupervisorContact.Name = "lblSupervisorContact";
            lblSupervisorContact.Size = new Size(113, 17);
            lblSupervisorContact.TabIndex = 14;
            lblSupervisorContact.Text = "Supervisor Contact:";
            // 
            // txtSupervisorContact
            // 
            txtSupervisorContact.Location = new Point(180, 157);
            txtSupervisorContact.Name = "txtSupervisorContact";
            txtSupervisorContact.Size = new Size(171, 24);
            txtSupervisorContact.TabIndex = 15;
            // 
            // lblSupervisorEmail
            // 
            lblSupervisorEmail.AutoSize = true;
            lblSupervisorEmail.Location = new Point(7, 193);
            lblSupervisorEmail.Name = "lblSupervisorEmail";
            lblSupervisorEmail.Size = new Size(103, 17);
            lblSupervisorEmail.TabIndex = 16;
            lblSupervisorEmail.Text = "Supervisor Email:";
            // 
            // txtSupervisorEmail
            // 
            txtSupervisorEmail.Location = new Point(180, 186);
            txtSupervisorEmail.Name = "txtSupervisorEmail";
            txtSupervisorEmail.Size = new Size(171, 24);
            txtSupervisorEmail.TabIndex = 17;
            // 
            // lblSupervisorDesignation
            // 
            lblSupervisorDesignation.AutoSize = true;
            lblSupervisorDesignation.Location = new Point(7, 221);
            lblSupervisorDesignation.Name = "lblSupervisorDesignation";
            lblSupervisorDesignation.Size = new Size(136, 17);
            lblSupervisorDesignation.TabIndex = 18;
            lblSupervisorDesignation.Text = "Supervisor Designation:";
            // 
            // txtSupervisorDesignation
            // 
            txtSupervisorDesignation.Location = new Point(180, 214);
            txtSupervisorDesignation.Name = "txtSupervisorDesignation";
            txtSupervisorDesignation.Size = new Size(171, 24);
            txtSupervisorDesignation.TabIndex = 19;
            // 
            // lblSupervisorDepartment
            // 
            lblSupervisorDepartment.AutoSize = true;
            lblSupervisorDepartment.Location = new Point(6, 250);
            lblSupervisorDepartment.Name = "lblSupervisorDepartment";
            lblSupervisorDepartment.Size = new Size(136, 17);
            lblSupervisorDepartment.TabIndex = 20;
            lblSupervisorDepartment.Text = "Supervisor Department:";
            // 
            // txtSupervisorDepartment
            // 
            txtSupervisorDepartment.Location = new Point(180, 243);
            txtSupervisorDepartment.Name = "txtSupervisorDepartment";
            txtSupervisorDepartment.Size = new Size(171, 24);
            txtSupervisorDepartment.TabIndex = 21;
            // 
            // lblSupervisorFaculty
            // 
            lblSupervisorFaculty.AutoSize = true;
            lblSupervisorFaculty.Location = new Point(7, 281);
            lblSupervisorFaculty.Name = "lblSupervisorFaculty";
            lblSupervisorFaculty.Size = new Size(111, 17);
            lblSupervisorFaculty.TabIndex = 22;
            lblSupervisorFaculty.Text = "Supervisor Faculty:";
            // 
            // txtSupervisorFaculty
            // 
            txtSupervisorFaculty.Location = new Point(180, 274);
            txtSupervisorFaculty.Name = "txtSupervisorFaculty";
            txtSupervisorFaculty.Size = new Size(171, 24);
            txtSupervisorFaculty.TabIndex = 23;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(390, 206);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(169, 96);
            txtDescription.TabIndex = 24;
            txtDescription.Text = "";
            // 
            // flaglbl
            // 
            flaglbl.AutoSize = true;
            flaglbl.BackColor = Color.White;
            flaglbl.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            flaglbl.ForeColor = Color.OrangeRed;
            flaglbl.Location = new Point(243, 353);
            flaglbl.Name = "flaglbl";
            flaglbl.Size = new Size(0, 17);
            flaglbl.TabIndex = 25;
            // 
            // AddSocietyView
            // 
            AutoSize = true;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(575, 403);
            Controls.Add(flaglbl);
            Controls.Add(txtDescription);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblSupervisor);
            Controls.Add(txtSupervisor);
            Controls.Add(lblLogo);
            Controls.Add(btnBrowseLogo);
            Controls.Add(pbLogo);
            Controls.Add(btnSave);
            Controls.Add(lblDescription);
            Controls.Add(lblType);
            Controls.Add(txtType);
            Controls.Add(lblSupervisorContact);
            Controls.Add(txtSupervisorContact);
            Controls.Add(lblSupervisorEmail);
            Controls.Add(txtSupervisorEmail);
            Controls.Add(lblSupervisorDesignation);
            Controls.Add(txtSupervisorDesignation);
            Controls.Add(lblSupervisorDepartment);
            Controls.Add(txtSupervisorDepartment);
            Controls.Add(lblSupervisorFaculty);
            Controls.Add(txtSupervisorFaculty);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            ForeColor = Color.WhiteSmoke;
            Name = "AddSocietyView";
            Text = "Add Society";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Event handler for btnBrowseLogo button click
        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private RichTextBox txtDescription;
        private Label flaglbl;

        // ...
    }
}