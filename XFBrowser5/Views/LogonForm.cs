using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Mvvm;

namespace XFBrowser5
{
    public partial class LogonForm : XtraForm
    {
        private LogonFormViewModel logonFormViewModel;

        public LogonForm()
        {
            InitializeComponent();

            logonFormViewModel = new LogonFormViewModel();
            

            if (!mvvmContext.IsDesignMode)
            {
                InitializeBindingsFluent();
            }
        }

        public void InitializeBindingsFluent()
        {
            var fluent = mvvmContext.OfType<LogonFormViewModel>();
            
            fluent.SetBinding(txtUserName, ed => ed.EditValue, x => x.UserName);
            fluent.SetBinding(txtPassword, ed => ed.EditValue, x => x.Password);
            fluent.SetBinding(lblResult, l => l.Text, x => x.LogonResult);

            fluent.SetBinding(cboApplications, cbo => cbo.SelectedItem, x => x.SelectedApplication);

            fluent.BindCommand(btnLogon, x => x.LogonUser);
        }

       /* private void Logon_OnLogonCompleted(EventArgs e)
        {
            foreach (string item in mvvmContext.GetViewModel<LogonFormViewModel>().LookupApplicationNames)
            {
                cboApplications.Properties.Items.Add(item);
            }
        }*/
    }
}
