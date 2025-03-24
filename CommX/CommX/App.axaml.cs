using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CommX.ViewModels;
using CommX.Views;
using Prism.DryIoc;
using Prism.Ioc;

namespace CommX
{
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize(); 
        }

        protected override AvaloniaObject CreateShell()
        {
           return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<TestView,TestViewModel>();
        }
    }
}