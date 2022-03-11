using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedisSessionState_Poc.Startup))]
namespace RedisSessionState_Poc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
