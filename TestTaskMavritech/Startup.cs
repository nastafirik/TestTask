using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTaskMavritech.Startup))]
namespace TestTaskMavritech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
