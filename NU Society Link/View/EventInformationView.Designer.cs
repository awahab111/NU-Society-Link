namespace NU_Society_Link.View
{
    partial class EventInformationView
    {
        // Add label controls to display the society information
        private System.Windows.Forms.Label eventTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;

        // Add other controls
        private System.Windows.Forms.Button closeButton;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            eventTitle = new Label();
            label2 = new Label();
            lblDescription = new Label();
            lblType = new Label();
            txtType = new TextBox();
            closeButton = new Button();
            label4 = new Label();
            nameheadtxt = new TextBox();
            label5 = new Label();
            headtxt = new TextBox();
            desctxt = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            reqtxt = new RichTextBox();
            label8 = new Label();
            venuetxt = new TextBox();
            label9 = new Label();
            datestarttxt = new TextBox();
            Durationtxt = new TextBox();
            label10 = new Label();
            label1 = new Label();
            parttxt = new TextBox();
            label3 = new Label();
            timetxt = new TextBox();
            SuspendLayout();
            // 
            // eventTitle
            // 
            eventTitle.Font = new Font("Bahnschrift SemiBold SemiConden", 20.25F, FontStyle.Bold);
            eventTitle.Location = new Point(36, 37);
            eventTitle.Name = "eventTitle";
            eventTitle.Size = new Size(171, 48);
            eventTitle.TabIndex = 0;
            eventTitle.Text = "Event Title";
            // 
            // label2
            // 
            label2.Location = new Point(484, 301);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(484, 144);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 21);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Requirements";
            // 
            // lblType
            // 
            lblType.Location = new Point(42, 331);
            lblType.Name = "lblType";
            lblType.Size = new Size(34, 24);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(131, 331);
            txtType.Margin = new Padding(3, 4, 3, 4);
            txtType.Name = "txtType";
            txtType.Size = new Size(76, 24);
            txtType.TabIndex = 21;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(682, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(54, 40);
            closeButton.TabIndex = 27;
            closeButton.Text = "Close";
            // 
            // label4
            // 
            label4.Location = new Point(41, 212);
            label4.Name = "label4";
            label4.Size = new Size(103, 24);
            label4.TabIndex = 29;
            label4.Text = "Head Name";
            // 
            // nameheadtxt
            // 
            nameheadtxt.Location = new Point(160, 209);
            nameheadtxt.Margin = new Padding(3, 4, 3, 4);
            nameheadtxt.Name = "nameheadtxt";
            nameheadtxt.ReadOnly = true;
            nameheadtxt.Size = new Size(216, 24);
            nameheadtxt.TabIndex = 30;
            // 
            // label5
            // 
            label5.Location = new Point(41, 167);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 31;
            label5.Text = "Event Head";
            // 
            // headtxt
            // 
            headtxt.Location = new Point(160, 164);
            headtxt.Margin = new Padding(3, 4, 3, 4);
            headtxt.Name = "headtxt";
            headtxt.ReadOnly = true;
            headtxt.Size = new Size(127, 24);
            headtxt.TabIndex = 32;
            // 
            // desctxt
            // 
            desctxt.Location = new Point(484, 328);
            desctxt.Name = "desctxt";
            desctxt.Size = new Size(263, 111);
            desctxt.TabIndex = 33;
            desctxt.Text = "";
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 125);
            label6.Name = "label6";
            label6.Size = new Size(139, 24);
            label6.TabIndex = 35;
            label6.Text = "Head Info";
            // 
            // label7
            // 
            label7.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 253);
            label7.Name = "label7";
            label7.Size = new Size(139, 24);
            label7.TabIndex = 36;
            label7.Text = "Event Info";
            // 
            // reqtxt
            // 
            reqtxt.Location = new Point(485, 168);
            reqtxt.Name = "reqtxt";
            reqtxt.Size = new Size(262, 109);
            reqtxt.TabIndex = 37;
            reqtxt.Text = "";
            // 
            // label8
            // 
            label8.Location = new Point(42, 298);
            label8.Name = "label8";
            label8.Size = new Size(47, 24);
            label8.TabIndex = 38;
            label8.Text = "Venue";
            // 
            // venuetxt
            // 
            venuetxt.Location = new Point(131, 298);
            venuetxt.Margin = new Padding(3, 4, 3, 4);
            venuetxt.Name = "venuetxt";
            venuetxt.Size = new Size(137, 24);
            venuetxt.TabIndex = 39;
            // 
            // label9
            // 
            label9.Location = new Point(41, 363);
            label9.Name = "label9";
            label9.Size = new Size(74, 24);
            label9.TabIndex = 42;
            label9.Text = "Date";
            // 
            // datestarttxt
            // 
            datestarttxt.Location = new Point(131, 363);
            datestarttxt.Margin = new Padding(3, 4, 3, 4);
            datestarttxt.Name = "datestarttxt";
            datestarttxt.Size = new Size(127, 24);
            datestarttxt.TabIndex = 43;
            // 
            // Durationtxt
            // 
            Durationtxt.Location = new Point(131, 424);
            Durationtxt.Margin = new Padding(3, 4, 3, 4);
            Durationtxt.Name = "Durationtxt";
            Durationtxt.Size = new Size(106, 24);
            Durationtxt.TabIndex = 41;
            // 
            // label10
            // 
            label10.Location = new Point(41, 424);
            label10.Name = "label10";
            label10.Size = new Size(74, 24);
            label10.TabIndex = 40;
            label10.Text = "Duration";
            // 
            // label1
            // 
            label1.Location = new Point(41, 456);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 44;
            label1.Text = "Participants";
            // 
            // parttxt
            // 
            parttxt.Location = new Point(131, 456);
            parttxt.Margin = new Padding(3, 4, 3, 4);
            parttxt.Name = "parttxt";
            parttxt.Size = new Size(59, 24);
            parttxt.TabIndex = 45;
            // 
            // label3
            // 
            label3.Location = new Point(41, 392);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 46;
            label3.Text = "Time";
            // 
            // timetxt
            // 
            timetxt.Location = new Point(131, 392);
            timetxt.Margin = new Padding(3, 4, 3, 4);
            timetxt.Name = "timetxt";
            timetxt.Size = new Size(59, 24);
            timetxt.TabIndex = 47;

            nameheadtxt.ReadOnly = true;
            headtxt.ReadOnly = true;
            desctxt.ReadOnly = true;
            reqtxt.ReadOnly = true;
            txtType.ReadOnly = true;
            venuetxt.ReadOnly = true;
            datestarttxt.ReadOnly = true;
            Durationtxt.ReadOnly = true;
            parttxt.ReadOnly = true;
            timetxt.ReadOnly = true;

            nameheadtxt.Cursor = Cursors.Arrow;
            headtxt.Cursor = Cursors.Arrow;
            desctxt.Cursor = Cursors.Arrow;
            reqtxt.Cursor = Cursors.Arrow;
            txtType.Cursor = Cursors.Arrow;
            venuetxt.Cursor = Cursors.Arrow;
            datestarttxt.Cursor = Cursors.Arrow;
            Durationtxt.Cursor = Cursors.Arrow;
            parttxt.Cursor = Cursors.Arrow;
            timetxt.Cursor = Cursors.Arrow;

            nameheadtxt.TabStop = false;
            headtxt.TabStop = false;
            desctxt.TabStop = false;
            reqtxt.TabStop = false;
            txtType.TabStop = false;
            venuetxt.TabStop = false;
            datestarttxt.TabStop = false;
            Durationtxt.TabStop = false;
            parttxt.TabStop = false;
            timetxt.TabStop = false;
            // 
            // EventInformationView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(774, 552);
            Controls.Add(label3);
            Controls.Add(timetxt);
            Controls.Add(label1);
            Controls.Add(parttxt);
            Controls.Add(label9);
            Controls.Add(datestarttxt);
            Controls.Add(label10);
            Controls.Add(Durationtxt);
            Controls.Add(label8);
            Controls.Add(venuetxt);
            Controls.Add(reqtxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(desctxt);
            Controls.Add(label5);
            Controls.Add(headtxt);
            Controls.Add(label4);
            Controls.Add(nameheadtxt);
            Controls.Add(eventTitle);
            Controls.Add(label2);
            Controls.Add(lblDescription);
            Controls.Add(lblType);
            Controls.Add(txtType);
            Controls.Add(closeButton);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventInformationView";
            Text = "SocietyInformationView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox nameheadtxt;
        private Label label5;
        private TextBox headtxt;
        private RichTextBox desctxt;
        private Label label6;
        private Label label7;
        private RichTextBox reqtxt;
        private Label label8;
        private TextBox venuetxt;
        private Label label9;
        private TextBox datestarttxt;
        private TextBox Durationtxt;
        private Label label10;
        private Label label1;
        private TextBox parttxt;
        private Label label3;
        private TextBox timetxt;
    }
}