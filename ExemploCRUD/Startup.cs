using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploCRUD.Startup))]
namespace ExemploCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
