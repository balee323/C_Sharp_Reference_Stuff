using Owin;

namespace WebApp_Owin
{
    public class Startup
    {

        public static void Configuration(IAppBuilder app)
        {

            app.UseStaticFiles();
           
            //ctx is the owin context, and next is a function delegate that returns a task.
            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Hello World");
            });

        }
    }
}