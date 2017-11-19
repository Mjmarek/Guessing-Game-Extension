using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuessingGame.Startup))]
namespace GuessingGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
