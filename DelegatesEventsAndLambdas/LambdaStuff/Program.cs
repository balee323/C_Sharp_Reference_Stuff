using System;
using System.Windows.Forms;

namespace LambdaStuff
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            //var anomyous = new AnonmyousClass();
            //anomyous.NestedFunction();


            var lpg = new LambdaPlayground();

            lpg.PrintNames();

            Console.WriteLine("================");

            lpg.Sort();

            lpg.PrintNames();

            
     

            //showing form stuff

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LambdaLearning1());


            Console.ReadKey();
        }
    }
}
