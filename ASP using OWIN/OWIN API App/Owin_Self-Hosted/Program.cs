using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_Owin;

namespace Owin_Self_Hosted
{
    class Program
    {
        static void Main(string[] args)
        {

            using (WebApp.Start<Startup>("http://localhost:1250")){
                Console.WriteLine("Listening to port: 1250");
                Console.WriteLine("Press any key to end.");
                Console.ReadKey();
            }
        }
    }
}
