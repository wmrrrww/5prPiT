using System;
using System.Windows;

namespace _5prPiT
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow mainWindow = new MainWindow();
            AuthPage authPage = new AuthPage();
            mainWindow.Content = authPage;
            mainWindow.Show();
        }
    }
}
