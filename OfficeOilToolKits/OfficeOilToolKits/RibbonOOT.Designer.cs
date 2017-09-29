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
            this.btnInsertColumns = this.Factory.CreateRibbonButton();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.btnCheckDepth = this.Factory.CreateRibbonButton();
            this.btnDepth2Layer = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.btnWellPosition = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.btnDrawLog = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btnChinaProvince = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group7 = this.Factory.CreateRibbonGroup();
            this.btnGeoTimes = this.Factory.CreateRibbonButton();
            this.btnVolSedi = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group6.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.group3.SuspendLayout();
            this.group7.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group6);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group7);
            this.tab1.Label = "石油工具包";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnInsertRows);
            this.group1.Items.Add(this.btnInsertColumns);
            this.group1.Label = "行列快捷处理";
            this.group1.Name = "group1";
            // 
            // btnInsertRows
            // 
            this.btnInsertRows.Label = "插入多行";
            this.btnInsertRows.Name = "btnInsertRows";
            this.btnInsertRows.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsertLine_Click);
            // 
            // btnInsertColumns
            // 
            this.btnInsertColumns.Label = "插入多列";
            this.btnInsertColumns.Name = "btnInsertColumns";
            // 
            // group6
            // 
            this.group6.Items.Add(this.btnCheckDepth);
            this.group6.Items.Add(this.btnDepth2Layer);
            this.group6.Items.Add(this.button1);
            this.group6.Label = "数据统计及绘图";
            this.group6.Name = "group6";
            // 
            // btnCheckDepth
            // 
            this.btnCheckDepth.Label = "顶底深校验";
            this.btnCheckDepth.Name = "btnCheckDepth";
            // 
            // btnDepth2Layer
            // 
            this.btnDepth2Layer.Label = "深度归小层";
            this.btnDepth2Layer.Name = "btnDepth2Layer";
            // 
            // button1
            // 
            this.button1.Label = "孔隙度频率直方图";
            this.button1.Name = "button1";
            // 
            // group4
            // 
            this.group4.Items.Add(this.btnWellPosition);
            this.group4.Label = "小层平面";
            this.group4.Name = "group4";
            // 
            // btnWellPosition
            // 
            this.btnWellPosition.Label = "井位图";
            this.btnWellPosition.Name = "btnWellPosition";
            this.btnWellPosition.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnWellPosition_Click);
            // 
            // group5
            // 
            this.group5.Items.Add(this.btnDrawLog);
            this.group5.Label = "剖面分析";
            this.group5.Name = "group5";
            // 
            // btnDrawLog
            // 
            this.btnDrawLog.Label = "绘制测井曲线";
            this.btnDrawLog.Name = "btnDrawLog";
            this.btnDrawLog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDrawLog_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btnChinaProvince);
            this.group3.Label = "区域管理分析";
            this.group3.Name = "group3";
            // 
            // btnChinaProvince
            // 
            this.btnChinaProvince.Label = "中国地图";
            this.btnChinaProvince.Name = "btnChinaProvince";
            this.btnChinaProvince.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnChinaProvince_Click);
            // 
            // group2
            // 
            this.group2.Label = "网络";
            this.group2.Name = "group2";
            // 
            // group7
            // 
            this.group7.Items.Add(this.btnGeoTimes);
            this.group7.Items.Add(this.btnVolSedi);
            this.group7.Label = "其它";
            this.group7.Name = "group7";
            // 
            // btnGeoTimes
            // 
            this.btnGeoTimes.Label = "地质年代表";
            this.btnGeoTimes.Name = "btnGeoTimes";
            // 
            // btnVolSedi
            // 
            this.btnVolSedi.Label = "沉积物清水沉降速度(Rubey,1931)";
            this.btnVolSedi.Name = "btnVolSedi";
            this.btnVolSedi.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnVolSedi_Click);
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
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnChinaProvince;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnWellPosition;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCheckDepth;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDepth2Layer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnVolSedi;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDrawLog;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonOOT Ribbon1
        {
            get { return this.GetRibbon<RibbonOOT>(); }
        }
    }
}
