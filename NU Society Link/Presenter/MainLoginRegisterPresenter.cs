using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Presenter;
using NU_Society_Link.DBHandlers;

namespace NU_Society_Link.Presenter
{
    internal class MainLoginRegisterPresenter
    {
        private MainLoginRegister view;
        private UserRegisterView registerView;
        private UserLoginView loginView;
        private UserDBHandler userDBHandler;
        private UserPresenter userPresenter;
        private UserRegisterPresenter userRegisterPresenter;

        public MainLoginRegisterPresenter(MainLoginRegister view)
        {
            this.view = view;
            this.userDBHandler = new UserDBHandler();
            loginView = UserLoginView.GetInstance((Form)view);
            userPresenter = new UserPresenter(loginView, this.userDBHandler);
            userPresenter.LoginSuccess += ShowMainView;
            ShowLogin(null, EventArgs.Empty);
        }

        private void ShowMainView(object? sender, EventArgs e)
        {
            MainView mainView = new MainView();
            MainPresenter mainPresenter = new MainPresenter(mainView); // Use the appropriate constructor for MainPresenter
            mainView.Show();
            this.view.Hide();
        }
        public void ShowLogin(object? sender, EventArgs e)
        {
            loginView = UserLoginView.GetInstance((Form)view);
            userPresenter = userPresenter ?? new UserPresenter(loginView, this.userDBHandler);
            this.loginView.Register += ShowRegister;
        }

        public void ShowRegister(object? sender, EventArgs e)
        {
            registerView = UserRegisterView.GetInstance((Form)view);
            userRegisterPresenter = userRegisterPresenter ?? new UserRegisterPresenter(registerView, this.userDBHandler);
            this.registerView.Login += ShowLogin;
        }
        

    }
}
