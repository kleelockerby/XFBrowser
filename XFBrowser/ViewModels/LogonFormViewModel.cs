using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;

namespace XFBrowser
{
    public class LogonFormViewModel : ISupportServices
    {
        IServiceContainer serviceContainer = null;
        protected IServiceContainer ServiceContainer
        {
            get
            {
                if (serviceContainer == null)
                    serviceContainer = new ServiceContainer(this);
                return serviceContainer;
            }
        }
        IServiceContainer ISupportServices.ServiceContainer { get { return ServiceContainer; } }

        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }

        public LogonFormViewModel()
        {
            this.UserName = "admin";
            this.Password = "123";
        }

        public void LogonUser()
        {
            IMessageBoxService msgBoxService = this.GetService<IMessageBoxService>();
            msgBoxService.ShowMessage("Logon", "Logon", MessageButton.OK, MessageIcon.Information);

            //IMessageBoxService msgBoxService = ServiceContainer.GetService<IMessageBoxService>();
            //MessageBoxService.Show(e.ErrorMessage, e.ErrorCaption, MessageBoxButton.OK, MessageBoxImage.Error);
            //MessageBox.Show("Hello! I'm running!");
            //LogonDataAccess dataAccess = new LogonDataAccess(new System.Net.Http.HttpClient() );
        }
    }
}
