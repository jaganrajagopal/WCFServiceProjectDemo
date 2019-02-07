using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost myHost = new ServiceHost(typeof(WCFService.Service1)))
            {
                myHost.Open();
                Console.WriteLine("Started at this point"+ DateTime.Now.ToString());
                Console.ReadLine();
               // myHost.Close();
            }
        }
    }
}
