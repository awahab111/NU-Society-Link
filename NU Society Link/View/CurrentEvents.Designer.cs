namespace NU_Society_Link.View
{
    partial class CurrentEvents
    {
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
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
            dgvEvents = new DataGridView();
            colEventTitle = new DataGridViewTextBoxColumn();
            colEventType = new DataGridViewTextBoxColumn();
            colStartTime = new DataGridViewTextBoxColumn();
            colEndTime = new DataGridViewTextBoxColumn();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
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
            txtSearch.Size = new Size(537, 25);
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
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.BackgroundColor = Color.FromArgb(7, 72, 85);
            dgvEvents.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvEvents.ColumnHeadersHeight = 29;
            dgvEvents.Columns.AddRange(new DataGridViewColumn[] { colEventTitle, colEventType, colStartTime, colEndTime });
            dgvEvents.GridColor = Color.FromArgb(7, 72, 85);
            dgvEvents.Location = new Point(14, 55);
            dgvEvents.Margin = new Padding(3, 4, 3, 4);
            dgvEvents.MultiSelect = false;
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(641, 560);
            dgvEvents.TabIndex = 2;
            //dgvEvents.CellContentClick += this.dgvEvents_CellContentClick;
            // 
            // colEventTitle
            // 
            colEventTitle.HeaderText = "Event Title";
            colEventTitle.MinimumWidth = 6;
            colEventTitle.Name = "colEventTitle";
            colEventTitle.ReadOnly = true;
            // 
            // colEventType
            // 
            colEventType.HeaderText = "Event Type";
            colEventType.MinimumWidth = 6;
            colEventType.Name = "colEventType";
            colEventType.ReadOnly = true;
            // 
            // colStartTime
            // 
            colStartTime.HeaderText = "Start Time";
            colStartTime.MinimumWidth = 6;
            colStartTime.Name = "colStartTime";
            colStartTime.ReadOnly = true;
            // 
            // colEndTime
            // 
            colEndTime.HeaderText = "End Time";
            colEndTime.MinimumWidth = 6;
            colEndTime.Name = "colEndTime";
            colEndTime.ReadOnly = true;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(14, 627);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 17);
            lblWarning.TabIndex = 4;
            // 
            // CurrentEvents
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(893, 693);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvEvents);
            Controls.Add(lblWarning);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CurrentEvents";
            Text = "Current Events View";
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
