using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RegisterCrediManager
    {

        //Method injection
        public void Register(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {
            // başvuran bilgilerini değerlendirme
            crediManager.Calculate();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> crediler)
        {
            foreach (var credi in crediler)
            {
                credi.Calculate();
            }
        }
    }
}
  