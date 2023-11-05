using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarm
{
    public class AppSettings
    {
        public string ConnectionString { get; set; }

        public AppSettings()
        {
            // Встановлюємо значення рядка підключення до бази даних в конструкторі
            ConnectionString = "Data Source=(localdb)\\BookWarm;Initial Catalog=BookWarmDB;Integrated Security=True";
        }
    }
}


