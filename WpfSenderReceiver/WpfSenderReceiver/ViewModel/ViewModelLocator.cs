
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace WpfSenderReceiver.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<SenderViewModel>();
            SimpleIoc.Default.Register<ReceiverViewModel>();
        }

        public MainViewModel Main
        {
            get => ServiceLocator.Current.GetInstance<MainViewModel>();            
        }
        
        public SenderViewModel SenderViewModel
        {
            get => ServiceLocator.Current.GetInstance<SenderViewModel>();            
        }

        public ReceiverViewModel ReceiverViewModel
        {
            get => ServiceLocator.Current.GetInstance<ReceiverViewModel>();
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}