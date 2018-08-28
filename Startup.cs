using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson_1.Startup))]
namespace Lesson_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
