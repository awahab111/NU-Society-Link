using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;

namespace NU_Society_Link.Presenter
{
    public class MainPresenter
    {
        private MainView view;
        private AddSocietyPresenter addSocietyPresenter;

        public MainPresenter(MainView view)
        {
            this.view = view;
            this.view.AddSociety += AddSociety;
            this.view.Show();
        }

        public void AddSociety(object? sender, EventArgs e){
            Debug.WriteLine("Add Society Clicked");
            AddSocietyView addSocietyView = AddSocietyView.GetInstance(view);
            addSocietyPresenter = addSocietyPresenter ?? new AddSocietyPresenter(addSocietyView); // Assign the variable
            addSocietyView.Show();
        }
    }
}
