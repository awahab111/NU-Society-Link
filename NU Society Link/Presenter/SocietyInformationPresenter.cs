using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;

namespace NU_Society_Link.Presenter
{
    public class SocietyInformationPresenter
    {
        private SocietyInformationView view;
        private SocietyDBHandler societyDBHandler;

        private Society society;

        public SocietyInformationPresenter(SocietyInformationView view, string societyId, int btnFunction)
        {
            societyDBHandler = new SocietyDBHandler();
            this.view = view;
            this.view.LoadPage += new EventHandler((sender, e) => LoadSocietyInformation(sender, e, societyId));
            if (btnFunction == 0){
                this.view.ApproveSociety += new EventHandler((sender, e) => ApproveSociety(sender, e, societyId));
                this.view.Readonly();
            }
            else if (btnFunction == 1){
                this.view.ApproveSociety += new EventHandler((sender, e) => UpdateSociety(sender, e, societyId));
                this.view.button.Text = "Update";
            }
            else{
                this.view.Readonly();
                this.view.button.Hide();    
            }
            this.view.ClosePage += (sender, e) => SocietyInformationView.GetInstance(view).Delete();
            this.view.Show();
        }

        private void UpdateSociety(object? sender, EventArgs e, string societyId)
        {
            int id = Convert.ToInt32(societyId);
            Debug.WriteLine(societyId);
            societyDBHandler.UpdateSociety(id, view.SocietyName, view.PresidentRoll, view.SocietyDescription, 
                        view.SocietyType, view.SocietySupervisor, view.SocietySupervisorEmail);
            Debug.WriteLine("Society Updsted");
        }

        private void LoadSocietyInformation(object? sender, EventArgs e, string societyId)
        {
            int id = Convert.ToInt32(societyId);
            society = societyDBHandler.GetSociety(id);
            Debug.WriteLine("Society Information Loaded");

            StudentsDBHandler studentsDBHandler = new StudentsDBHandler();
            Student student = studentsDBHandler.GetStudent(society.President);


            this.view.updateInformation(society, student);
        }

        private void ApproveSociety(object? sender, EventArgs e, string societyId)
        {
            int id = Convert.ToInt32(societyId);
            Debug.WriteLine(societyId);
            societyDBHandler.ApproveSociety(id);

            societyDBHandler.UpdateSociety(id, view.SocietyName, view.PresidentRoll, view.SocietyDescription, 
                        view.SocietyType, view.SocietySupervisor, view.SocietySupervisorEmail);

            SocietyMembersDBHandler societyMembersDBHandler = new SocietyMembersDBHandler();
            societyMembersDBHandler.AddMember("President", view.PresidentRoll, id);

            Debug.WriteLine("Society Approved");
        }



    }
}
