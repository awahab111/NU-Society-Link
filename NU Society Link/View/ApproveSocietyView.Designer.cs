using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace NU_Society_Link.View
{
    partial class ApproveSocietyView
    {
        private ListView societyListView;
        private ColumnHeader societyNameColumn;
        private ColumnHeader supervisorNameColumn;
        private ColumnHeader societyDescriptionColumn;
        private ColumnHeader societyIdColumn;
        private System.ComponentModel.IContainer components;


        private void InitializeComponent()
        {
            societyListView = new ListView();
            societyIdColumn = new ColumnHeader();
            societyNameColumn = new ColumnHeader();
            supervisorNameColumn = new ColumnHeader();
            societyDescriptionColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // societyListView
            // 
            societyListView.BackColor = Color.FromArgb(7, 72, 85);
            societyListView.BorderStyle = BorderStyle.FixedSingle;
            societyListView.Columns.AddRange(new ColumnHeader[] { societyIdColumn, societyNameColumn, supervisorNameColumn, societyDescriptionColumn });
            societyListView.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            societyListView.ForeColor = Color.WhiteSmoke;
            societyListView.FullRowSelect = true;
            societyListView.Location = new Point(10, 10);
            societyListView.Name = "societyListView";
            societyListView.Size = new Size(780, 400);
            societyListView.TabIndex = 0;
            societyListView.UseCompatibleStateImageBehavior = false;
            societyListView.View = System.Windows.Forms.View.Details;
            // 
            // societyIdColumn
            // 
            societyIdColumn.Text = "ID";
            societyIdColumn.Width = 200;
            // 
            // societyNameColumn
            // 
            societyNameColumn.Text = "Society Name";
            societyNameColumn.Width = 200;
            // 
            // supervisorNameColumn
            // 
            supervisorNameColumn.Text = "Supervisor Name";
            supervisorNameColumn.Width = 200;
            // 
            // societyDescriptionColumn
            // 
            societyDescriptionColumn.Text = "Description";
            societyDescriptionColumn.Width = 200;
            // 
            // ApproveSocietyView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(800, 450);
            Controls.Add(societyListView);
            Name = "ApproveSocietyView";
            Text = "Approve Society";
            ResumeLayout(false);
        }
    }
}