using System.Windows;
using Caliburn.Micro;

namespace MetroLightTemplate.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private string inputName = string.Empty;

        public string InputName
        {
            get { return inputName; }
            set
            {
                inputName = value;
                NotifyOfPropertyChange(() => InputName);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(InputName); }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", InputName)); //Don't do this in real life :)
        }
    }
}