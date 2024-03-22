namespace NU_Society_Link.View
{
    partial class SocietyInformationView
    {
        // Add label controls to display the society information
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSupervisorContact;
        private System.Windows.Forms.Label lblSupervisorEmail;
        private System.Windows.Forms.Label lblSupervisorDepartment;

        // Add read-only text boxes
        private System.Windows.Forms.TextBox showName;
        private System.Windows.Forms.TextBox showSupervisor;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSupervisorContact;
        private System.Windows.Forms.TextBox txtSupervisorEmail;
        private System.Windows.Forms.TextBox txtSupervisorDepartment;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button approveSocietyBtn;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDescription = new Label();
            lblType = new Label();
            lblSupervisorContact = new Label();
            lblSupervisorEmail = new Label();
            lblSupervisorDepartment = new Label();
            showName = new TextBox();
            showSupervisor = new TextBox();
            pbLogo = new PictureBox();
            txtType = new TextBox();
            txtSupervisorContact = new TextBox();
            txtSupervisorEmail = new TextBox();
            txtSupervisorDepartment = new TextBox();
            approveSocietyBtn = new Button();
            showDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Society Name";
            // 
            // label2
            // 
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Location = new Point(10, 70);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 2;
            label3.Text = "Supervisor Name";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(10, 122);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Logo";
            // 
            // lblType
            // 
            lblType.Location = new Point(10, 220);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            // 
            // lblSupervisorContact
            // 
            lblSupervisorContact.Location = new Point(10, 250);
            lblSupervisorContact.Name = "lblSupervisorContact";
            lblSupervisorContact.Size = new Size(134, 23);
            lblSupervisorContact.TabIndex = 8;
            lblSupervisorContact.Text = "Supervisor Contact";
            // 
            // lblSupervisorEmail
            // 
            lblSupervisorEmail.Location = new Point(10, 280);
            lblSupervisorEmail.Name = "lblSupervisorEmail";
            lblSupervisorEmail.Size = new Size(100, 23);
            lblSupervisorEmail.TabIndex = 9;
            lblSupervisorEmail.Text = "Supervisor Email";
            // 
            // lblSupervisorDepartment
            // 
            lblSupervisorDepartment.Location = new Point(10, 340);
            lblSupervisorDepartment.Name = "lblSupervisorDepartment";
            lblSupervisorDepartment.Size = new Size(134, 23);
            lblSupervisorDepartment.TabIndex = 11;
            lblSupervisorDepartment.Text = "Supervisor Department";
            // 
            // showName
            // 
            showName.Location = new Point(150, 10);
            showName.Name = "showName";
            showName.ReadOnly = true;
            showName.Size = new Size(100, 23);
            showName.TabIndex = 13;
            // 
            // showSupervisor
            // 
            showSupervisor.Location = new Point(150, 70);
            showSupervisor.Name = "showSupervisor";
            showSupervisor.ReadOnly = true;
            showSupervisor.Size = new Size(100, 23);
            showSupervisor.TabIndex = 15;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(150, 109);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 92);
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // txtType
            // 
            txtType.Location = new Point(150, 220);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 21;
            // 
            // txtSupervisorContact
            // 
            txtSupervisorContact.Location = new Point(150, 250);
            txtSupervisorContact.Name = "txtSupervisorContact";
            txtSupervisorContact.Size = new Size(100, 23);
            txtSupervisorContact.TabIndex = 22;
            // 
            // txtSupervisorEmail
            // 
            txtSupervisorEmail.Location = new Point(150, 280);
            txtSupervisorEmail.Name = "txtSupervisorEmail";
            txtSupervisorEmail.Size = new Size(100, 23);
            txtSupervisorEmail.TabIndex = 23;
            // 
            // txtSupervisorDepartment
            // 
            txtSupervisorDepartment.Location = new Point(150, 340);
            txtSupervisorDepartment.Name = "txtSupervisorDepartment";
            txtSupervisorDepartment.Size = new Size(100, 23);
            txtSupervisorDepartment.TabIndex = 25;
            // 
            // approveSocietyBtn
            // 
            approveSocietyBtn.Location = new Point(668, 10);
            approveSocietyBtn.Name = "approveSocietyBtn";
            approveSocietyBtn.Size = new Size(80, 40);
            approveSocietyBtn.TabIndex = 28;
            approveSocietyBtn.Text = "Approve Society";
            // 
            // showDescription
            // 
            showDescription.Location = new Point(150, 40);
            showDescription.Name = "showDescription";
            showDescription.ReadOnly = true;
            showDescription.Size = new Size(100, 23);
            showDescription.TabIndex = 14;
            // 
            // SocietyInformationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblDescription);
            Controls.Add(lblType);
            Controls.Add(lblSupervisorContact);
            Controls.Add(lblSupervisorEmail);
            Controls.Add(lblSupervisorDepartment);
            Controls.Add(showName);
            Controls.Add(showDescription);
            Controls.Add(showSupervisor);
            Controls.Add(pbLogo);
            Controls.Add(txtType);
            Controls.Add(txtSupervisorContact);
            Controls.Add(txtSupervisorEmail);
            Controls.Add(txtSupervisorDepartment);
            Controls.Add(approveSocietyBtn);
            Name = "SocietyInformationView";
            Text = "SocietyInformationView";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox showDescription;
    }
}