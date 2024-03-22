namespace NU_Society_Link.View
{
    partial class AddMemberView
    {
        // ...

        private System.Windows.Forms.TextBox txtRollNum;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMemberContact;
        private System.Windows.Forms.TextBox txtMemberPosition;
        private System.Windows.Forms.TextBox txtMemberBatch;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblRollNum;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberEmail;
        private System.Windows.Forms.Label lblMemberContact;
        private System.Windows.Forms.Label lblMemberPosition;
        private System.Windows.Forms.Label lblMemberBatch;

        private void InitializeComponent()
        {
            txtRollNum = new TextBox();
            txtMemberName = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberContact = new TextBox();
            txtMemberPosition = new TextBox();
            txtMemberBatch = new TextBox();
            btnAddMember = new Button();
            lblRollNum = new Label();
            lblMemberName = new Label();
            lblMemberEmail = new Label();
            lblMemberContact = new Label();
            lblMemberPosition = new Label();
            lblMemberBatch = new Label();
            txtSocName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtRollNum
            // 
            txtRollNum.Location = new Point(114, 112);
            txtRollNum.Name = "txtRollNum";
            txtRollNum.Size = new Size(88, 23);
            txtRollNum.TabIndex = 0;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(114, 151);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(200, 23);
            txtMemberName.TabIndex = 2;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(114, 196);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(200, 23);
            txtMemberEmail.TabIndex = 3;
            // 
            // txtMemberContact
            // 
            txtMemberContact.Location = new Point(457, 141);
            txtMemberContact.Name = "txtMemberContact";
            txtMemberContact.Size = new Size(200, 23);
            txtMemberContact.TabIndex = 4;
            // 
            // txtMemberPosition
            // 
            txtMemberPosition.Location = new Point(457, 191);
            txtMemberPosition.Name = "txtMemberPosition";
            txtMemberPosition.Size = new Size(200, 23);
            txtMemberPosition.TabIndex = 5;
            // 
            // txtMemberBatch
            // 
            txtMemberBatch.Location = new Point(114, 241);
            txtMemberBatch.Name = "txtMemberBatch";
            txtMemberBatch.Size = new Size(200, 23);
            txtMemberBatch.TabIndex = 6;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(457, 242);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(200, 30);
            btnAddMember.TabIndex = 7;
            btnAddMember.Text = "Add Member";
            // 
            // lblRollNum
            // 
            lblRollNum.AutoSize = true;
            lblRollNum.Location = new Point(16, 115);
            lblRollNum.Name = "lblRollNum";
            lblRollNum.Size = new Size(77, 15);
            lblRollNum.TabIndex = 8;
            lblRollNum.Text = "Roll Number:";
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Location = new Point(13, 154);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(90, 15);
            lblMemberName.TabIndex = 10;
            lblMemberName.Text = "Member Name:";
            // 
            // lblMemberEmail
            // 
            lblMemberEmail.AutoSize = true;
            lblMemberEmail.Location = new Point(13, 199);
            lblMemberEmail.Name = "lblMemberEmail";
            lblMemberEmail.Size = new Size(87, 15);
            lblMemberEmail.TabIndex = 11;
            lblMemberEmail.Text = "Member Email:";
            // 
            // lblMemberContact
            // 
            lblMemberContact.AutoSize = true;
            lblMemberContact.Location = new Point(351, 149);
            lblMemberContact.Name = "lblMemberContact";
            lblMemberContact.Size = new Size(100, 15);
            lblMemberContact.TabIndex = 12;
            lblMemberContact.Text = "Member Contact:";
            // 
            // lblMemberPosition
            // 
            lblMemberPosition.AutoSize = true;
            lblMemberPosition.Location = new Point(350, 194);
            lblMemberPosition.Name = "lblMemberPosition";
            lblMemberPosition.Size = new Size(101, 15);
            lblMemberPosition.TabIndex = 13;
            lblMemberPosition.Text = "Member Position:";
            // 
            // lblMemberBatch
            // 
            lblMemberBatch.AutoSize = true;
            lblMemberBatch.Location = new Point(13, 244);
            lblMemberBatch.Name = "lblMemberBatch";
            lblMemberBatch.Size = new Size(88, 15);
            lblMemberBatch.TabIndex = 14;
            lblMemberBatch.Text = "Member Batch:";
            // 
            // txtSocName
            // 
            txtSocName.Location = new Point(114, 289);
            txtSocName.Name = "txtSocName";
            txtSocName.Size = new Size(200, 23);
            txtSocName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 292);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 16;
            label1.Text = "Society Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 31);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 17;
            label2.Text = "Add New Member";
            // 
            // AddMemberView
            // 
            ClientSize = new Size(669, 466);
            Controls.Add(label2);
            Controls.Add(txtSocName);
            Controls.Add(label1);
            Controls.Add(txtRollNum);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberContact);
            Controls.Add(txtMemberPosition);
            Controls.Add(txtMemberBatch);
            Controls.Add(btnAddMember);
            Controls.Add(lblRollNum);
            Controls.Add(lblMemberName);
            Controls.Add(lblMemberEmail);
            Controls.Add(lblMemberContact);
            Controls.Add(lblMemberPosition);
            Controls.Add(lblMemberBatch);
            Name = "AddMemberView";
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox txtSocName;
        private Label label1;
        private Label label2;

        // ...
    }
}