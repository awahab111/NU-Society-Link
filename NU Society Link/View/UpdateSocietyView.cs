using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NU_Society_Link.View
{
    public partial class UpdateSocietyView : Form
    {
        public UpdateSocietyView()
        {
            InitializeComponent();
            AssociateandRaiseEvents();
        }

        void AssociateandRaiseEvents()
        {
            btnSave.Click += delegate { UpdateSociety?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler? UpdateSociety;

        public string SocietyName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public string Type
        {
            get { return txtType.Text; }
            set { txtType.Text = value; }
        }

        public string Contact
        {
            get { return txtSupervisorContact.Text; }
            set { txtSupervisorContact.Text = value; }
        }

        public string Email
        {
            get { return txtSupervisorEmail.Text; }
            set { txtSupervisorEmail.Text = value; }
        }

        public string Designation
        {
            get { return txtSupervisorDesignation.Text; }
            set { txtSupervisorDesignation.Text = value; }
        }

        public string Department
        {
            get { return txtSupervisorDepartment.Text; }
            set { txtSupervisorDepartment.Text = value; }
        }

        public string Faculty
        {
            get { return txtSupervisorFaculty.Text; }
            set { txtSupervisorFaculty.Text = value; }
        }


        public string Supervisor
        {
            get { return txtSupervisor.Text; }
            set { txtSupervisor.Text = value; }
        }

        public string Logo
        {
            get { return pbLogo.ImageLocation; }
            set { pbLogo.ImageLocation = value; }
        }

        public string GetLogoBase64()
        {
            if (pbLogo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
            return "NONE";
        }

        public void setImage(MemoryStream image){
            pbLogo.Image = Image.FromStream(image);
        }

        public string flag {
            get { return flaglbl.Text; }
            set { flaglbl.Text = value; }
        }

        public void success()
        {
            flaglbl.ForeColor = Color.Green;
            flaglbl.Text = "Request Sent";
        }


        private static AddSocietyView? instance;

        public static AddSocietyView GetInstance(Form parentContainer)
        {
            if (instance == null)
            {
                instance = new AddSocietyView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        public void Delete()
        {
            this.Dispose();
            instance = null;
            this.Close();
        }
    }
}
