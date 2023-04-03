using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HW10
{
    class User : IClientEditor, IShowClient
    {
        private static List<string> Users { get; set; } = new List<string>();
        private string userType = "Пользователь без прав";
        public string UserType { get { return userType; } set { userType = value; } }

        public User() { }

        public static void AddUser(string user) // Добавление пользователя
        {
            Users.Add(user);
        }

        public static List<string> GetUsers() // Геттер для списка Users
        {
            return Users;
        }

        public string ClientToString(Client client) // Метод вывода данных в строку
        {
            return $"{client.ShowClient("Фамилия скрыта", "Имя скрыто", "Отчество скрыто", "Телефон скрыт", "Паспорт скрыт")}";
        }

        #region Методы изменеия данных клиента
        public void EditFirstName(Client client, string clientFirstName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditSecondName(Client client, string clientSecondName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditMiddleName(Client client, string clientMiddleName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditPhone(Client client, string clientPhone) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditPassport(Client client, string clientPassport) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public string Log(Client client) { return ""; }
        #endregion
    }
}