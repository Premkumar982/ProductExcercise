using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductExcercise.Startup))]
namespace ProductExcercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
