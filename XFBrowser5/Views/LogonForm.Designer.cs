
namespace XFBrowser5
{
    partial class LogonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.cboApplications = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogon = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboApplications.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35.16F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 69.84F)});
            this.tablePanel1.Controls.Add(this.cboApplications);
            this.tablePanel1.Controls.Add(this.txtPassword);
            this.tablePanel1.Controls.Add(this.txtUserName);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Location = new System.Drawing.Point(67, 80);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 34F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 34F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 34F)});
            this.tablePanel1.Size = new System.Drawing.Size(436, 111);
            this.tablePanel1.TabIndex = 1;
            // 
            // cboApplications
            // 
            this.cboApplications.Location = new System.Drawing.Point(162, 75);
            this.cboApplications.Name = "cboApplications";
            this.cboApplications.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboApplications.Size = new System.Drawing.Size(271, 20);
            this.cboApplications.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(162, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(162, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Application:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User Name:";
            // 
            // btnLogon
            // 
            this.btnLogon.Location = new System.Drawing.Point(232, 210);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(271, 23);
            this.btnLogon.TabIndex = 2;
            this.btnLogon.Text = "Logon";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(XFBrowser5.LogonFormViewModel);
            // 
            // LogonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.btnLogon);
            this.Controls.Add(this.tablePanel1);
            this.Name = "LogonForm";
            this.Text = "Logon";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboApplications.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboApplications;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnLogon;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }
}