using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApp_Owin
{
    public class Startup
    {

        public static void Configuration(IAppBuilder app)
        {
           
            //ctx is the owin context, and next is a function delegate that returns a task.
            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Hello World");
            });

        }
    }
}