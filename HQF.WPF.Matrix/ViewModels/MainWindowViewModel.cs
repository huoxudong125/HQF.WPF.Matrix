using HQF.WPF.Matrix.Views;
using Prism.Mvvm;
using Prism.Regions;

namespace HQF.WPF.Matrix.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Autofac Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(MatixTransformView));
        }
    }
}
