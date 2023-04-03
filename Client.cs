using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Client
    {
        private string firstName = "";
        private string secondName = "";
        private string middleName = "";
        private string phone = "";
        private string passport = "";

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Passport { get { return passport; } set { this.passport = value.Length > 6 ? value.Substring(0, 6) : value; } }

        private DateTime date = DateTime.Now;
        private string userType = "";
        private string before = "";
        private string log = "";

        public DateTime Date { get { return date; } set { date = value; } }
        public string Before { get { return before; } set { before = value; } }
        public string UserType { get { return userType; } set { userType = value; } }
        public string Log { get { return log; } set { log = value; } }

        private int number;
        private static int count = 0;

        public Client()
        {
            number = ++count;
            SecondName = $"Фами{count}лия";
            FirstName = $"И{count}мя";
            MiddleName = $"Отче{count}ство";
            Phone = $"Теле{count}фон";
            Passport = $"Пас{count}порт";

            date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Клиент №{number}";
        }

        public string ShowClient(string firstName, string secondName, string middleName, string phone, string passport)
        {            
            return $"{secondName} \n{firstName} \n{middleName} \n\n{phone} \n\n{passport}";
        }

        public string ShowClientLog(DateTime date, string type, IClientEditor user, string before)
        {
            log = $"{date} \n{user.GetType()} \nИзменил {type} на: {before}";
            return log;
        }
    }
}