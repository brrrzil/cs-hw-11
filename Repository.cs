using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace HW10
{
    internal class Repository
    {
        public static ObservableCollection<Client> clients = new ObservableCollection<Client>();

        static string json = String.Empty;

        static Random random = new Random();       

        public static void FillRepository()
        {
            int n = random.Next(12, 16);
            for (int i = 0; i < n; i++)
            {
                clients.Add(new Client());
            }
        }

        // У меня не получилось с сохранением данных, поэтому я просто оставлю это здесь, чтобы вы видели, что я пытался)
        // А поскольку смысл урока не в сериализации, то я решил что можно сделать и без неё и добаил клиентов автоматически при запуске
        // но если вы мне подскажете, что не так с этими методами, буду только рад, потому что потратил на них нормальную такую долю времени

        //public static void SerializeClients()
        //{
        //    json = JsonConvert.SerializeObject(clients);
        //    File.WriteAllText("Clients.json", json);
        //}

        //public static void DeserializeClients()
        //{
        //    json = File.ReadAllText("Clients.json");
        //    try
        //    {
        //        clients = JsonConvert.DeserializeObject<ObservableCollection<Client>>(json) ?? new ObservableCollection<Client>();
        //    }
        //    finally { }
        //}
        // ps возможно это даже не финальная версия методов, а уже искаверканная в тщеных попытках всё исправить, уже не помню)
    }
}