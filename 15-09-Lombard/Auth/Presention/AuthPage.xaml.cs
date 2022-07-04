using _15_09_Lombard.Auth.Domain.Models;
using _15_09_Lombard.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _15_09_Lombard.Auth.Presention
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            ConnectOdb connectOdb = new ConnectOdb();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            login.Text = null;
            password.Text = null;
        }

        public static bool Auth(string login, string password)
        {
            Employee employee = new Employee();

            employee.login = login;
            employee.password = password;

            if ((login != "") || (password != ""))
            {
                var empl =ConnectOdb.GetContext().Employees.ToList().Find(l => l.login == employee.login);

                if (empl != null)
                {
                    if (employee.password == empl.password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введите данные");
                return false;
            }
        }

        private void auth_button_Click(object sender, RoutedEventArgs e)
        {
            if(Auth(login.Text, password.Text))
            {
                MessageBox.Show("Успешный вход");
            }
        }
    }
}
