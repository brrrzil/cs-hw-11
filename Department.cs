using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Department
    {
        private static byte depID = 0;
        private string name;

        private ObservableCollection<Worker> dep = new ObservableCollection<Worker>();

        BindingList<Worker> workers = new BindingList<Worker>();

        public ObservableCollection<Worker> Dep { get { return dep; } set { dep = value; } }

        public Department(int ammount)
        {
            name = $"Отдел {depID}";
            depID++;

            for (int i = 0; i < ammount; i++)
            {
                dep.Add(new Worker());
            }
        }

        public override string ToString()
        {
            return this.name;
        }

        public ObservableCollection<Worker> WorkersList()
        {
            ObservableCollection<Worker> workersList = new ObservableCollection<Worker>();

            foreach (Worker worker in Dep)
            {
                workersList.Add(worker);
            }
            return workersList;
        }        

        public void AddNewWorker( string secondName, string firstName, string middleName, string passport, string phone)
        {
            dep.Add(new Worker(secondName, firstName, middleName, phone, passport));
        }
    }
}