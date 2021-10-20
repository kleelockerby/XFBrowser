using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFBrowser
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
