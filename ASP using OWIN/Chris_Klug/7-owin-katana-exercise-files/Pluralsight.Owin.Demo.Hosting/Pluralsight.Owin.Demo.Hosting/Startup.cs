using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.Owin.Demo.Hosting
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            app.UseStaticFiles();

            app.Use(async (ctx, next) => {
                await ctx.Response.WriteAsync("Hello World");
            });
        }
    }
}
