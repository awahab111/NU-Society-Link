using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class SocietyInformationView : Form
    {
        public event EventHandler LoadPage;
        public event EventHandler ClosePage;

        public event EventHandler ApproveSociety;

        private SocietyInformationView()
        {
            InitializeComponent();
            Load += delegate{ LoadPage?.Invoke(this, EventArgs.Empty); };
            approveSocietyBtn.Click += delegate { ApproveSociety?.Invoke(this, EventArgs.Empty); };
        }

        private static SocietyInformationView instance;
        public static SocietyInformationView GetInstance(Form parent)
        {
            if (instance == null)
            {
                instance = new SocietyInformationView();
                instance.MdiParent = parent;
                instance.StartPosition = FormStartPosition.CenterScreen;
                instance.FormBorderStyle = FormBorderStyle.None;
            }
            return instance;
        }

        internal void updateInformation(Society society)
        {
            showName.Text = society.SocietyName;
            showDescription.Text = society.SocietyDescription;
            showSupervisor.Text = society.SocietySupervisor;
            txtSupervisorContact.Text = society.SocietySupervisorContact;
            txtSupervisorDepartment.Text = society.SocietySupervisorDepartment;
            txtSupervisorEmail.Text = society.SocietySupervisorEmail;
            txtType.Text = society.SocietyType;

            if (society.SocietyLogo == "NONE")
            {
                return;
            }

            byte[] imageBytes = Convert.FromBase64String(society.SocietyLogo);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                pbLogo.Image = Image.FromStream(ms);
            }

            Debug.WriteLine("Information Updated");
        }
    }
}
