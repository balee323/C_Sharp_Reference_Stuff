using Owin;
using System.Diagnostics;

namespace Pluralsight.Owin.Demo
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            
            app.Use(async (ctx, next) =>
            {
                Debug.WriteLine("Incoming request: " + ctx.Request.Path);
                await next(); //must wait on the task to complete before going to the next statement.
                Debug.WriteLine("Outgoing request: " + ctx.Request.Path);
            });

            app.Use(async (ctx, next) =>
            {
                ;
                await ctx.Response.WriteAsync("<html><head></head><body>Hello World</body></html>");
            });
        }
    }
}