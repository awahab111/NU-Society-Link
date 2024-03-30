using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;

namespace NU_Society_Link.Presenter
{
    public class AddMemberPresenter
    {
        AddMemberView view;
        
        SocietyMembersDBHandler societyMembersDBHandler;

        SocietyMember member;

        public AddMemberPresenter(AddMemberView view, SocietyMember m)
        {
            this.member = m;
            this.view = view;
            societyMembersDBHandler = new SocietyMembersDBHandler();
            this.view.AddMember += AddMember;
            this.view.Show();
        }

        private void AddMember(object? sender, EventArgs e)
        {
            string memberPosition = view.GetMemberPosition;
            string rollNum = view.GetRollNum;

            if (!string.IsNullOrEmpty(memberPosition) && !string.IsNullOrEmpty(rollNum))
            {
                var flag = societyMembersDBHandler.AddMember(memberPosition, rollNum, this.member.SocietyId);
                if (flag)
                {
                    view.Flag.ForeColor = System.Drawing.Color.Green;
                    view.Flag.Text = "Member Added Successfully";
                }
                else
                {
                    view.Flag.ForeColor = System.Drawing.Color.Red;
                    view.flag = "An Error Occurred. Please try again.";
                }
            }
        }
    }
}
