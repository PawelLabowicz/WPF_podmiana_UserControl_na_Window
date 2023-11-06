using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_przelaczanie_usercontrol
{
    public class MainWindowViewModel : ViewModelBase, IMainView
    {
        public ICommand PrzywrocUserControl1 {get;}

        public string NazwaZaladowanejUserControl => WymiennyUserControl?.NazwaUserControl;

        private IUserControlViewModel wymiennyUserControl;
        public IUserControlViewModel WymiennyUserControl
        {
            get { return wymiennyUserControl; }
            set { wymiennyUserControl = value;
                OnPropertyChanged(nameof(WymiennyUserControl));
                OnPropertyChanged(nameof(NazwaZaladowanejUserControl)); }
        }

        public MainWindowViewModel()
        {
            PrzywrocUserControl1 = new RelayCommand(UstawUserControl1, () => {  return WymiennyUserControl is not UserControl1ViewModel; });

            UstawUserControl1();
        }

        public void UstawUserControl1()
        {
            WymiennyUserControl = new UserControl1ViewModel(this);
        }

        public void UstawUserControl2()
        {
            WymiennyUserControl = new UserControl2ViewModel();
        }
    }
}
