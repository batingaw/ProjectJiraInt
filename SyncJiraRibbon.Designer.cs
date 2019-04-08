namespace ProjectJiraInt
{
    partial class SyncJiraRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SyncJiraRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.syncJiraGroup = this.Factory.CreateRibbonGroup();
            this.btnSync = this.Factory.CreateRibbonButton();
            this.btnSettings = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.syncJiraGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.syncJiraGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // syncJiraGroup
            // 
            this.syncJiraGroup.Items.Add(this.btnSync);
            this.syncJiraGroup.Items.Add(this.btnSettings);
            this.syncJiraGroup.Label = "Sync JIRA";
            this.syncJiraGroup.Name = "syncJiraGroup";
            // 
            // btnSync
            // 
            this.btnSync.Label = "Sync";
            this.btnSync.Name = "btnSync";
            this.btnSync.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSync_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Label = "Settings";
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSettings_Click);
            // 
            // SyncJiraRibbon
            // 
            this.Name = "SyncJiraRibbon";
            this.RibbonType = "Microsoft.Project.Project";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SyncJiraRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.syncJiraGroup.ResumeLayout(false);
            this.syncJiraGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup syncJiraGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSync;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSettings;
    }

    partial class ThisRibbonCollection
    {
        internal SyncJiraRibbon SyncJiraRibbon
        {
            get { return this.GetRibbon<SyncJiraRibbon>(); }
        }
    }
}
