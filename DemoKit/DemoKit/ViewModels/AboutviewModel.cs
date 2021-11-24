using System.Windows.Input;
using TinyMvvm;

namespace DemoKit.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {

        public ICommand Home => new TinyCommand(async () =>
        {
            await Navigation.NavigateToAsync("//TabHome/home");
        });

    }
}
