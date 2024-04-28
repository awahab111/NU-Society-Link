using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class MainWelcomePage : Form
    {
        public event EventHandler ClearNotifications;
        public event EventHandler SocietyInfo;

        private MainWelcomePage()
        {
            InitializeComponent();
            btnNotifications.Click += (sender, e) => ClearNotifications?.Invoke(this, e);
            Societybtn.Click += (sender, e) => SocietyInfo?.Invoke(this, e);

        }

        private static MainWelcomePage instance;

        public static MainWelcomePage GetInstance(Form view){
            if(instance == null){
                instance = new MainWelcomePage();
                instance.MdiParent = view;
                instance.Dock = DockStyle.Fill;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Show();
            }
            return instance;
        }

        public void Delete(){
            instance = null;
            this.Dispose();
        }

        public string lblGreetingText{
            get => lblGreeting.Text;
            set => lblGreeting.Text = value;
        }

        public string lblPersonalInfoText{
            get => lblPersonalInfo.Text;
            set => lblPersonalInfo.Text = value;
        }

        public string lblNameText{
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string lblEmailText{
            get => lblEmail.Text;
            set => lblEmail.Text = value;
        }

        public string lblPhoneText{
            get => lblPhone.Text;
            set => lblPhone.Text = value;
        }

        public string lblBatchText{
            get => lblBatch.Text;
            set => lblBatch.Text = value;
        }

        public ListView NotificationsListView{
            get => listViewNotifications;
        }
        
        public string societyInfoText{
            get => lblSocietyInfo.Text;
            set => lblSocietyInfo.Text = value;
        }

        public Button btnUpdateSociety{
            get => Societybtn;
        }

    }

}
