using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OWIN_API_App
{
    public class Startup
    {
        //create custom deletage.  Must have access modifier
        private delegate void VoidDel();

        //create a custom function delegate
        private delegate bool BoolFunctionDel(string inputString); 

        private async static void Delegates()
        {

            //create instance of custom delegate
            VoidDel voidDel = () => Console.WriteLine("hello World");

            //create a custom function delegate
            

            //call the delegate
            voidDel();

            //Action Delegate
            //4 ways to give an Action method
            Action a = new Action(AFunctionForTheActionDelegate); //named function
            a();

            Action b = new Action(voidDel); // named delegate
            b();

            Action c = new Action(delegate { Console.WriteLine("hello old style delegate"); }); //internal delegate
            c();

            Action d = new Action(() => Console.WriteLine("hello lambda delegate")); //lambda expression
            d.Invoke();

            //Function Delegates:
            Func<string> stringFunc = new Func<string>(AFunctionForTheFuncDelegate);
            Console.WriteLine(stringFunc()); //will write out "done"

            Func<Task<string>> funcDelegate = new Func<Task<string>>(AsyncFunctionForTheFuncDelegate);

            string result1 = funcDelegate().Result;
            // or
            string result2 = await funcDelegate();
                
            Console.WriteLine(result1); //will write out "done"
            Console.WriteLine(result2); //will write out "done"


            //Custom Function Delegate
            BoolFunctionDel boolFunctionDel = new BoolFunctionDel((word) =>
            {
                bool isMatch = false;
                if (word == "dog")
                {
                    isMatch = true;
                }
                return isMatch;
            });

            //test it out
            bool isFirstMatch = boolFunctionDel("cat");
            bool isSecondMatch = boolFunctionDel("dog");


            string message = isFirstMatch ? "cat is a match" : (isSecondMatch ? "dog is a match" : "noMatches"); //nested ternary operation

        
            Console.WriteLine(message);
            



        }


     

        public static void Configuration(IAppBuilder app)
        {
           
            //app.Use(async (ctx, next) =>
            //{
            //    Task t = new Task(Func<Task> funcDelegate =>  Console.WriteLine("Hello World") );
            //    await t;

            //});

            app.Use(async (ctx, next) =>
            {
                Task t = new Task(() => Console.WriteLine("Hello World"));
                await t;

            });
         

            //ctx is the owin context, and next is a function delegate that returns a task.
            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Hello World");
            });

        }
    }
}