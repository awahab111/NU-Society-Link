using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;

namespace NU_Society_Link.Presenter
{
    public class AddMemberPresenter
    {
        AddMemberView view;
        
        SocietyMembersDBHandler societyMembersDBHandler;

        public AddMemberPresenter(AddMemberView view)
        {
            this.view = view;
            societyMembersDBHandler = new SocietyMembersDBHandler();
            this.view.AddMember += AddMember;
            this.view.Show();
        }

        private void AddMember(object? sender, EventArgs e)
        {
            string memberName = view.GetMemberName;
            string memberEmail = view.GetMemberEmail;
            string memberPhone = view.GetMemberPhone;
            string memberPosition = view.GetMemberPosition;
            string memberBatch = view.GetMemberBatch;
            string rollNum = view.GetRollNum;
            string societyName = view.GetSocietyName;

            societyMembersDBHandler.AddMember(memberName, memberEmail, memberPhone, memberPosition, memberBatch, rollNum, societyName);
        }
    }
}
