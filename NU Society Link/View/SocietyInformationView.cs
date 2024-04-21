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
using NU_Society_Link.DBHandlers;
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
            Load += delegate { LoadPage?.Invoke(this, EventArgs.Empty); };
            approveSocietyBtn.Click += delegate { ApproveSociety?.Invoke(this, EventArgs.Empty); };
            closeButton.Click += delegate { ClosePage?.DynamicInvoke(this, EventArgs.Empty); };
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

        public void Delete(){
            instance = null;
            this.Dispose();
        }

        internal void updateInformation(Society society, Student s)
        {


            socNamelbl.Text = society.SocietyName;
            showDesc.Text = society.SocietyDescription;
            showSupervisor.Text = society.SocietySupervisor;
            txtSupervisorEmail.Text = society.SocietySupervisorEmail;
            txtType.Text = society.SocietyType;
            presidentrolltxt.Text = s.RollNum;
            presidentnametxt.Text = s.Name;


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

        public void Readonly(){
            showDesc.ReadOnly = true;
            showSupervisor.ReadOnly = true;
            txtSupervisorEmail.ReadOnly = true;
            txtType.ReadOnly = true;
            presidentrolltxt.ReadOnly = true;
            presidentnametxt.ReadOnly = true;
        }

        public string SocietyName{
            get => socNamelbl.Text;
            set => socNamelbl.Text = value;
        }

        public string SocietyDescription{
            get => showDesc.Text;
            set => showDesc.Text = value;
        }

        public string SocietySupervisor{
            get => showSupervisor.Text;
            set => showSupervisor.Text = value;
        }

        public string SocietySupervisorEmail{
            get => txtSupervisorEmail.Text;
            set => txtSupervisorEmail.Text = value;
        }

        public string SocietyType{
            get => txtType.Text;
            set => txtType.Text = value;
        }

        public string PresidentRoll{
            get => presidentrolltxt.Text;
            set => presidentrolltxt.Text = value;
        }

        public string PresidentName{
            get => presidentnametxt.Text;
            set => presidentnametxt.Text = value;
        }

        public string SocietyLogo{
            get => pbLogo.Image.ToString();
            set => pbLogo.Image = Image.FromFile(value);
        }

        public Button button{
            get => approveSocietyBtn;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
