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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            // Id Label
            this.lblId = new System.Windows.Forms.Label();
            this.lblId.Text = "Id";
            this.lblId.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(this.lblId);

            // Id TextBox
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtId.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(this.txtId);

            // Username Label
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(50, 100);
            this.Controls.Add(this.lblUsername);

            // Username TextBox
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUsername.Location = new System.Drawing.Point(150, 100);
            this.Controls.Add(this.txtUsername);

            // Password Label
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(50, 150);
            this.Controls.Add(this.lblPassword);

            // Password TextBox
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword.Location = new System.Drawing.Point(150, 150);
            this.Controls.Add(this.txtPassword);

            // Email Label
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(50, 200);
            this.Controls.Add(this.lblEmail);

            // Email TextBox
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmail.Location = new System.Drawing.Point(150, 200);
            this.Controls.Add(this.txtEmail);

            // Register Button
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegister.Text = "Register";
            this.btnRegister.Location = new System.Drawing.Point(150, 250);
            this.Controls.Add(this.btnRegister);

            // Login Button
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(250, 250);
            this.Controls.Add(this.btnLogin);

            this.Text = "UserRegisterView";
        }

        #endregion
    }
}