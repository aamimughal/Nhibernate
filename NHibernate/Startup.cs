using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHibernate.Startup))]
namespace NHibernate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
