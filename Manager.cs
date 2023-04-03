using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Manager : Consultant, IClientEditor, IShowClient
    {
        public Manager()
        {

        }

        public string ClientToString(Client client)
        {
            return $"{client.ShowClient(client.FirstName, client.SecondName, client.MiddleName, client.Phone, client.Passport)}";
        }

        #region Методы изменений для Менеджера
        public void EditFirstName(Client client, string clientFirstName)
        {
            client.FirstName = clientFirstName;
        }

        public void EditSecondName(Client client, string clientSecondName)
        {
            client.SecondName = clientSecondName;
        }

        public void EditMiddleName(Client client, string clientMiddleName)
        {
            client.MiddleName = clientMiddleName;
        }

        public void EditPhone(Client client, string clientPhone)
        {
            client.Phone = clientPhone;
        }

        public void EditPassport(Client client, string clientPassport)
        {
            client.Passport = clientPassport;
        }

        public string Log(Client client)
        {
            return "";
        }
        #endregion

    }
}