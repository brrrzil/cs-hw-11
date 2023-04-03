using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    interface IClientEditor
    {
        string ClientToString(Client client);

        void EditFirstName(Client client, string clientFirstName);

        void EditSecondName(Client client, string clientSecondName);

        void EditMiddleName(Client client, string clientMiddleName);

        void EditPhone(Client client, string clientPhone);

        void EditPassport(Client client, string clientPassport);

        string Log(Client client);
    }
}
