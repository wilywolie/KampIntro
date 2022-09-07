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
            
            RegisterCrediManager registerCrediManager = new RegisterCrediManager();
            registerCrediManager.Register(homeCrediManager);

            
        }
    }
}
