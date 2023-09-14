using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    interface IWorkerEditor
    {
        string WorkerToString(Worker worker);

        void EditFirstName(Worker worker, string workerFirstName);

        void EditSecondName(Worker worker, string workerSecondName);

        void EditMiddleName(Worker worker, string workerMiddleName);

        void EditPhone(Worker worker, string workerPhone);

        void EditPassport(Worker worker, string workerPassport);

        string Log(Worker worker);
    }
}
