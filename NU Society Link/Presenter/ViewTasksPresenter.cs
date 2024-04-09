using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;


namespace NU_Society_Link.Presenter
{
    public class ViewTasksPresenter
    {
        private ViewTasksView view;

        private User user;  
        public ViewTasksPresenter(ViewTasksView view, User u)
        {
            this.view = view;
            this.view.Show();
            this.user = u;
        }


        internal void Dispose()
        {
            view.Dispose();
        }




    }
}
