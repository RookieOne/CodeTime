using System.ComponentModel;

namespace CodeTime.Infrastructure.ViewModels
{
    public abstract class ViewModel : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}