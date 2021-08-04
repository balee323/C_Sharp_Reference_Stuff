using Owin;

namespace OWIN_API_App
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