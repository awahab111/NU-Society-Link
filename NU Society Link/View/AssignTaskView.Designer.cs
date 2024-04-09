using System.Drawing;
using System.Windows.Forms;

namespace NU_Society_Link.View
{
    partial class AssignTaskView
    {
        // ...

        private System.Windows.Forms.TextBox txtAssignedTo;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.DateTimePicker dtpDueDate; // Added due date input
        private System.Windows.Forms.TextBox txtEventTitle; // Added event title input
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblDueDate; // Added due date label
        private System.Windows.Forms.Label lblEventTitle; // Added event title label
        private System.Windows.Forms.Label lblflag;
        private System.Windows.Forms.Label label2;

        private void InitializeComponent()
        {
            txtAssignedTo = new TextBox();
            txtTaskDescription = new TextBox();
            dtpDueDate = new DateTimePicker();
            txtEventTitle = new TextBox();
            btnAssignTask = new Button();
            lblAssignedTo = new Label();
            lblTaskDescription = new Label();
            lblDueDate = new Label();
            lblEventTitle = new Label();
            lblflag = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtAssignedTo
            // 
            txtAssignedTo.Cursor = Cursors.IBeam;
            txtAssignedTo.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssignedTo.Location = new Point(168, 89);
            txtAssignedTo.Name = "txtAssignedTo";
            txtAssignedTo.Size = new Size(200, 24);
            txtAssignedTo.TabIndex = 0;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Cursor = Cursors.IBeam;
            txtTaskDescription.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaskDescription.Location = new Point(168, 125);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(200, 80);
            txtTaskDescription.TabIndex = 1;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDueDate.Location = new Point(168, 221);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 24);
            dtpDueDate.TabIndex = 2;
            // 
            // txtEventTitle
            // 
            txtEventTitle.Cursor = Cursors.IBeam;
            txtEventTitle.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEventTitle.Location = new Point(168, 257);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(200, 24);
            txtEventTitle.TabIndex = 3;
            // 
            // btnAssignTask
            // 
            btnAssignTask.BackColor = Color.FromArgb(4, 59, 72);
            btnAssignTask.Cursor = Cursors.Hand;
            btnAssignTask.FlatStyle = FlatStyle.Popup;
            btnAssignTask.Location = new Point(122, 337);
            btnAssignTask.Name = "btnAssignTask";
            btnAssignTask.Size = new Size(200, 30);
            btnAssignTask.TabIndex = 4;
            btnAssignTask.Text = "Assign Task";
            btnAssignTask.UseVisualStyleBackColor = false;
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Location = new Point(61, 92);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(75, 17);
            lblAssignedTo.TabIndex = 5;
            lblAssignedTo.Text = "Assigned To:";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Location = new Point(61, 128);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(100, 17);
            lblTaskDescription.TabIndex = 6;
            lblTaskDescription.Text = "Task Description:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(61, 226);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(60, 17);
            lblDueDate.TabIndex = 7;
            lblDueDate.Text = "Due Date:";
            // 
            // lblEventTitle
            // 
            lblEventTitle.AutoSize = true;
            lblEventTitle.Location = new Point(61, 260);
            lblEventTitle.Name = "lblEventTitle";
            lblEventTitle.Size = new Size(67, 17);
            lblEventTitle.TabIndex = 8;
            lblEventTitle.Text = "Event Title:";
            // 
            // lblflag
            // 
            lblflag.AutoSize = true;
            lblflag.BackColor = Color.White;
            lblflag.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblflag.Location = new Point(85, 306);
            lblflag.Name = "lblflag";
            lblflag.Size = new Size(0, 16);
            lblflag.TabIndex = 9;
            lblflag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 38);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 10;
            label2.Text = "Assign Task";
            // 
            // AssignTaskView
            // 
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(431, 400);
            Controls.Add(label2);
            Controls.Add(txtAssignedTo);
            Controls.Add(txtTaskDescription);
            Controls.Add(dtpDueDate);
            Controls.Add(txtEventTitle);
            Controls.Add(btnAssignTask);
            Controls.Add(lblAssignedTo);
            Controls.Add(lblTaskDescription);
            Controls.Add(lblDueDate);
            Controls.Add(lblEventTitle);
            Controls.Add(lblflag);
            Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.WhiteSmoke;
            Name = "AssignTaskView";
            Text = "Assign Task";
            ResumeLayout(false);
            PerformLayout();
        }

        // ...
    }
}