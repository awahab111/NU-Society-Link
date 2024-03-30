namespace NU_Society_Link.View
{
    partial class AddMemberView
    {
        // ...

        private System.Windows.Forms.TextBox txtRollNum;
        private System.Windows.Forms.TextBox txtMemberPosition;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblRollNum;
        private System.Windows.Forms.Label lblMemberPosition;

        private System.Windows.Forms.Label lblflag;


        private void InitializeComponent()
        {
            txtRollNum = new TextBox();
            txtMemberPosition = new TextBox();
            btnAddMember = new Button();
            lblRollNum = new Label();
            lblMemberPosition = new Label();
            label2 = new Label();
            lblflag = new Label();
            SuspendLayout();
            // 
            // txtRollNum
            // 
            txtRollNum.Cursor = Cursors.IBeam;
            txtRollNum.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRollNum.Location = new Point(164, 138);
            txtRollNum.Name = "txtRollNum";
            txtRollNum.Size = new Size(200, 24);
            txtRollNum.TabIndex = 0;
            // 
            // txtMemberPosition
            // 
            txtMemberPosition.Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            txtMemberPosition.Location = new Point(164, 192);
            txtMemberPosition.Name = "txtMemberPosition";
            txtMemberPosition.Size = new Size(200, 24);
            txtMemberPosition.TabIndex = 5;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(4, 59, 72);
            btnAddMember.Cursor = Cursors.Hand;
            btnAddMember.FlatStyle = FlatStyle.Popup;
            btnAddMember.Location = new Point(124, 258);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(200, 30);
            btnAddMember.TabIndex = 7;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            // 
            // lblRollNum
            // 
            lblRollNum.AutoSize = true;
            lblRollNum.Location = new Point(57, 141);
            lblRollNum.Name = "lblRollNum";
            lblRollNum.Size = new Size(78, 17);
            lblRollNum.TabIndex = 8;
            lblRollNum.Text = "Roll Number:";
            // 
            // lblMemberPosition
            // 
            lblMemberPosition.AutoSize = true;
            lblMemberPosition.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemberPosition.Location = new Point(37, 195);
            lblMemberPosition.Name = "lblMemberPosition";
            lblMemberPosition.Size = new Size(98, 17);
            lblMemberPosition.TabIndex = 13;
            lblMemberPosition.Text = "Member Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 72);
            label2.Name = "label2";
            label2.Size = new Size(161, 27);
            label2.TabIndex = 17;
            label2.Text = "Add New Member";
            // 
            // lblflag
            // 
            lblflag.AutoSize = true;
            lblflag.BackColor = Color.White;
            lblflag.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblflag.Location = new Point(114, 307);
            lblflag.Name = "lblflag";
            lblflag.Size = new Size(0, 16);
            lblflag.TabIndex = 17;
            lblflag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddMemberView
            // 
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(431, 370);
            Controls.Add(label2);
            Controls.Add(txtRollNum);
            Controls.Add(txtMemberPosition);
            Controls.Add(btnAddMember);
            Controls.Add(lblRollNum);
            Controls.Add(lblMemberPosition);
            Controls.Add(lblflag);
            Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.WhiteSmoke;
            Name = "AddMemberView";
            Text = "Add New Member";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;

        // ...
    }
}