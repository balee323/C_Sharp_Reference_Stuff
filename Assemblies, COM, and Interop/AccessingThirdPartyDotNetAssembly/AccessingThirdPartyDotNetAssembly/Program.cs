using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccessingThirdPartyDotNetAssembly
{
    class Program
    {
        static void Main(string[] args)
        {

            //ExecuteStaticMethodOnAssembly();

            CreateObjectAndExecuteMethodOnAssembly();

           
        }

        private static void CreateObjectAndExecuteMethodOnAssembly()
        {
            Assembly assembly = Assembly.LoadFrom("netstandard2.0\\NetworkingTools.dll");

            

            Type type = assembly.GetType("NetworkingTools.WifiNetworking");

            //get access to the constructor
            ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });

            //create instance of the class
            dynamic wifiNetworking = constructorInfo.Invoke(new object[] { "192.167.112.90" });


            Console.WriteLine($"IP Adress: 192.167.112.90 physical address: {wifiNetworking.GetPhysicalAddress()} ");


            Console.ReadKey();
        }

        private static void ExecuteStaticMethodOnAssembly()
        {
            Assembly assembly = Assembly.LoadFrom("netstandard2.0\\NetworkingTools.dll");

            Type type = assembly.GetType("NetworkingTools.Networking");

            MethodInfo methodInfo = type.GetMethod("GetPhysicalAddress", BindingFlags.NonPublic | BindingFlags.Static);

            string ip1 = "40.167.112.90";
            string ip2 = "192.167.112.90";

            var address1 = methodInfo.Invoke(null, new[] { ip1 });
            var address2 = methodInfo.Invoke(null, new[] { ip2 });

            Console.WriteLine($"IP Adress: {ip1} physical address: {address1} ");
            Console.WriteLine($"IP Adress: {ip2} physical address: {address2} ");

            Console.ReadKey();

        }


    }
}
