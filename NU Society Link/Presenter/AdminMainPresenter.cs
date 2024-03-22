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
    public class AdminMainPresenter
    {
        private AdminMainView view;
        private SocietyDBHandler societyDBHandler;

        private ApproveSocietyPresenter approveSocietyPresenter;

        public AdminMainPresenter(AdminMainView view)
        {
            societyDBHandler = new SocietyDBHandler();
            this.view = view;
            this.view.ApproveSocietyClick += ShowApproveSociety;
            this.view.Show();
        }


        private void ShowApproveSociety(object? sender, EventArgs e)
        {
            ApproveSocietyView approveSocietyView = ApproveSocietyView.GetInstance((Form)view);
            approveSocietyPresenter = approveSocietyPresenter ?? new ApproveSocietyPresenter(approveSocietyView, view);
            approveSocietyView.Show();
        }


    }
}
