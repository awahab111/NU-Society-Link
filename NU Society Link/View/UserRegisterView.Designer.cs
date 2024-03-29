namespace NU_Society_Link.View
{
    partial class UserRegisterView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail; // Added email field
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin; // Added login button
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail; // Added email label
        private System.Windows.Forms.Label label1; // Added email label
        
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
            lblId = new Label();
            txtId = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.WhiteSmoke;
            lblId.Location = new Point(69, 74);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(69, 97);
            txtId.Name = "txtId";
            txtId.Size = new Size(404, 34);
            txtId.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.WhiteSmoke;
            lblUsername.Location = new Point(69, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(69, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(404, 34);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.WhiteSmoke;
            lblPassword.Location = new Point(69, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(69, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(404, 34);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(4, 59, 72);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(69, 284);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(404, 42);
            btnRegister.TabIndex = 8;
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
            btnLogin.Location = new Point(69, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(404, 42);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift SemiBold", 28.2F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(211, 66);
            label1.TabIndex = 10;
            label1.Text = "Register";
            // 
            // UserRegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(556, 386);
            Controls.Add(label1);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserRegisterView";
            Text = "UserRegisterView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
