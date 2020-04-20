using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageUploadAndDownloadInMVC.Startup))]
namespace ImageUploadAndDownloadInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
