using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace TestWeatherClient.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }
        
        public static void Cleanup() {}
    }
}