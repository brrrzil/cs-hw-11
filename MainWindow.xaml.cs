using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HW10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        IWorkerEditor user = new User();

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();

            // Добавляем двух пользователей в ComboBox
            User.AddUser("Консультант");
            User.AddUser("Менеджер");
            UserBox.ItemsSource = User.GetUsers();

            //Создаём отделы
            Repository.Departments.Add(new Department(10));
            Repository.Departments.Add(new Department(11));
            Repository.Departments.Add(new Department(12));

            //Выводим список департаментов в DepartmentBox
            DepartmentBox.ItemsSource = Repository.Departments;

            //Делаем невидимой кнопки менеджера
            ShowManagertFields(Visibility.Hidden);
        }

        // По клику на департаменте выводим список сотрудников
        private void ShowDepartmentWorkers(object sender, SelectionChangedEventArgs e)
        {
            WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
        }

        // По клику на сотруднике выводим инфо в TextBox
        private void ShowWorkerInfo(object sender, MouseButtonEventArgs e)
        {
            if (WorkerGrid.SelectedIndex != -1)
            {
                Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                WorkerInfo.Text = user.WorkerToString(worker);
                Log.Text = worker.Log;
            }
        }

        // Присвоить пользователю роль (Консультант или Менеджер)
        private void AssignToUser(object sender, SelectionChangedEventArgs e)
        {
            switch (UserBox.SelectedValue.ToString())
            {
                case "Консультант":
                    user = new Consultant();
                    ShowManagertFields(Visibility.Hidden);
                    break;
                case "Менеджер":
                    user = new Manager();
                    ShowManagertFields(Visibility.Visible);
                    break;
            }
            //if (WorkerGrid.SelectedIndex != -1) { WorkerInfo.Text = user.WorkerToString(worker); }
        }

        #region Методы изменения данных
        private void SetSecondName(object sender, RoutedEventArgs e)
        {
            if (WorkerGrid.SelectedIndex != -1)
            {
                if (SecondNameField.Text != string.Empty)
                {
                    Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                    String secondName = SecondNameField.Text;
                    user.EditSecondName(worker, secondName);
                    WorkerInfo.Text = user.WorkerToString(worker);

                    string before = worker.SecondName;
                    DateTime date = DateTime.Now;
                    Log.Text = worker.ShowWorkerLog(date, "Фамилию", user, SecondNameField.Text);

                    WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
                    SecondNameField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetFirstName(object sender, RoutedEventArgs e)
        {
            if (WorkerGrid.SelectedIndex != -1)
            {
                if (FirstNameField.Text != string.Empty)
                {
                    Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                    String firstName = FirstNameField.Text;

                    user.EditFirstName(worker, firstName);
                    WorkerInfo.Text = user.WorkerToString(worker);

                    string before = worker.FirstName;
                    DateTime date = DateTime.Now;
                    Log.Text = worker.ShowWorkerLog(date, "Имя", user, FirstNameField.Text);

                    WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
                    FirstNameField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetMiddleName(object sender, RoutedEventArgs e)
        {
            if (WorkerGrid.SelectedIndex != -1)
            {
                if (MiddleNameField.Text != string.Empty)
                {
                    Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                    String middleName = MiddleNameField.Text;
                    user.EditMiddleName(worker, middleName);
                    WorkerInfo.Text = user.WorkerToString(worker);

                    string before = worker.MiddleName;
                    DateTime date = DateTime.Now;
                    Log.Text = worker.ShowWorkerLog(date, "Отчество", user, MiddleNameField.Text);

                    WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
                    MiddleNameField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetPhone(object sender, RoutedEventArgs e)
        {
            if (WorkerGrid.SelectedIndex != -1)
            {
                if (PhoneField.Text != string.Empty)
                {
                    Department department = Repository.Departments[WorkerGrid.SelectedIndex];
                    Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                    String phone = PhoneField.Text;
                    user.EditPhone(worker, phone);
                    WorkerInfo.Text = user.WorkerToString(worker);

                    string before = worker.Phone;
                    DateTime date = DateTime.Now;
                    Log.Text = worker.ShowWorkerLog(date, "Телефон", user, PhoneField.Text);

                    WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
                    PhoneField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }

        private void SetPassport(object sender, RoutedEventArgs e)
        {
            if (WorkerGrid.SelectedIndex != -1)
            {
                if (PassportField.Text != string.Empty)
                {
                    Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                    String passport = PassportField.Text;
                    user.EditPassport(worker, passport);
                    WorkerInfo.Text = user.WorkerToString(worker);

                    string before = worker.Passport;
                    DateTime date = DateTime.Now;
                    Log.Text = worker.ShowWorkerLog(date, "Данные паспорта", user, PassportField.Text);

                    WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
                    PassportField.Clear();
                }
                else MessageBox.Show("Поле не должно быть пустым");
            }
            else MessageBox.Show("Выберите клиента из списка");
        }
        #endregion

        private void OpenCreateWindow(object sender, RoutedEventArgs e)
        {
            new CreateNewWorker().ShowDialog();
        }

        private void DeleteWorker(object sender, RoutedEventArgs e)
        {
            string sMessageBoxText = "Удалить сотрудника?";
            string sCaption = "Предупреждение!";
            MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;
            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);
            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    Worker worker = Repository.Departments[DepartmentBox.SelectedIndex].Dep[WorkerGrid.SelectedIndex];
                    Repository.Departments[DepartmentBox.SelectedIndex].Dep.Remove(worker);
                    WorkerGrid.ItemsSource = Repository.Departments[DepartmentBox.SelectedIndex].WorkersList();
                    WorkerInfo.Text = "";                    
                    break;
            }            
        }

        private void ShowManagertFields(Visibility visibility)
        {
            OpenCreateWindowButton.Visibility = visibility;
            DeleteWorkerButton.Visibility = visibility;
            FirstNameField.Visibility = visibility;
            FirstNameOk.Visibility = visibility;
            SecondNameField.Visibility = visibility;
            SecondNameOk.Visibility = visibility;
            MiddleNameField.Visibility = visibility;
            MiddleNameOk.Visibility = visibility;
            PassportField.Visibility = visibility;
            PassportOk.Visibility = visibility;
        }
    }
}