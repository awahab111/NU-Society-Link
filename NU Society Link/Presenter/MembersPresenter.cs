using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;
using System.Data;
using System.Diagnostics;

namespace NU_Society_Link.Presenter
{
    public class MembersPresenter
    {
        private MembersView view;

        SocietyMembersDBHandler societyMembersDBHandler;

        
        private User user;

        public MembersPresenter(MembersView view, User u)
        {
            this.view = view;
            this.user = u;
            societyMembersDBHandler = new SocietyMembersDBHandler();
            
            this.view.SearchMembers += SearchMembers;
            this.view.AddMember += AddNewMember;
            this.view.Show();
            this.view.BringToFront();
            PopulateDataGridView();
        }

        private void AddNewMember(object? sender, EventArgs e)
        {
            Debug.WriteLine("Add Member Clicked");
            SocietyMember member = societyMembersDBHandler.GetMember((user.Id).ToString());
            if(member.MemberPosition == "President")
            {
                view.SetWarning = "BABOOOFA";
                AddMemberView addMemberView = new AddMemberView();
                AddMemberPresenter addMemberPresenter = new AddMemberPresenter(addMemberView);
                addMemberView.Show();
            }
            else
            {
                view.SetWarning = "WARNING: You are not the president of this society. You cannot add members.";
            }

            
        }

        private void SearchMembers(object? sender, EventArgs e)
        {
            Debug.WriteLine("Search Members Clicked");
            string search = this.view.SearchQuery.ToString();
            List<SocietyMember> members = GetSocietyMembers();

            DataTable membersDataTable = new DataTable();
            membersDataTable.Columns.Add("Roll Number");
            membersDataTable.Columns.Add("Member Name");
            membersDataTable.Columns.Add("Member Position");
            membersDataTable.Columns.Add("Member Batch");

            foreach (SocietyMember member in members)
            {
                if (member.RollNum.Contains(search) || member.MemberName.Contains(search) || member.MemberPosition.Contains(search) || member.MemberBatch.Contains(search))
                {
                    membersDataTable.Rows.Add(member.RollNum, member.MemberName, member.MemberPosition, member.MemberBatch);
                }
            }
            view.PopulateGridView(membersDataTable);

        }

        private List<SocietyMember> GetSocietyMembers()
        {
            List<SocietyMember> members = societyMembersDBHandler.GetMembers();
            return members;
        }

        private void PopulateDataGridView()
        {
            List<SocietyMember> members = GetSocietyMembers();
            DataTable membersDataTable = new DataTable();
            membersDataTable.Columns.Add("Roll Number");
            membersDataTable.Columns.Add("Member Name");
            membersDataTable.Columns.Add("Member Position");
            membersDataTable.Columns.Add("Member Batch");

            foreach (SocietyMember member in members)
            {
                membersDataTable.Rows.Add(member.RollNum ,member.MemberName, member.MemberPosition, member.MemberBatch);
            }

            view.PopulateGridView(membersDataTable);
        }

        internal void Dispose()
        {
            view.Dispose();
        }
    }
}
