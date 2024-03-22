using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
using NU_Society_Link.View;

namespace NU_Society_Link.Presenter
{
    public class SocietyInformationPresenter
    {
        private SocietyInformationView view;
        private SocietyDBHandler societyDBHandler;

        private Society society;

        public SocietyInformationPresenter(SocietyInformationView view, string societyId)
        {
            societyDBHandler = new SocietyDBHandler();
            this.view = view;
            this.view.LoadPage += new EventHandler((sender, e) => LoadSocietyInformation(sender, e, societyId));
            this.view.ApproveSociety += new EventHandler((sender, e) => ApproveSociety(sender, e, societyId));
            //this.view.ClosePage += Reload;
            this.view.Show();
        }

        private void LoadSocietyInformation(object? sender, EventArgs e, string societyId)
        {
            int id = Convert.ToInt32(societyId);
            society = societyDBHandler.GetSociety(id);
            Debug.WriteLine("Society Information Loaded");

            this.view.updateInformation(society);
        }

        private void ApproveSociety(object? sender, EventArgs e, string societyId)
        {
            int id = Convert.ToInt32(societyId);
            Debug.WriteLine(societyId);
            societyDBHandler.ApproveSociety(id);
            Debug.WriteLine("Society Approved");
        }



    }
}
