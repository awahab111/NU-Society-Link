namespace NU_Society_Link.View
{
    partial class AddEvent
    {
        // ...

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblSocietyName;
        private System.Windows.Forms.TextBox txtSocietyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.Label lblEventStartTime;
        private System.Windows.Forms.Label lblEventEndTime;
        private System.Windows.Forms.Label lblExpParticipants;
        private System.Windows.Forms.TextBox txtExpParticipants;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.TextBox txtVenueName;

        private void InitializeComponent()
        {
            lblEventName = new Label();
            txtEventName = new TextBox();
            lblSocietyName = new Label();
            txtSocietyName = new TextBox();
            btnSave = new Button();
            lblDescription = new Label();
            lblEventType = new Label();
            txtEventType = new TextBox();
            lblEventStartTime = new Label();
            lblEventEndTime = new Label();
            lblExpParticipants = new Label();
            txtExpParticipants = new TextBox();
            lblVenueName = new Label();
            txtVenueName = new TextBox();
            txtEventDesc = new RichTextBox();
            flaglbl = new Label();
            rtbEventReq = new RichTextBox();
            lblEventReq = new Label();
            StartTime = new DateTimePicker();
            EndTime = new DateTimePicker();
            
            SuspendLayout();
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Location = new Point(20, 21);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(75, 17);
            lblEventName.TabIndex = 0;
            lblEventName.Text = "Event Name:";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(108, 14);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(200, 24);
            txtEventName.TabIndex = 1;
            // 
            // lblSocietyName
            // 
            lblSocietyName.AutoSize = true;
            lblSocietyName.Location = new Point(20, 51);
            lblSocietyName.Name = "lblSocietyName";
            lblSocietyName.Size = new Size(81, 17);
            lblSocietyName.TabIndex = 2;
            lblSocietyName.Text = "Society_name";
            // 
            // txtSocietyName
            // 
            txtSocietyName.Location = new Point(108, 44);
            txtSocietyName.Name = "txtSocietyName";
            txtSocietyName.Size = new Size(200, 24);
            txtSocietyName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(4, 59, 72);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(390, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 26);
            btnSave.TabIndex = 7;
            btnSave.Text = "Done";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(390, 182);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 17);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Event Description";
            // 
            // lblEventType
            // 
            lblEventType.AutoSize = true;
            lblEventType.Location = new Point(20, 77);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(66, 17);
            lblEventType.TabIndex = 10;
            lblEventType.Text = "Event Type";
            // 
            // txtEventType
            // 
            txtEventType.Location = new Point(108, 74);
            txtEventType.Name = "txtEventType";
            txtEventType.Size = new Size(200, 24);
            txtEventType.TabIndex = 11;
            // 
            // lblEventStartTime
            // 
            lblEventStartTime.AutoSize = true;
            lblEventStartTime.Location = new Point(7, 164);
            lblEventStartTime.Name = "lblEventStartTime";
            lblEventStartTime.Size = new Size(96, 17);
            lblEventStartTime.TabIndex = 14;
            lblEventStartTime.Text = "Event Start TIme";
            // 
            // lblEventEndTime
            // 
            lblEventEndTime.AutoSize = true;
            lblEventEndTime.Location = new Point(7, 193);
            lblEventEndTime.Name = "lblEventEndTime";
            lblEventEndTime.Size = new Size(90, 17);
            lblEventEndTime.TabIndex = 16;
            lblEventEndTime.Text = "Event End Time";
            // 
            // lblExpParticipants
            // 
            lblExpParticipants.AutoSize = true;
            lblExpParticipants.Location = new Point(7, 221);
            lblExpParticipants.Name = "lblExpParticipants";
            lblExpParticipants.Size = new Size(126, 17);
            lblExpParticipants.TabIndex = 18;
            lblExpParticipants.Text = "Expected Participants";
            // 
            // txtExpParticipants
            // 
            txtExpParticipants.Location = new Point(180, 214);
            txtExpParticipants.Name = "txtExpParticipants";
            txtExpParticipants.Size = new Size(171, 24);
            txtExpParticipants.TabIndex = 19;
            // 
            // lblVenueName
            // 
            lblVenueName.AutoSize = true;
            lblVenueName.Location = new Point(6, 250);
            lblVenueName.Name = "lblVenueName";
            lblVenueName.Size = new Size(74, 17);
            lblVenueName.TabIndex = 20;
            lblVenueName.Text = "Venue Name";
            // 
            // txtVenueName
            // 
            txtVenueName.Location = new Point(180, 243);
            txtVenueName.Name = "txtVenueName";
            txtVenueName.Size = new Size(171, 24);
            txtVenueName.TabIndex = 21;
            // 
            // txtEventDesc
            // 
            txtEventDesc.Location = new Point(390, 206);
            txtEventDesc.Name = "txtEventDesc";
            txtEventDesc.Size = new Size(169, 96);
            txtEventDesc.TabIndex = 24;
            txtEventDesc.Text = "";
            // 
            // flaglbl
            // 
            flaglbl.AutoSize = true;
            flaglbl.BackColor = Color.White;
            flaglbl.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            flaglbl.ForeColor = Color.OrangeRed;
            flaglbl.Location = new Point(243, 353);
            flaglbl.Name = "flaglbl";
            flaglbl.Size = new Size(0, 17);
            flaglbl.TabIndex = 25;
            // 
            // rtbEventReq
            // 
            rtbEventReq.Location = new Point(390, 60);
            rtbEventReq.Name = "rtbEventReq";
            rtbEventReq.Size = new Size(169, 96);
            rtbEventReq.TabIndex = 26;
            rtbEventReq.Text = "";
            // 
            // lblEventReq
            // 
            lblEventReq.AutoSize = true;
            lblEventReq.Location = new Point(390, 40);
            lblEventReq.Name = "lblEventReq";
            lblEventReq.Size = new Size(116, 17);
            lblEventReq.TabIndex = 27;
            lblEventReq.Text = "Event Requirements";
            // 
            // StartTime
            // 
            StartTime.Location = new Point(166, 158);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(185, 24);
            StartTime.TabIndex = 28;
            // 
            // EndTime
            // 
            EndTime.Location = new Point(166, 186);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(185, 24);
            EndTime.TabIndex = 29;
            // 
            // flag
            // 
          
            // 
            // AddEvent
            // 
            AutoSize = true;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(575, 403);
            
            Controls.Add(EndTime);
            Controls.Add(StartTime);
            Controls.Add(lblEventReq);
            Controls.Add(rtbEventReq);
            Controls.Add(flaglbl);
            Controls.Add(txtEventDesc);
            Controls.Add(lblEventName);
            Controls.Add(txtEventName);
            Controls.Add(lblSocietyName);
            Controls.Add(txtSocietyName);
            Controls.Add(btnSave);
            Controls.Add(lblDescription);
            Controls.Add(lblEventType);
            Controls.Add(txtEventType);
            Controls.Add(lblEventStartTime);
            Controls.Add(lblEventEndTime);
            Controls.Add(lblExpParticipants);
            Controls.Add(txtExpParticipants);
            Controls.Add(lblVenueName);
            Controls.Add(txtVenueName);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            ForeColor = Color.WhiteSmoke;
            Name = "AddEvent";
            Text = "Add Event";
            ResumeLayout(false);
            PerformLayout();
        }

        // Event handler for btnBrowseLogo button click


        private RichTextBox txtEventDesc;
        private Label flaglbl;
        private RichTextBox rtbEventReq;
        private Label lblEventReq;
        private DateTimePicker StartTime;
        private DateTimePicker EndTime;
        private Label flag;

        // ...
    }
}