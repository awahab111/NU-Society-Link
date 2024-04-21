namespace NU_Society_Link.View
{
    partial class SocietyInformationView
    {
        // Add label controls to display the society information
        private System.Windows.Forms.Label socNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSupervisorContact;
        private System.Windows.Forms.TextBox showSupervisor;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSupervisorEmail;

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
            socNamelbl = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDescription = new Label();
            lblType = new Label();
            lblSupervisorContact = new Label();
            showSupervisor = new TextBox();
            pbLogo = new PictureBox();
            txtType = new TextBox();
            txtSupervisorEmail = new TextBox();
            closeButton = new Button();
            approveSocietyBtn = new Button();
            label4 = new Label();
            presidentnametxt = new TextBox();
            label5 = new Label();
            presidentrolltxt = new TextBox();
            showDesc = new RichTextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // socNamelbl
            // 
            socNamelbl.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            socNamelbl.Location = new Point(25, 28);
            socNamelbl.Name = "socNamelbl";
            socNamelbl.Size = new Size(139, 24);
            socNamelbl.TabIndex = 0;
            socNamelbl.Text = "Society Name";
            // 
            // label2
            // 
            label2.Location = new Point(476, 356);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Location = new Point(29, 316);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 2;
            label3.Text = "Supervisor Name";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(476, 167);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(47, 21);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Logo";
            // 
            // lblType
            // 
            lblType.Location = new Point(476, 130);
            lblType.Name = "lblType";
            lblType.Size = new Size(34, 24);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            // 
            // lblSupervisorContact
            // 
            lblSupervisorContact.Location = new Point(29, 373);
            lblSupervisorContact.Name = "lblSupervisorContact";
            lblSupervisorContact.Size = new Size(114, 24);
            lblSupervisorContact.TabIndex = 8;
            lblSupervisorContact.Text = "Supervisor Email";
            // 
            // showSupervisor
            // 
            showSupervisor.Location = new Point(149, 316);
            showSupervisor.Margin = new Padding(3, 4, 3, 4);
            showSupervisor.Name = "showSupervisor";
            showSupervisor.Size = new Size(216, 24);
            showSupervisor.TabIndex = 15;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(477, 192);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(226, 148);
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // txtType
            // 
            txtType.Location = new Point(565, 130);
            txtType.Margin = new Padding(3, 4, 3, 4);
            txtType.Name = "txtType";
            txtType.Size = new Size(138, 24);
            txtType.TabIndex = 21;
            // 
            // txtSupervisorEmail
            // 
            txtSupervisorEmail.Location = new Point(149, 373);
            txtSupervisorEmail.Margin = new Padding(3, 4, 3, 4);
            txtSupervisorEmail.Name = "txtSupervisorEmail";
            txtSupervisorEmail.Size = new Size(216, 24);
            txtSupervisorEmail.TabIndex = 22;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(682, 12);
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
            approveSocietyBtn.Location = new Point(27, 488);
            approveSocietyBtn.Margin = new Padding(3, 4, 3, 4);
            approveSocietyBtn.Name = "approveSocietyBtn";
            approveSocietyBtn.Size = new Size(244, 43);
            approveSocietyBtn.TabIndex = 28;
            approveSocietyBtn.Text = "Approve Society";
            approveSocietyBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Location = new Point(30, 189);
            label4.Name = "label4";
            label4.Size = new Size(103, 24);
            label4.TabIndex = 29;
            label4.Text = "President Name";
            // 
            // presidentnametxt
            // 
            presidentnametxt.Location = new Point(149, 186);
            presidentnametxt.Margin = new Padding(3, 4, 3, 4);
            presidentnametxt.Name = "presidentnametxt";
            presidentnametxt.Size = new Size(216, 24);
            presidentnametxt.TabIndex = 30;
            presidentnametxt.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.Location = new Point(30, 144);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 31;
            label5.Text = "President Roll Number";
            // 
            // presidentrolltxt
            // 
            presidentrolltxt.Location = new Point(149, 141);
            presidentrolltxt.Margin = new Padding(3, 4, 3, 4);
            presidentrolltxt.Name = "presidentrolltxt";
            presidentrolltxt.Size = new Size(127, 24);
            presidentrolltxt.TabIndex = 32;
            // 
            // showDesc
            // 
            showDesc.Location = new Point(476, 383);
            showDesc.Name = "showDesc";
            showDesc.Size = new Size(227, 81);
            showDesc.TabIndex = 33;
            showDesc.Text = "";
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 259);
            label1.Name = "label1";
            label1.Size = new Size(139, 24);
            label1.TabIndex = 34;
            label1.Text = "Supervisor Info";
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 102);
            label6.Name = "label6";
            label6.Size = new Size(139, 24);
            label6.TabIndex = 35;
            label6.Text = "President Info";
            // 
            // label7
            // 
            label7.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(477, 69);
            label7.Name = "label7";
            label7.Size = new Size(139, 24);
            label7.TabIndex = 36;
            label7.Text = "Society Info";
            // 
            // SocietyInformationView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(774, 552);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(showDesc);
            Controls.Add(label5);
            Controls.Add(presidentrolltxt);
            Controls.Add(label4);
            Controls.Add(presidentnametxt);
            Controls.Add(socNamelbl);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblDescription);
            Controls.Add(lblType);
            Controls.Add(lblSupervisorContact);
            Controls.Add(showSupervisor);
            Controls.Add(pbLogo);
            Controls.Add(txtType);
            Controls.Add(txtSupervisorEmail);
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
        private Label label4;
        private TextBox presidentnametxt;
        private Label label5;
        private TextBox presidentrolltxt;
        private RichTextBox showDesc;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}