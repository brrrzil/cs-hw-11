using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HW10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IClientEditor user = new User();

        public MainWindow()
        {
            InitializeComponent();

            // Добавляем двух пользователей в ComboBox
            User.AddUser("Консультант");
            User.AddUser("Менеджер");
            UserBox.ItemsSource = User.GetUsers();

            // Заполняем репозиторий случайным количеством клиентов
            Repository.FillRepository();

            // Выводим список клиентов в ListBox
            ClientList.ItemsSource = Repository.clients;

            //userTest.Text = user.GetType().ToString();
        }

        // По клику на клиенте выводим инфо в TextBox
        private void ShowClientInfo(object sender, MouseButtonEventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                ClientInfo.Text = user.ClientToString(Repository.clients[ClientList.SelectedIndex]);
                Log.Text = Repository.clients[ClientList.SelectedIndex].Log;
            }
        }

        // Присвоить пользователю роль (Консультант или Менеджер)
        private void AssignToUser(object sender, SelectionChangedEventArgs e)
        {
            switch (UserBox.SelectedValue.ToString())
            {
                case "Консультант":
                    user = new Consultant();
                    if (ClientList.SelectedIndex != -1) {ClientInfo.Text = user.ClientToString(Repository.clients[ClientList.SelectedIndex]);}
                    break;
                case "Менеджер":
                    user = new Manager();
                    if (ClientList.SelectedIndex != -1) { ClientInfo.Text = user.ClientToString(Repository.clients[ClientList.SelectedIndex]); }
                    break;
            }
        }

        #region Методы изменения данных
        private void SetSecondName(object sender, RoutedEventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                if (SecondNameField.Text != string.Empty)
                {
                    Client client = Repository.clients[ClientList.SelectedIndex];
                    String secondName = SecondNameField.Text;
                    user.EditSecondName(client, secondName);
                    ClientInfo.Text = user.ClientToString(client);

                    string before = client.SecondName;
                    DateTime date = DateTime.Now;
                    Log.Text = client.ShowClientLog(date, "Фамилию", user, SecondNameField.Text);

                    SecondNameField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetFirstName(object sender, RoutedEventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                if (FirstNameField.Text != string.Empty)
                {
                    Client client = Repository.clients[ClientList.SelectedIndex];
                    String firstName = FirstNameField.Text;

                    user.EditFirstName(client, firstName);
                    ClientInfo.Text = user.ClientToString(client);

                    string before = client.FirstName;
                    DateTime date = DateTime.Now;
                    Log.Text = client.ShowClientLog(date, "Имя", user, FirstNameField.Text);

                    FirstNameField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetMiddleName(object sender, RoutedEventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                if (MiddleNameField.Text != string.Empty)
                {
                    Client client = Repository.clients[ClientList.SelectedIndex];
                    String middleName = MiddleNameField.Text;
                    user.EditMiddleName(client, middleName);
                    ClientInfo.Text = user.ClientToString(client);

                    string before = client.MiddleName;
                    DateTime date = DateTime.Now;
                    Log.Text = client.ShowClientLog(date, "Отчество", user, MiddleNameField.Text);

                    MiddleNameField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetPhone(object sender, RoutedEventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                if (PhoneField.Text != string.Empty)
                {
                    Client client = Repository.clients[ClientList.SelectedIndex];
                    String phone = PhoneField.Text;
                    user.EditPhone(client, phone);
                    ClientInfo.Text = user.ClientToString(client);

                    string before = client.Phone;
                    DateTime date = DateTime.Now;
                    Log.Text = client.ShowClientLog(date, "Телефон", user, PhoneField.Text);

                    PhoneField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetPassport(object sender, RoutedEventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                if (PassportField.Text != string.Empty)
                {
                    Client client = Repository.clients[ClientList.SelectedIndex];
                    String passport = PassportField.Text;
                    user.EditPassport(client, passport);
                    ClientInfo.Text = user.ClientToString(client);

                    string before = client.Passport;
                    DateTime date = DateTime.Now;
                    Log.Text = client.ShowClientLog(date, "Данные паспорта", user, PassportField.Text);

                    PassportField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }
        #endregion
    }
}