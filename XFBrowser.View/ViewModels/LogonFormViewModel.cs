using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;

namespace XFBrowser.View
{
    [POCOViewModel()]
    public class LogonFormViewModel
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }

        public LogonFormViewModel()
        {
            this.UserName = "admin";
            this.Password = "123";
        }

        public void DoSomething()
        {
            IMessageBoxService msgBoxService = this.GetService<IMessageBoxService>();
            msgBoxService.ShowMessage("Logon", "Logon", MessageButton.OK, MessageIcon.Information);
        }

        public void LogonUser()
        {

        }
    }
}
