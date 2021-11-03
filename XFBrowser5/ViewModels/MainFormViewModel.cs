using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;

namespace XFBrowser5
{
    public class MainFormViewModel
    {
        private LogonFormViewModel logonFormViewModel;

        public MainFormViewModel()
        {
            this.logonFormViewModel = LogonFormViewModel.Create();
            this.logonFormViewModel.SetParentViewModel(this);
        }
    }
}
