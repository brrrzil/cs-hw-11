using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace HW10
{
    internal class Repository
    {
        private static ObservableCollection<Department> departments = new ObservableCollection<Department>();
        public static ObservableCollection<Department> Departments { get { return departments; } set { value = departments; } }
    }
}