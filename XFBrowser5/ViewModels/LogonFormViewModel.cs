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
        public virtual string LogonResult { get; set; }
        public virtual string SelectedApplicationName { get; set; } = "GolfStreamDemo_v36";

        public virtual IList<ApplicationModel> Applications { get; set; }
        public virtual ApplicationModel SelectedApplication { get; set; }
        
        private IList<string> ApplicationNames;

        public IEnumerable<string> LookupApplicationNames
        {
            get { return this.ApplicationNames; }
        }

        public LogonFormViewModel()
        {
            this.UserName = "admin";
            this.Password = "123";
            this.LogonResult = "Status: ";
            this.Applications = new List<ApplicationModel>();
            this.ApplicationNames = new List<string>();
        }

        public static LogonFormViewModel Create()
        {
            return ViewModelSource.Create<LogonFormViewModel>();
        }

        public async void LogonUser()
        {
            try
            {
                XFLogonResponseDto logonResponsDto = await LogonDataAccess.LogonUserAsync(this.UserName, this.Password, this.selectedApplicationName);

                if (logonResponsDto != null)
                {
                    AuthenticationResult authenticationResult = logonResponsDto.AuthenticationResult;
                    if ((logonResponsDto.AuthenticationResult == AuthenticationResult.Success) && (logonResponsDto.SI != null) && (logonResponsDto.SI.IsAuthenticated))
                    {
                        XFApplicationsResponseDto applicationsResponseDto = await LogonDataAccess.GetApplicationsAsync(logonResponsDto.SI);
                        if ((applicationsResponseDto != null) && (applicationsResponseDto.Applications?.Count > 0))
                        {
                            List<XFApplication> applications = applicationsResponseDto.Applications;
                            foreach (XFApplication application in applications)
                            {
                                ApplicationModel applicationModel = new ApplicationModel() { Name = application.Name, UniqueID = application.UniqueID, Description = application.Description, DatabaseSchemaName = application.DatabaseSchemaName, DatabaseServerConnectionName = application.DatabaseServerConnectionName };
                                this.Applications.Add(applicationModel);
                                this.ApplicationNames.Add(applicationModel.Name);
                            }
                            this.SelectedApplication = GetSelectedApplication(this.SelectedApplicationName);
                        }
                    }

                    this.LogonResult = (authenticationResult == AuthenticationResult.Success) ? "Success" : "Failed";
                }

            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                throw;
            }
        }

        private ApplicationModel GetSelectedApplication(string selectedApplicationName)
        {
            ApplicationModel selectedAppModel = null;
            foreach (ApplicationModel appModel in this.Applications)
            {
                if (appModel.Name == selectedApplicationName)
                {
                    selectedAppModel = appModel;
                    break;
                }
            }
            return selectedAppModel;
        }

        protected void OnApplicationsChanged()
        {
            this.SelectedApplication = this.Applications.FirstOrDefault();
        }
    }
}
