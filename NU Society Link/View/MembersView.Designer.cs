namespace NU_Society_Link.View
{
    partial class MembersView
    {
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddMember; // Added button
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.Label lblWarning; // Added label
        private System.ComponentModel.IContainer components = null;

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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddMember = new Button();
            dgvMembers = new DataGridView();
            colMemberName = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            colBatch = new DataGridViewTextBoxColumn();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(218, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(684, 48);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(100, 25);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "Add Member";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colMemberName, colPosition, colBatch });
            dgvMembers.Location = new Point(12, 39);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(634, 400);
            dgvMembers.TabIndex = 3;
            dgvMembers.SortCompare += DgvMembers_SortCompare;
            // 
            // colMemberName
            // 
            colMemberName.HeaderText = "Member Name";
            colMemberName.Name = "colMemberName";
            colMemberName.ReadOnly = true;
            // 
            // colPosition
            // 
            colPosition.HeaderText = "Position";
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            // 
            // colBatch
            // 
            colBatch.HeaderText = "Batch";
            colBatch.Name = "colBatch";
            colBatch.ReadOnly = true;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(12, 448);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(194, 15);
            lblWarning.TabIndex = 4;
            // 
            // MembersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 495);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAddMember);
            Controls.Add(dgvMembers);
            Controls.Add(lblWarning);
            Name = "MembersView";
            Text = "MembersView";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DgvMembers_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Perform custom sorting logic here
        }
    }
}