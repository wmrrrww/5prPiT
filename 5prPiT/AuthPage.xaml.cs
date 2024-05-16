using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

using _5prPiT;

namespace _5prPiT
{
    public partial class AuthPage : Page
    {
        private int attempts = 0;

        public AuthPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            attempts++;
            if (attempts >= 3)
            {
                ShowCaptcha();
            }
            else
            {
                Auth(usernameTextBox.Text, passwordBox.Password);
            }
        }

        private void ShowCaptcha()
        {
            MessageBox.Show("Введите символы с картинки!");
        }

        private bool ValidateCaptcha(string captchaInput)
        {
            return captchaInput == "капча_здесь";
        }

        public bool Auth(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }

            using (var db = new Pr5_PiTEntities())
            {
                var user = db.User
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == login && u.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return false;
                }
                MessageBox.Show("Пользователь успешно найден!");
                usernameTextBox.Clear();
                passwordBox.Clear();
                return true;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegPage regPage = new RegPage();
            NavigationService.Navigate(regPage);
        }
    }
}
