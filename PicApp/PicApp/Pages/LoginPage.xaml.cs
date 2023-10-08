using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private string _password;
        public LoginPage()
        {
            InitializeComponent();
            _password = Preferences.Get("Password", String.Empty);
            if (_password != string.Empty)
            {
                lPin.Text = "Введите пин-код для входа:";
            }
        }

        private void endPwdButton_Click(object sender, EventArgs e)
        {
            string enterPwd = Password.Text;
            if (_password == string.Empty)
            {
                Preferences.Set("Password", enterPwd);
            }
            else
            {
                if (_password != Password.Text)
                {
                    lInfoMsg.Text = "Неверный ПИН-код";
                    return;
                }
            }

            Navigation.PushAsync(new GalleryPage());
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Password.Text.Length != 4)
            {
                lInfoMsg.Text = "ПИН-код должен состоять из 4 символов";
                endPwdButton.IsEnabled = false;
            }
            else
            {
                endPwdButton.IsEnabled = true;
                lInfoMsg.Text = string.Empty;
            }
        }
    }
}