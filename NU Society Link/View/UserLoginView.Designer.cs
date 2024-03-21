namespace NU_Society_Link.View
{
    partial class UserLoginView
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
            Label label2;
            label1 = new Label();
            label3 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            Loginbtn = new Button();
            Registerbtn = new Button(); // Added register button
            Loginflag = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(106, 101);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Username: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(106, 137);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TxtUsername.Location = new Point(179, 98);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(404, 29);
            TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TxtPassword.Location = new Point(179, 129);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(404, 29);
            TxtPassword.TabIndex = 4;
            // 
            // Loginbtn
            // 
            Loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Loginbtn.Location = new Point(179, 174);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(190, 35);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            // 
            // Registerbtn
            // 
            Registerbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Registerbtn.Location = new Point(375, 174);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(190, 35);
            Registerbtn.TabIndex = 6;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = true;
            // 
            // Loginflag
            // 
            Loginflag.AutoSize = true;
            Loginflag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Loginflag.Location = new Point(437, 188);
            Loginflag.Name = "Loginflag";
            Loginflag.Size = new Size(0, 21);
            Loginflag.TabIndex = 7;
            // 
            // UserLoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loginflag);
            Controls.Add(Registerbtn);
            Controls.Add(Loginbtn);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserLoginView";
            Text = "UserLoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        public Button Loginbtn;
        public Button Registerbtn;
        private Label Loginflag;
    }
}