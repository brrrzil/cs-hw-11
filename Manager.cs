using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Manager : Consultant, IWorkerEditor, IShowWorker
    {
        public Manager()
        {
            
        }

        public string WorkerToString(Worker worker)
        {
            return $"{worker.ShowWorker(worker.FirstName, worker.SecondName, worker.MiddleName, worker.Phone, worker.Passport)}";
        }

        #region Методы изменений для Менеджера
        public void EditFirstName(Worker worker, string workerFirstName)
        {
            worker.FirstName = workerFirstName;
        }

        public void EditSecondName(Worker worker, string workerSecondName)
        {
            worker.SecondName = workerSecondName;
        }

        public void EditMiddleName(Worker worker, string workerMiddleName)
        {
            worker.MiddleName = workerMiddleName;
        }

        public void EditPhone(Worker worker, string workerPhone)
        {
            worker.Phone = workerPhone;
        }

        public void EditPassport(Worker worker, string workerPassport)
        {
            worker.Passport = workerPassport;
        }

        public string Log(Worker worker)
        {
            return "";
        }
        #endregion

    }
}