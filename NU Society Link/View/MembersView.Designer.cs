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
            txtSearch.BackColor = Color.FromArgb(4, 59, 72);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F);
            txtSearch.ForeColor = Color.WhiteSmoke;
            txtSearch.Location = new Point(14, 14);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(537, 29);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(4, 59, 72);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(558, 12);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 35);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(4, 59, 72);
            btnAddMember.Cursor = Cursors.Hand;
            btnAddMember.FlatStyle = FlatStyle.Popup;
            btnAddMember.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            btnAddMember.ForeColor = Color.WhiteSmoke;
            btnAddMember.Location = new Point(713, 72);
            btnAddMember.Margin = new Padding(3, 4, 3, 4);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(114, 35);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.BackgroundColor = Color.FromArgb(7, 72, 85);
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colMemberName, colPosition, colBatch });
            dgvMembers.GridColor = Color.FromArgb(7, 72, 85);
            dgvMembers.Location = new Point(14, 55);
            dgvMembers.Margin = new Padding(3, 4, 3, 4);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(641, 560);
            dgvMembers.TabIndex = 3;
            dgvMembers.SortCompare += DgvMembers_SortCompare;
            // 
            // colMemberName
            // 
            colMemberName.HeaderText = "Member Name";
            colMemberName.MinimumWidth = 6;
            colMemberName.Name = "colMemberName";
            colMemberName.ReadOnly = true;
            // 
            // colPosition
            // 
            colPosition.HeaderText = "Position";
            colPosition.MinimumWidth = 6;
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            // 
            // colBatch
            // 
            colBatch.HeaderText = "Batch";
            colBatch.MinimumWidth = 6;
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
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(14, 627);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 21);
            lblWarning.TabIndex = 4;
            // 
            // MembersView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(893, 693);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAddMember);
            Controls.Add(dgvMembers);
            Controls.Add(lblWarning);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            Margin = new Padding(3, 4, 3, 4);
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