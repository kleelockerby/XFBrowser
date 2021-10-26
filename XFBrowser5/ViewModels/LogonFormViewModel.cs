using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using XFBrowser.Shared;
using System.Net.Http;
using OneStreamWebUI.Shared;
using OneStream.Shared.Wcf;

namespace XFBrowser5
{
    public class LogonFormViewModel
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Result { get; set; }

        public LogonFormViewModel()
        {
            this.UserName = "admin";
            this.Password = "123";
            this.Result = "Status: ";
        }

        public void DoSomething()
        {
            IMessageBoxService msgBoxService = this.GetService<IMessageBoxService>();
            msgBoxService.ShowMessage("Logon", "Logon", MessageButton.OK, MessageIcon.Information);
        }

        public async void LogonUser()
        {
            LogonDataAccess dataAccess = new LogonDataAccess(new HttpClient());
            try
            {
                XFLogonResponseDto logonResponsDto = await dataAccess.LogonUserAsync(this.UserName, this.Password, "GolfStreamDemo_v36");

                if (logonResponsDto != null)
                {
                    AuthenticationResult authenticationResult = logonResponsDto.AuthenticationResult;
                    if (authenticationResult == AuthenticationResult.Success)
                    {
                        this.Result += "Success";
                    }
                    else
                    {
                        this.Result += "Failed";
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
