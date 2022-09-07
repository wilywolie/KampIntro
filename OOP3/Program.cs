using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICrediManager neededCrediManager = new NeededCrediManager();


            ICrediManager vehicleCrediManager = new VehicleCrediManager();


            ICrediManager homeCrediManager = new HomeCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerSerice = new FileLoggerService();



            RegisterCrediManager registerCrediManager = new RegisterCrediManager();
            //registerCrediManager.Register(vehicleCrediManager, fileLoggerSerice);
            registerCrediManager.Register(new EsnafKredisi(), new List<ILoggerService>(){new DatabaseLoggerService(),new SmsLoggerService()});

            List<ICrediManager> krediler = new List<ICrediManager>() { neededCrediManager, vehicleCrediManager };

            //registerCrediManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
