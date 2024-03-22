using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;
using System.Diagnostics;

namespace NU_Society_Link.Presenter
{
    public class ApproveSocietyPresenter
    {
        private ApproveSocietyView view;

        private AdminMainView parentView;

        private SocietyDBHandler SocietyDBHandler;

        public ApproveSocietyPresenter(ApproveSocietyView view, AdminMainView parentView)
        {
            SocietyDBHandler = new SocietyDBHandler();
            this.view = view;
            this.parentView = parentView;
            this.view.ListViewClick += InfoView;
            getSocieties();
            this.view.Show();
        }

        private void InfoView(object sender, EventArgs e)
        {
            // Get the selected item
            string selectedSocietyId = view.getSelectedItem();
            if (selectedSocietyId == null)
            {
                return;
            }
            Debug.WriteLine(selectedSocietyId + " is selected.");

            // Open the society information screen passing the society name and supervisor name
            SocietyInformationView societyInformationView = SocietyInformationView.GetInstance((Form)parentView);
            SocietyInformationPresenter s = new SocietyInformationPresenter(societyInformationView, selectedSocietyId);
            societyInformationView.Show();
        }

        private void getSocieties()
        {
            // Get the societies from the database
            List<Society> societies = SocietyDBHandler.GetSocieties();
            view.getSocieties(societies);
        }



    }
}
