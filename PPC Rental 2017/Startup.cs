using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPC_Rental_2017.Startup))]
namespace PPC_Rental_2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
