using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrashCourse.Startup))]
namespace CrashCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
