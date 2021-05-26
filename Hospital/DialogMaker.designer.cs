namespace EducareSMS.Control
{
    partial class DialogMaker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcOne = new DevExpress.XtraEditors.PanelControl();
            this.txtOne = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.pceCheck = new DevExpress.XtraEditors.PictureEdit();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUsername = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcOne)).BeginInit();
            this.pcOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnClose.Location = new System.Drawing.Point(253, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl
            // 
            this.panelControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl.Appearance.Options.UseBackColor = true;
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Controls.Add(this.btnClose);
            this.panelControl.Controls.Add(this.btnSave);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 159);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(427, 60);
            this.panelControl.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.62763F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.37237F));
            this.tableLayoutPanel1.Controls.Add(this.pcOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pceCheck, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 66);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // pcOne
            // 
            this.pcOne.Appearance.BackColor = System.Drawing.Color.White;
            this.pcOne.Appearance.Options.UseBackColor = true;
            this.pcOne.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcOne.Controls.Add(this.txtOne);
            this.pcOne.Controls.Add(this.labelOne);
            this.pcOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcOne.Location = new System.Drawing.Point(73, 3);
            this.pcOne.Name = "pcOne";
            this.pcOne.Size = new System.Drawing.Size(351, 60);
            this.pcOne.TabIndex = 0;
            // 
            // txtOne
            // 
            this.txtOne.AutoSize = true;
            this.txtOne.BackColor = System.Drawing.Color.Transparent;
            this.txtOne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOne.Location = new System.Drawing.Point(9, 33);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(327, 15);
            this.txtOne.TabIndex = 0;
            this.txtOne.Text = "Please Enter Username && Password of Administrator Acount.";
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.BackColor = System.Drawing.Color.Transparent;
            this.labelOne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOne.Location = new System.Drawing.Point(9, 12);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(301, 17);
            this.labelOne.TabIndex = 0;
            this.labelOne.Text = "THIS CHANGE REQUIRED ADMIN VERIFICATION";
            // 
            // pceCheck
            // 
            this.pceCheck.EditValue = global::Hospital.Properties.Resources.show_32x32;
            this.pceCheck.Location = new System.Drawing.Point(3, 3);
            this.pceCheck.Name = "pceCheck";
            this.pceCheck.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pceCheck.Properties.Appearance.Options.UseBackColor = true;
            this.pceCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pceCheck.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceCheck.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pceCheck.Size = new System.Drawing.Size(64, 60);
            this.pceCheck.TabIndex = 0;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.UserNameTextEdit);
            this.lcMain.Controls.Add(this.PasswordTextEdit);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 66);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(607, 0, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(427, 93);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "lcMain";
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.Location = new System.Drawing.Point(109, 19);
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.UserNameTextEdit.Size = new System.Drawing.Size(299, 24);
            this.UserNameTextEdit.StyleController = this.lcMain;
            this.UserNameTextEdit.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Username can not be empty";
            this.dxValidationProvider.SetValidationRule(this.UserNameTextEdit, conditionValidationRule1);
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.Location = new System.Drawing.Point(109, 47);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextEdit.Properties.Appearance.Options.UseFont = true;
            this.PasswordTextEdit.Properties.PasswordChar = '*';
            this.PasswordTextEdit.Size = new System.Drawing.Size(299, 24);
            this.PasswordTextEdit.StyleController = this.lcMain;
            this.PasswordTextEdit.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Password can not be empty";
            this.dxValidationProvider.SetValidationRule(this.PasswordTextEdit, conditionValidationRule2);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgMain});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(427, 93);
            this.Root.TextVisible = false;
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUsername,
            this.lciPassword});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(417, 83);
            this.lcgMain.Text = "AUTH FORM";
            this.lcgMain.TextVisible = false;
            // 
            // lciUsername
            // 
            this.lciUsername.Control = this.UserNameTextEdit;
            this.lciUsername.CustomizationFormText = "layoutControlItem1";
            this.lciUsername.Location = new System.Drawing.Point(0, 0);
            this.lciUsername.Name = "lciUsername";
            this.lciUsername.Size = new System.Drawing.Size(393, 28);
            this.lciUsername.Text = "USER NAME        ";
            this.lciUsername.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciUsername.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.PasswordTextEdit;
            this.lciPassword.CustomizationFormText = "layoutControlItem3";
            this.lciPassword.Location = new System.Drawing.Point(0, 28);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.Size = new System.Drawing.Size(393, 31);
            this.lciPassword.Text = "PASSWORD         ";
            this.lciPassword.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciPassword.TextSize = new System.Drawing.Size(87, 13);
            // 
            // DialogMaker
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelControl);
            this.Name = "DialogMaker";
            this.Size = new System.Drawing.Size(427, 219);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcOne)).EndInit();
            this.pcOne.ResumeLayout(false);
            this.pcOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciUsername;
        private DevExpress.XtraLayout.LayoutControlItem lciPassword;
        private DevExpress.XtraEditors.PictureEdit pceCheck;
        private DevExpress.XtraEditors.PanelControl pcOne;
        private System.Windows.Forms.Label txtOne;
        private System.Windows.Forms.Label labelOne;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}
