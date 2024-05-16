using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _5prPiT
{
    /// <summary>
    /// Логика взаимодействия для PegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        public bool Register(string fio, string login, string password, string role)
        {
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите все обязательные поля!");
                return false;
            }

            using (var db = new Pr5_PiTEntities())
            {
                var userObject = new User
                {
                    FIO = fio,
                    Login = login,
                    Password = password,
                    Role = role
                };
                db.User.Add(userObject);
                db.SaveChanges();
            }

            MessageBox.Show("Пользователь успешно зарегистрирован!");
            return true;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (Register(TextBoxFIO.Text, TextBoxLogin.Text, PasswordBox.Password, ComboBoxRole.Text))
            {
                ClearFields();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            ClearFields();
        }

        private void ClearFields()
        {
            TextBoxFIO.Text = "";
            TextBoxLogin.Text = "";
            PasswordBox.Password = "";
            ComboBoxRole.SelectedIndex = -1;
        }
    }
}
    
