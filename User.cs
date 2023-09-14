using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HW10
{
    class User : IWorkerEditor, IShowWorker
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

        public string WorkerToString(Worker worker) // Метод вывода данных в строку
        {
            return $"{worker.ShowWorker("Фамилия скрыта", "Имя скрыто", "Отчество скрыто", "Телефон скрыт", "Паспорт скрыт")}";
        }

        #region Методы изменеия данных клиента
        public void EditFirstName(Worker worker, string workerFirstName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditSecondName(Worker worker, string workerSecondName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditMiddleName(Worker worker, string workerMiddleName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditPhone(Worker worker, string workerPhone) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditPassport(Worker worker, string workerPassport) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public string Log(Worker worker) { return ""; }
        #endregion
    }
}