using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _5prPiT
{
    public partial class AuthPage : Window
    {
        private static AuthPage _context;

        public AuthPage()
        {
            InitializeComponent();
            _context = this;
        }

        public static AuthPage GetContext()
        {
            if (_context == null)
                _context = new AuthPage();
            return _context;
        }

        private void EntrButton_Click(object sender, RoutedEventArgs e)
        {
            Auth(LoginTextBox.Text, PasswordTextBox.Password);
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
                var user = db.User.AsNoTracking().FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден");
                    return false;
                }

                MessageBox.Show("Пользователь успешно найден!");
                LoginTextBox.Clear();
                PasswordTextBox.Clear();
                return true;
            }
        }



        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            using (var db = new Pr5_PiTEntities())
            {
                var user = db.User.FirstOrDefault(u => u.Login == LoginTextBox.Text && u.Password == PasswordTextBox.Password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден");
                    return;
                }


                MessageBox.Show($"Здравствуйте, {user.Role} {user.FIO}!");
            }
        }
    }
}
