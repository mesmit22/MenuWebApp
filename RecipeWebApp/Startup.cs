using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeWebApp.Startup))]
namespace RecipeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
