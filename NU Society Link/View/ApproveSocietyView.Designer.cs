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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ApproveSocietyView";

            // Create the list view
            this.societyListView = new ListView();
            this.societyListView.Location = new System.Drawing.Point(10, 10);
            this.societyListView.Size = new System.Drawing.Size(780, 400);
            this.societyListView.View = System.Windows.Forms.View.Details;
            this.societyListView.FullRowSelect = true;

            // Create the columns
            this.societyIdColumn = new ColumnHeader();
            this.societyIdColumn.Text = "ID";
            this.societyIdColumn.Width = 200;

            this.societyNameColumn = new ColumnHeader();
            this.societyNameColumn.Text = "Society Name";
            this.societyNameColumn.Width = 200;

            this.supervisorNameColumn = new ColumnHeader();
            this.supervisorNameColumn.Text = "Supervisor Name";
            this.supervisorNameColumn.Width = 200;

            this.societyDescriptionColumn = new ColumnHeader();
            this.societyDescriptionColumn.Text = "Description";
            this.societyDescriptionColumn.Width = 200;

            // Add the columns to the list view
            this.societyListView.Columns.Add(this.societyIdColumn);
            this.societyListView.Columns.Add(this.societyNameColumn);
            this.societyListView.Columns.Add(this.supervisorNameColumn);
            this.societyListView.Columns.Add(this.societyDescriptionColumn);

            // Add the list view to the form
            this.Controls.Add(this.societyListView);
        }


    }
}