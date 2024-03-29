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

        // Add other controls
        private System.Windows.Forms.Button closeButton;
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
            closeButton = new Button();
            approveSocietyBtn = new Button();
            showDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(114, 33);
            label1.TabIndex = 0;
            label1.Text = "Society Name";
            // 
            // label2
            // 
            label2.Location = new Point(11, 56);
            label2.Name = "label2";
            label2.Size = new Size(114, 33);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Location = new Point(11, 98);
            label3.Name = "label3";
            label3.Size = new Size(153, 33);
            label3.TabIndex = 2;
            label3.Text = "Supervisor Name";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(11, 171);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 33);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Logo";
            // 
            // lblType
            // 
            lblType.Location = new Point(11, 308);
            lblType.Name = "lblType";
            lblType.Size = new Size(114, 33);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            // 
            // lblSupervisorContact
            // 
            lblSupervisorContact.Location = new Point(11, 350);
            lblSupervisorContact.Name = "lblSupervisorContact";
            lblSupervisorContact.Size = new Size(153, 33);
            lblSupervisorContact.TabIndex = 8;
            lblSupervisorContact.Text = "Supervisor Contact";
            // 
            // lblSupervisorEmail
            // 
            lblSupervisorEmail.Location = new Point(11, 392);
            lblSupervisorEmail.Name = "lblSupervisorEmail";
            lblSupervisorEmail.Size = new Size(114, 33);
            lblSupervisorEmail.TabIndex = 9;
            lblSupervisorEmail.Text = "Supervisor Email";
            // 
            // lblSupervisorDepartment
            // 
            lblSupervisorDepartment.Location = new Point(11, 476);
            lblSupervisorDepartment.Name = "lblSupervisorDepartment";
            lblSupervisorDepartment.Size = new Size(153, 33);
            lblSupervisorDepartment.TabIndex = 11;
            lblSupervisorDepartment.Text = "Supervisor Department";
            // 
            // showName
            // 
            showName.Location = new Point(171, 14);
            showName.Margin = new Padding(3, 4, 3, 4);
            showName.Name = "showName";
            showName.ReadOnly = true;
            showName.Size = new Size(114, 28);
            showName.TabIndex = 13;
            // 
            // showSupervisor
            // 
            showSupervisor.Location = new Point(171, 98);
            showSupervisor.Margin = new Padding(3, 4, 3, 4);
            showSupervisor.Name = "showSupervisor";
            showSupervisor.ReadOnly = true;
            showSupervisor.Size = new Size(114, 28);
            showSupervisor.TabIndex = 15;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(171, 152);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(114, 129);
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // txtType
            // 
            txtType.Location = new Point(171, 308);
            txtType.Margin = new Padding(3, 4, 3, 4);
            txtType.Name = "txtType";
            txtType.Size = new Size(114, 28);
            txtType.TabIndex = 21;
            // 
            // txtSupervisorContact
            // 
            txtSupervisorContact.Location = new Point(171, 350);
            txtSupervisorContact.Margin = new Padding(3, 4, 3, 4);
            txtSupervisorContact.Name = "txtSupervisorContact";
            txtSupervisorContact.Size = new Size(114, 28);
            txtSupervisorContact.TabIndex = 22;
            // 
            // txtSupervisorEmail
            // 
            txtSupervisorEmail.Location = new Point(171, 392);
            txtSupervisorEmail.Margin = new Padding(3, 4, 3, 4);
            txtSupervisorEmail.Name = "txtSupervisorEmail";
            txtSupervisorEmail.Size = new Size(114, 28);
            txtSupervisorEmail.TabIndex = 23;
            // 
            // txtSupervisorDepartment
            // 
            txtSupervisorDepartment.Location = new Point(171, 476);
            txtSupervisorDepartment.Margin = new Padding(3, 4, 3, 4);
            txtSupervisorDepartment.Name = "txtSupervisorDepartment";
            txtSupervisorDepartment.Size = new Size(114, 28);
            txtSupervisorDepartment.TabIndex = 25;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(782, 392);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(54, 40);
            closeButton.TabIndex = 27;
            closeButton.Text = "Close";
            // 
            // approveSocietyBtn
            // 
            approveSocietyBtn.BackColor = Color.FromArgb(4, 59, 72);
            approveSocietyBtn.Cursor = Cursors.Hand;
            approveSocietyBtn.FlatStyle = FlatStyle.Popup;
            approveSocietyBtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            approveSocietyBtn.Location = new Point(763, 14);
            approveSocietyBtn.Margin = new Padding(3, 4, 3, 4);
            approveSocietyBtn.Name = "approveSocietyBtn";
            approveSocietyBtn.Size = new Size(91, 56);
            approveSocietyBtn.TabIndex = 28;
            approveSocietyBtn.Text = "Approve Society";
            approveSocietyBtn.UseVisualStyleBackColor = false;
            // 
            // showDescription
            // 
            showDescription.Location = new Point(171, 56);
            showDescription.Margin = new Padding(3, 4, 3, 4);
            showDescription.Name = "showDescription";
            showDescription.ReadOnly = true;
            showDescription.Size = new Size(114, 28);
            showDescription.TabIndex = 14;
            // 
            // SocietyInformationView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(914, 630);
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
            Controls.Add(closeButton);
            Controls.Add(approveSocietyBtn);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(3, 4, 3, 4);
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