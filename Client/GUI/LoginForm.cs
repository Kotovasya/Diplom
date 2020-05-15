using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUI
{
    public partial class LoginForm : Form
    {
        private const string LoginShortError = "Имя пользователя должно иметь длину не менее 4 символов";
        private const string LoginSymbolError = "Имя пользователя может состоять только из букв, цифр или символа '_'";
        private const string WrongLoginError = "Пользователь с таким именем не зарегистрирован";
        private const string LoginAlreadyUseError = "Пользователь с таким именем уже зарегистрирован";

        private const string PasswordShortError = "Пароль должен иметь длину не менее 4 символов";
        private const string WrongPasswordError = "Неверный пароль";

        private const string ServerError = "На сервере произошла ошибка, попробуйте позже";

        private readonly ClientModel Model;

        public LoginForm(ClientModel model)
        {
            InitializeComponent();
            Model = model;
            FormDock.SubscribeControlToDragEvents(GradientPanel);
            FormDock.SubscribeControlToDragEvents(LoginPage);
            FormDock.SubscribeControlToDragEvents(RegistrationPage);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void PasswordTextbox_TextChange(object sender, EventArgs e)
        {
            if (PasswordTextbox.TextLength > 0)
                PasswordTextbox.UseSystemPasswordChar = true;
            else
                PasswordTextbox.UseSystemPasswordChar = false;
        }

        private async void LoginPageButton_Click(object sender, EventArgs e)
        {
            if (!CheckValidation(LoginTextbox.Text, PasswordTextbox.Text))
                return;

            try
            {
                AuthorizationRequest request = new AuthorizationRequest() { Id = Model.Id, Login = LoginTextbox.Text, Password = PasswordTextbox.Text };
                AuthorizationResponse response = await Model.Service.AuthorizationAsync(request);
                if (response.Result == AuthorizationResponseId.WrongLogin)
                    ShowLoginError(WrongLoginError);
                else if (response.Result == AuthorizationResponseId.WrongPassword)
                    ShowPasswordError(WrongPasswordError);
                else if (response.Result == AuthorizationResponseId.ServerException)
                    ShowServerError();
                Model.Id = response.Id;
                // Make successfully authorization 
            }
            catch
            {
                ShowServerError();
            }
        }

        private async void RegistrationPageButton_Click(object sender, EventArgs e)
        {
            if (!CheckValidation(RegistrationLoginTextbox.Text, RegistrationPasswordTextbox.Text))
                return;

            try
            {
                RegistrationRequest request = new RegistrationRequest() { Id = Model.Id, Login = RegistrationLoginTextbox.Text, Password = RegistrationPasswordTextbox.Text };
                RegistrationResponse response = await Model.Service.RegistrationAsync(request);
                if (response.Result == AuthorizationResponseId.AlreadyRegister)
                    ShowLoginError(LoginAlreadyUseError);
                else if (response.Result == AuthorizationResponseId.ServerException)
                    ShowServerError();
                Model.Id = response.Id;
                // Make successfully registration
            }
            catch
            {
                ShowServerError();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool CheckValidation(string login, string password)
        {
            string error = CheckLoginValidation(login);
            if (error != string.Empty)
            {
                ShowLoginError(error);
                return false;
            }
            error = CheckPasswordValidation(password);
            if (error != string.Empty)
            {
                ShowPasswordError(error);
                return false;
            }
            return true;
        }

        private string CheckLoginValidation(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return LoginShortError;

            if (login.Length < 4)
                return LoginShortError;

            if (login.All(c => char.IsDigit(c) || char.IsLetter(c) || c == '_'))
                return String.Empty;

            return LoginSymbolError;
        }

        private string CheckPasswordValidation(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return PasswordShortError;

            if (password.Length < 4)
                return PasswordShortError;

            return String.Empty;
        }

        private void ShowLoginError(string error)
        {
            LoginTextbox.BorderColorIdle = Color.Red;
            LoginErrorLabel.Text = error;
            LoginErrorLabel.Visible = true;
        }

        private void ShowPasswordError(string error)
        {
            PasswordTextbox.BorderColorIdle = Color.Red;
            PasswordErrorLabel.Text = error;
            PasswordErrorLabel.Visible = true;
        }

        private void ShowServerError()
        {
            ServerErrorLabel.Text = ServerError;
            ServerErrorLabel.Visible = true;
        }

        private void Textbox_Click(object sender, EventArgs e)
        {
            LoginTextbox.BorderColorIdle = Color.CornflowerBlue;
            LoginErrorLabel.Visible = false;

            PasswordTextbox.BorderColorIdle = Color.CornflowerBlue;
            PasswordErrorLabel.Visible = false;

            ServerErrorLabel.Visible = false;

            RegistrationLoginTextbox.BorderColorIdle = Color.CornflowerBlue;
            RegistrationLoginErrorLabel.Visible = false;

            RegistrationPasswordTextbox.BorderColorIdle = Color.CornflowerBlue;
            RegistrationPasswordErrorLabel.Visible = false;

            RegistrationServerErrorLabel.Visible = false;
        }
    }
}
