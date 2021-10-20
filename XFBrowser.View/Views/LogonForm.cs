using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;

namespace XFBrowser.View
{
    public partial class LogonForm : XtraForm
    {
        public LogonForm()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            LogonFormViewModel viewModel = mvvmContext.GetViewModel<LogonFormViewModel>();
            txtUserName.DataBindings.Add("EditValue", viewModel, "UserName");
            txtPassword.DataBindings.Add("EditValue", viewModel, "Password");
            lblResult.DataBindings.Add("Text", viewModel, "AuthenticationResult");
            btnLogon.BindCommand(new DelegateCommand(() => { viewModel.LogonUser(); }));
            //btnLogon.BindCommand(new DelegateCommand(() => { viewModel.DoSomething(); }));
        }
    }
}