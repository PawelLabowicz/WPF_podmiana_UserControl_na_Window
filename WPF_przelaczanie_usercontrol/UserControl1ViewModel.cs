using System.Windows.Input;

namespace WPF_przelaczanie_usercontrol
{
    public class UserControl1ViewModel : ViewModelBase,IUserControlViewModel
    {
        private IMainView glownyWiok;

        public ICommand ZaladujUserControl2 { get; }

        public string NazwaUserControl => "UserControl z numerkiem 1";

        public UserControl1ViewModel() { }
        public UserControl1ViewModel(IMainView glownyWidok)
        {
            this.glownyWiok = glownyWidok;
            ZaladujUserControl2 = new RelayCommand(ZaladujUserControl_2);
        }

        private void ZaladujUserControl_2()
        {
            glownyWiok.UstawUserControl2();
        }
    }
}
