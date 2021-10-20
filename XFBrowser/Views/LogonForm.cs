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

namespace XFBrowser
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
            btnLogon.BindCommand(new DelegateCommand(() => { viewModel.LogonUser(); }));

            //mvvmContext.ViewModelType = typeof(LogonFormViewModel);
            //var fluent = mvvmContext.OfType<LogonFormViewModel>();
            //fluent.BindCommand(btnLogon, x => x.DoSomething);
        }
    }
}