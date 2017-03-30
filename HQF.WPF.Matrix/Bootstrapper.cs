using Autofac;
using Prism.Autofac;
using HQF.WPF.Matrix.Views;
using System.Windows;

namespace HQF.WPF.Matrix
{
    class Bootstrapper : AutofacBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
