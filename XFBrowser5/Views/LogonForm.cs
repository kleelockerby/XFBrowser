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
        public LogonForm()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
            {
                //InitializeBindings();
                InitializeBindingsFluent();
            }
        }

        public void InitializeBindings()
        {
            LogonFormViewModel viewModel = mvvmContext.GetViewModel<LogonFormViewModel>();
            
            txtUserName.DataBindings.Add("EditValue", viewModel, "UserName");
            txtPassword.DataBindings.Add("EditValue", viewModel, "Password");
            lblResult.DataBindings.Add("Text", viewModel, "Result");
            
            btnLogon.BindCommand(new DelegateCommand(() => { viewModel.LogonUser(); }));
        }

        public void InitializeBindingsFluent()
        {
            var fluent = mvvmContext.OfType<LogonFormViewModel>();
            
            fluent.SetBinding(txtUserName, ed => ed.EditValue, x => x.UserName);
            fluent.SetBinding(txtPassword, ed => ed.EditValue, x => x.Password);
            fluent.SetBinding(lblResult, l => l.Text, x => x.Result);

            fluent.BindCommand(btnLogon, x => x.LogonUser);
        }
    }
}
