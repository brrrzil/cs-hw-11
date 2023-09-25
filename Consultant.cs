using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW10
{
    internal class Consultant : User, IWorkerEditor, IShowWorker
    {
        public Consultant()
        {
            
        }

        public string WorkerToString(Worker worker)
        {
            string firstName = worker.FirstName;
            string secondName = worker.SecondName;
            string middleName = worker.MiddleName;
            string phone = worker.Phone;
            string passport = "";

            for (int i = 0; i < worker.Passport.Length; i++)
            {
                passport += "*";
            }

            return $"{worker.ShowWorker(firstName, secondName, middleName, phone, passport)}";            
        }

        #region Методы изменений для Консультанта

        public void EditFirstName(Worker worker, string workerFirstName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditSecondName(Worker worker, string workerSecondName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditMiddleName(Worker worker, string workerMiddleName) { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public void EditPhone(Worker worker, string workerPhone) { worker.Phone = workerPhone; }

        public void EditPassport() { MessageBox.Show("Недостаточно прав для редактирования этого поля"); }

        public string Log(Worker worker) { return ""; }
        #endregion
    }
}