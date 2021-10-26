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
                InitializeBindings();
            }
        }

        public void InitializeBindings()
        {
            LogonFormViewModel viewModel = mvvmContext.GetViewModel<LogonFormViewModel>();
            txtUserName.DataBindings.Add("EditValue", viewModel, "UserName");
            txtPassword.DataBindings.Add("EditValue", viewModel, "Password");
            lblResult.DataBindings.Add("Text", viewModel, "Result");
            btnLogon.BindCommand(new DelegateCommand(() => { viewModel.LogonUser(); }));
            //btnLogon.BindCommand(new DelegateCommand(() => { viewModel.DoSomething(); }));
        }
    }
}
