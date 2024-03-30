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
            societyListView.Location = new Point(9, 8);
            societyListView.Margin = new Padding(3, 2, 3, 2);
            societyListView.Name = "societyListView";
            societyListView.Size = new Size(683, 300);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(700, 338);
            Controls.Add(societyListView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ApproveSocietyView";
            Text = "Approve Society";
            ResumeLayout(false);
        }
    }
}