﻿namespace NU_Society_Link.View
{
    partial class MembersView
    {
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAssignTask; // Added button
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.Label lblWarning;
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
            btnAssignTask = new Button();
            dgvMembers = new DataGridView();
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
            txtSearch.Location = new Point(12, 14);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(513, 25);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(4, 59, 72);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(522, 14);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 25);
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
            btnAddMember.Location = new Point(657, 55);
            btnAddMember.Margin = new Padding(3, 4, 3, 4);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(114, 35);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            // 
            // btnAssignTask
            // 
            btnAssignTask.BackColor = Color.FromArgb(4, 59, 72);
            btnAssignTask.Cursor = Cursors.Hand;
            btnAssignTask.FlatStyle = FlatStyle.Popup;
            btnAssignTask.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            btnAssignTask.ForeColor = Color.WhiteSmoke;
            btnAssignTask.Location = new Point(657, 96);
            btnAssignTask.Margin = new Padding(3, 4, 3, 4);
            btnAssignTask.Name = "btnAssignTask";
            btnAssignTask.Size = new Size(114, 35);
            btnAssignTask.TabIndex = 3;
            btnAssignTask.Text = "Assign Task";
            btnAssignTask.UseVisualStyleBackColor = false;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.BackgroundColor = Color.FromArgb(7, 72, 85);
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.GridColor = Color.FromArgb(7, 72, 85);
            dgvMembers.Location = new Point(14, 55);
            dgvMembers.Margin = new Padding(3, 4, 3, 4);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(617, 458);
            dgvMembers.TabIndex = 4;
            dgvMembers.SortCompare += DgvMembers_SortCompare;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(12, 448);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 17);
            lblWarning.TabIndex = 5;
            // 
            // MembersView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(893, 693);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAddMember);
            Controls.Add(btnAssignTask);
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