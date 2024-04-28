namespace NU_Society_Link.View
{
    partial class UserRegisterView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtName; // Added TextBox for name input
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblName; // Added Label for name input
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblId = new Label();
            txtId = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblBatch = new Label();
            txtBatch = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            label1 = new Label();
            lblName = new Label();
            txtName = new TextBox();
            RegisterFlag = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.WhiteSmoke;
            lblId.Location = new Point(39, 99);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(39, 122);
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 29);
            txtId.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.WhiteSmoke;
            lblUsername.Location = new Point(39, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(39, 192);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 29);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.WhiteSmoke;
            lblPassword.Location = new Point(39, 246);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(39, 269);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 29);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblContact
            // 
            lblContact.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.WhiteSmoke;
            lblContact.Location = new Point(391, 246);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 20);
            lblContact.TabIndex = 8;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 12F);
            txtContact.Location = new Point(391, 269);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(305, 29);
            txtContact.TabIndex = 9;
            // 
            // lblBatch
            // 
            lblBatch.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatch.ForeColor = Color.WhiteSmoke;
            lblBatch.Location = new Point(391, 169);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(100, 20);
            lblBatch.TabIndex = 10;
            lblBatch.Text = "Batch";
            // 
            // txtBatch
            // 
            txtBatch.Font = new Font("Segoe UI", 12F);
            txtBatch.Location = new Point(391, 192);
            txtBatch.Name = "txtBatch";
            txtBatch.Size = new Size(154, 29);
            txtBatch.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(4, 59, 72);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(391, 358);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(305, 42);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(4, 59, 72);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(39, 358);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(293, 42);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift SemiBold", 28.2F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 66);
            label1.TabIndex = 14;
            label1.Text = "Register";
            // 
            // lblName
            // 
            lblName.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.WhiteSmoke;
            lblName.Location = new Point(391, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(391, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 29);
            txtName.TabIndex = 16;
            // 
            // RegisterFlag
            // 
            RegisterFlag.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterFlag.ForeColor = Color.WhiteSmoke;
            RegisterFlag.Location = new Point(391, 319);
            RegisterFlag.Name = "RegisterFlag";
            RegisterFlag.Size = new Size(305, 20);
            RegisterFlag.TabIndex = 17;
            // 
            // UserRegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(768, 463);
            Controls.Add(RegisterFlag);
            Controls.Add(label1);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblBatch);
            Controls.Add(txtBatch);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserRegisterView";
            Text = "UserRegisterView";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label RegisterFlag;
    }
}
