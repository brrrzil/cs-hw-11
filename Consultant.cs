using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW10
{
    internal class Consultant : User, IClientEditor, IShowClient
    {
        public Consultant()
        {

        }

        public string ClientToString(Client client)
        {
            string firstName = client.FirstName;
            string secondName = client.SecondName;
            string middleName = client.MiddleName;
            string phone = client.Phone;
            string passport = "";

            for (int i = 0; i < client.Passport.Length; i++)
            {
                passport += "*";
            }

            return $"{client.ShowClient(firstName, secondName, middleName, phone, passport)}";            
        }

        #region Методы изменений для Консультанта

        public void EditFirstName(Client client, string clientFirstName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditSecondName(Client client, string clientSecondName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditMiddleName(Client client, string clientMiddleName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditPhone(Client client, string clientPhone)
        {
            client.Phone = clientPhone;
        }

        public void EditPassport() { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public string Log(Client client)
        {
            return "";
        }


        #endregion
    }
}