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
            Registerbtn = new Button();
            Loginflag = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(147, 132);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 1;
            label2.Text = "Username: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(328, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(147, 226);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsername.Location = new Point(147, 165);
            TxtUsername.Margin = new Padding(3, 4, 3, 4);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(461, 27);
            TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(147, 260);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(461, 29);
            TxtPassword.TabIndex = 4;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.FromArgb(4, 59, 72);
            Loginbtn.Cursor = Cursors.Hand;
            Loginbtn.FlatStyle = FlatStyle.Popup;
            Loginbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.ForeColor = Color.WhiteSmoke;
            Loginbtn.Location = new Point(147, 366);
            Loginbtn.Margin = new Padding(3, 4, 3, 4);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(217, 49);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            // 
            // Registerbtn
            // 
            Registerbtn.BackColor = Color.FromArgb(4, 59, 72);
            Registerbtn.Cursor = Cursors.Hand;
            Registerbtn.FlatStyle = FlatStyle.Popup;
            Registerbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold);
            Registerbtn.ForeColor = Color.WhiteSmoke;
            Registerbtn.Location = new Point(391, 366);
            Registerbtn.Margin = new Padding(3, 4, 3, 4);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(217, 49);
            Registerbtn.TabIndex = 6;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = false;
            // 
            // Loginflag
            // 
            Loginflag.AutoSize = true;
            Loginflag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginflag.Location = new Point(442, 226);
            Loginflag.Name = "Loginflag";
            Loginflag.Size = new Size(0, 21);
            Loginflag.TabIndex = 7;
            // 
            // UserLoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(635, 508);
            Controls.Add(Loginflag);
            Controls.Add(Registerbtn);
            Controls.Add(Loginbtn);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserLoginView";
            Text = "Login";
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