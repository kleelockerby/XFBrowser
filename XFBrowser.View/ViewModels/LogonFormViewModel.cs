using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using XFBrowser.Shared;
using OneStreamWebUI.Shared;
using OneStream.Shared.Wcf;

namespace XFBrowser.View
{
    [POCOViewModel()]
    public class LogonFormViewModel
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public string AuthenticationResult { get; set; }

        public LogonFormViewModel()
        {
            this.UserName = "admin";
            this.Password = "123";
            this.AuthenticationResult = "Status: ";
        }

        public void DoSomething()
        {
            IMessageBoxService msgBoxService = this.GetService<IMessageBoxService>();
            msgBoxService.ShowMessage("Logon", "Logon", MessageButton.OK, MessageIcon.Information);
        }

        public async  void LogonUser()
        {
            LogonDataAccess dataAccess = new LogonDataAccess();
            try
            {

                XFLogonResponseDto logonResponsDto = await dataAccess.LogonUserAsync(this.UserName, this.Password, "GolfStreamDemo_v36");

                if (logonResponsDto != null)
                {
                    OneStream.Shared.Wcf.AuthenticationResult authenticationResult = logonResponsDto.AuthenticationResult;
                    if (authenticationResult == OneStream.Shared.Wcf.AuthenticationResult.Success)
                    {
                        this.AuthenticationResult = "Success";
                    }
                    else
                    {
                        this.AuthenticationResult = "Failed";
                    }
                }

            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                throw;
            }
        }
    }
}
