using System.Windows;
using Caliburn.Micro;
using MetroLightTemplate.ViewModels;

namespace MetroLightTemplate
{
    public class TemplateBootstrapper : BootstrapperBase
    {
        public TemplateBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>().Wait();
        }
    }
}