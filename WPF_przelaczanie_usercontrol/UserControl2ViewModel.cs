using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_przelaczanie_usercontrol
{
    public class UserControl2ViewModel : ViewModelBase, IUserControlViewModel
    {
        public string NazwaUserControl => "UserControl z numerkiem 2";
        public UserControl2ViewModel() { }
    }
}
