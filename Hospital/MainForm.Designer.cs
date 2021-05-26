namespace Hospital
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.issuedButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonIBackup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSetting = new DevExpress.XtraBars.BarSubItem();
            this.barButtonDataLoad = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem = new DevExpress.XtraBars.SkinBarSubItem();
            this.barLargeButtonRefresh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.aceAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceEdit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceExport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDetail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gcPatientList = new DevExpress.XtraGrid.GridControl();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPatientList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAADHAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFatherOrHusband = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemICGender = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemICGender)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barLargeButtonIBackup,
            this.issuedButton,
            this.barSetting,
            this.barButtonDataLoad,
            this.skinBarSubItem,
            this.barLargeButtonRefresh});
            this.barManager1.MaxItemId = 16;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.issuedButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonIBackup, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetting, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonRefresh)});
            this.bar1.OptionsBar.MinHeight = 50;
            this.bar1.Text = "Custom 3";
            // 
            // issuedButton
            // 
            this.issuedButton.Caption = "Issued Medicine";
            this.issuedButton.Id = 11;
            this.issuedButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("issuedButton.ImageOptions.SvgImage")));
            this.issuedButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.issuedButton.Name = "issuedButton";
            this.issuedButton.ShortcutKeyDisplayString = "I";
            // 
            // barLargeButtonIBackup
            // 
            this.barLargeButtonIBackup.Caption = "BackUp Data";
            this.barLargeButtonIBackup.Id = 10;
            this.barLargeButtonIBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLargeButtonIBackup.ImageOptions.SvgImage")));
            this.barLargeButtonIBackup.Name = "barLargeButtonIBackup";
            this.barLargeButtonIBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonIBackup_ItemClick);
            // 
            // barSetting
            // 
            this.barSetting.Caption = "Settings";
            this.barSetting.Id = 12;
            this.barSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSetting.ImageOptions.SvgImage")));
            this.barSetting.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barSetting.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDataLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem)});
            this.barSetting.Name = "barSetting";
            this.barSetting.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonDataLoad
            // 
            this.barButtonDataLoad.Caption = "BackUp Data Load";
            this.barButtonDataLoad.Id = 13;
            this.barButtonDataLoad.Name = "barButtonDataLoad";
            this.barButtonDataLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDataLoad_ItemClick);
            // 
            // skinBarSubItem
            // 
            this.skinBarSubItem.Caption = "Select Theme";
            this.skinBarSubItem.Id = 14;
            this.skinBarSubItem.Name = "skinBarSubItem";
            // 
            // barLargeButtonRefresh
            // 
            this.barLargeButtonRefresh.Caption = "Refresh Data";
            this.barLargeButtonRefresh.Id = 15;
            this.barLargeButtonRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.barLargeButtonRefresh.Name = "barLargeButtonRefresh";
            this.barLargeButtonRefresh.ShortcutKeyDisplayString = "R";
            this.barLargeButtonRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(898, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(898, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(898, 56);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.barButtonItem1.Caption = "Add New";
            this.barButtonItem1.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Stretch;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ShortcutKeyDisplayString = "M";
            this.barButtonItem1.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "hghg";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // aceAdd
            // 
            this.aceAdd.ImageOptions.Image = global::Hospital.Properties.Resources.addfile_32x32;
            this.aceAdd.Name = "aceAdd";
            this.aceAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceAdd.Text = "ADD NEW";
            this.aceAdd.Click += new System.EventHandler(this.aceAdd_Click);
            // 
            // aceEdit
            // 
            this.aceEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceEdit.ImageOptions.Image")));
            this.aceEdit.Name = "aceEdit";
            this.aceEdit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceEdit.Text = "EDIT";
            this.aceEdit.Click += new System.EventHandler(this.aceEdit_Click);
            // 
            // aceDelete
            // 
            this.aceDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDelete.ImageOptions.Image")));
            this.aceDelete.Name = "aceDelete";
            this.aceDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDelete.Text = "DELETE";
            this.aceDelete.Click += new System.EventHandler(this.aceDelete_Click);
            // 
            // aceExport
            // 
            this.aceExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceExport.ImageOptions.Image")));
            this.aceExport.Name = "aceExport";
            this.aceExport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceExport.Text = "EXPORT EXCEL";
            this.aceExport.Click += new System.EventHandler(this.aceExport_Click);
            // 
            // aceDetail
            // 
            this.aceDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDetail.ImageOptions.Image")));
            this.aceDetail.Name = "aceDetail";
            this.aceDetail.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDetail.Text = "DETAIL VIEW";
            // 
            // accordionControl
            // 
            this.accordionControl.AllowHtmlText = false;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceAdd,
            this.aceEdit,
            this.aceDelete,
            this.aceExport,
            this.aceDetail,
            this.aceMedicine});
            this.accordionControl.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.accordionControl.Location = new System.Drawing.Point(699, 56);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.OptionsFooter.ActiveGroupDisplayMode = DevExpress.XtraBars.Navigation.ActiveGroupDisplayMode.GroupHeaderAndContent;
            this.accordionControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accordionControl.Size = new System.Drawing.Size(199, 592);
            this.accordionControl.TabIndex = 14;
            this.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceMedicine
            // 
            this.aceMedicine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceMedicine.ImageOptions.Image")));
            this.aceMedicine.Name = "aceMedicine";
            this.aceMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceMedicine.Text = "ISSUE MEDICINE";
            this.aceMedicine.Click += new System.EventHandler(this.aceMedicine_Click);
            // 
            // gcPatientList
            // 
            this.gcPatientList.DataSource = this.patientBindingSource;
            this.gcPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPatientList.Location = new System.Drawing.Point(0, 56);
            this.gcPatientList.MainView = this.gvPatientList;
            this.gcPatientList.Name = "gcPatientList";
            this.gcPatientList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemICGender});
            this.gcPatientList.Size = new System.Drawing.Size(699, 592);
            this.gcPatientList.TabIndex = 15;
            this.gcPatientList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientList});
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Hospital.Model.Patient);
            // 
            // gvPatientList
            // 
            this.gvPatientList.ColumnPanelRowHeight = 34;
            this.gvPatientList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colAADHAR,
            this.colName,
            this.colAge,
            this.colFatherOrHusband,
            this.colGender,
            this.colMobile,
            this.colAddress});
            gridFormatRule1.Name = "FormatStatus";
            formatConditionIconSet1.CategoryName = "Shapes";
            formatConditionIconSetIcon1.PredefinedName = "TrafficLights23_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "TrafficLights23_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "TrafficLights23_3.png";
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "TrafficLights3Unrimmed";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gvPatientList.FormatRules.Add(gridFormatRule1);
            this.gvPatientList.GridControl = this.gcPatientList;
            this.gvPatientList.GroupRowHeight = 34;
            this.gvPatientList.Name = "gvPatientList";
            this.gvPatientList.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gvPatientList.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvPatientList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvPatientList.OptionsBehavior.Editable = false;
            this.gvPatientList.OptionsDetail.EnableMasterViewMode = false;
            this.gvPatientList.OptionsFind.AlwaysVisible = true;
            this.gvPatientList.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gvPatientList.OptionsPrint.PrintHorzLines = false;
            this.gvPatientList.OptionsPrint.PrintVertLines = false;
            this.gvPatientList.OptionsView.ShowFooter = true;
            this.gvPatientList.OptionsView.ShowGroupedColumns = true;
            this.gvPatientList.OptionsView.ShowGroupPanel = false;
            this.gvPatientList.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvPatientList.RowHeight = 34;
            // 
            // colPID
            // 
            this.colPID.FieldName = "PID";
            this.colPID.Name = "colPID";
            this.colPID.Visible = true;
            this.colPID.VisibleIndex = 0;
            // 
            // colAADHAR
            // 
            this.colAADHAR.FieldName = "AADHAR";
            this.colAADHAR.Name = "colAADHAR";
            this.colAADHAR.Visible = true;
            this.colAADHAR.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 3;
            // 
            // colFatherOrHusband
            // 
            this.colFatherOrHusband.FieldName = "FatherOrHusband";
            this.colFatherOrHusband.Name = "colFatherOrHusband";
            this.colFatherOrHusband.Visible = true;
            this.colFatherOrHusband.VisibleIndex = 4;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 5;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 6;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 7;
            // 
            // repositoryItemICGender
            // 
            this.repositoryItemICGender.AutoHeight = false;
            this.repositoryItemICGender.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemICGender.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "Male", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "Female", 0)});
            this.repositoryItemICGender.Name = "repositoryItemICGender";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 668);
            this.Controls.Add(this.gcPatientList);
            this.Controls.Add(this.accordionControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDICINE ISSUE APPLICATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemICGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem issuedButton;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonIBackup;
        private DevExpress.XtraBars.BarSubItem barSetting;
        private DevExpress.XtraBars.BarButtonItem barButtonDataLoad;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAdd;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceEdit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceExport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDetail;
        private DevExpress.XtraGrid.GridControl gcPatientList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientList;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemICGender;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colAADHAR;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colFatherOrHusband;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceMedicine;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonRefresh;
    }
}