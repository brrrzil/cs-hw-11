using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Worker
    {
        //private byte workerID = 0;
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

        public int number;
        private static int count = 0;

        public Worker()
        {
            number = ++count;
            SecondName = $"Фамилия {count}";
            FirstName = $"Имя {count}";
            MiddleName = $"Отчество {count}";
            Phone = GeneratePhone();
            Passport = GeneratePassport();

            date = DateTime.Now;
        }

        public Worker(string secondName, string firstName, string middleName, string phone, string passport)
        {
            number = ++count;
            SecondName = secondName;
            FirstName = firstName;
            MiddleName = middleName;
            Phone = phone;
            Passport = passport;

            date = DateTime.Now;
        }

        private string GeneratePhone()
        {
            string phone = "891";
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                phone += random.Next(0, 10);
            }
            return phone;
        }

        private string GeneratePassport()
        {
            string passport = "";
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                passport += random.Next(0, 10);
            }
            return passport;
        }

        public override string ToString()
        {
            return $"Сотрудник №{number}";
        }        

        public string ShowWorker(string firstName, string secondName, string middleName, string phone, string passport)
        {            
            return $"{secondName} \n{firstName} \n{middleName} \n\n{phone} \n\n{passport}";
        }

        public string ShowWorkerLog(DateTime date, string type, IWorkerEditor user, string before)
        {
            log = $"{date} \n{user.GetType()} \nИзменил {type} на: {before}";
            return log;
        }
    }
}