using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HW10
{
    /// <summary>
    /// Interaction logic for CreateNewWorker.xaml
    /// </summary>
    public partial class CreateNewWorker : Window
    {
        private static int i = 0;

        public CreateNewWorker()
        {
            InitializeComponent();
            CreateInDepartmentBox.ItemsSource = Repository.Departments;
        }

        private void CreateButton(object sender, RoutedEventArgs e)
        {
            Department department = Repository.Departments[i];

            if (CreateFirstNameField.Text != string.Empty &&
                CreateSecondNameField.Text != string.Empty &&
                CreateMiddleNameField.Text != string.Empty &&
                CreatePhoneField.Text != string.Empty &&
                CreatePassportField.Text != string.Empty &&
                CreateInDepartmentBox.SelectedIndex != -1)
            {
                string secondName = CreateSecondNameField.Text;
                string firstName = CreateFirstNameField.Text;
                string middleName = CreateMiddleNameField.Text;
                string phone = CreatePhoneField.Text;
                string passport = CreatePassportField.Text;
                department.AddNewWorker(secondName, firstName, middleName, phone, passport);

                MessageBox.Show($"Сотрудник успешно добавлен в {department.ToString()}");

                CreateFirstNameField.Clear();
                CreateSecondNameField.Clear();
                CreateMiddleNameField.Clear();
                CreatePhoneField.Clear();
                CreatePassportField.Clear();
            }
            else MessageBox.Show("Пожалуйста, выберите департамент и заполните все поля");
        }

        private void CreateInDepartmentButton(object sender, SelectionChangedEventArgs e)
        {
            if (CreateInDepartmentBox.SelectedIndex != -1)
            {
                 i = CreateInDepartmentBox.SelectedIndex;
            }
        }
    }
}