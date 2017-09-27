namespace OfficeOilToolKits
{
    partial class RibbonOOT : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonOOT()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnInsertRows = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnInsertColumns = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.group7 = this.Factory.CreateRibbonGroup();
            this.btnGeoTimes = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group7.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Groups.Add(this.group6);
            this.tab1.Groups.Add(this.group7);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnInsertRows);
            this.group1.Label = "行";
            this.group1.Name = "group1";
            // 
            // btnInsertRows
            // 
            this.btnInsertRows.Label = "插入多行";
            this.btnInsertRows.Name = "btnInsertRows";
            this.btnInsertRows.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsertLine_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnInsertColumns);
            this.group2.Label = "列";
            this.group2.Name = "group2";
            // 
            // btnInsertColumns
            // 
            this.btnInsertColumns.Label = "插入多列";
            this.btnInsertColumns.Name = "btnInsertColumns";
            // 
            // group3
            // 
            this.group3.Label = "中国区域图";
            this.group3.Name = "group3";
            // 
            // group4
            // 
            this.group4.Label = "小层平面";
            this.group4.Name = "group4";
            // 
            // group5
            // 
            this.group5.Label = "剖面";
            this.group5.Name = "group5";
            // 
            // group6
            // 
            this.group6.Label = "表格和数据";
            this.group6.Name = "group6";
            // 
            // group7
            // 
            this.group7.Items.Add(this.btnGeoTimes);
            this.group7.Label = "其它";
            this.group7.Name = "group7";
            // 
            // btnGeoTimes
            // 
            this.btnGeoTimes.Label = "地质年代表";
            this.btnGeoTimes.Name = "btnGeoTimes";
            // 
            // RibbonOOT
            // 
            this.Name = "RibbonOOT";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group7.ResumeLayout(false);
            this.group7.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertRows;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertColumns;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGeoTimes;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonOOT Ribbon1
        {
            get { return this.GetRibbon<RibbonOOT>(); }
        }
    }
}
