namespace QLTKNGANHANG.ucHOME
{
    partial class ucTrangChu
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tbl_logBalanceTableAdapter = new QLTKNGANHANG.dbo_bankAccountDataSet1TableAdapters.tbl_logBalanceTableAdapter();
            this.tbllogBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_bankAccountDataSet1 = new QLTKNGANHANG.dbo_bankAccountDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_bankAccountDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataAdapter = this.tbl_logBalanceTableAdapter;
            this.chartControl1.DataSource = this.tbllogBalanceBindingSource;
            xyDiagram1.AxisX.MinorCount = 1;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V}";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.IndicatorsPaletteName = "Apex";
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(5, 3);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "logBalance_date";
            series1.Name = "Số tiền";
            series1.ValueDataMembersSerializable = "sodu";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = lineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(1645, 786);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Biểu đồ số lượng tiền giao dịch của khách hàng";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // tbl_logBalanceTableAdapter
            // 
            this.tbl_logBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // tbllogBalanceBindingSource
            // 
            this.tbllogBalanceBindingSource.DataMember = "tbl_logBalance";
            this.tbllogBalanceBindingSource.DataSource = this.dbo_bankAccountDataSet1;
            // 
            // dbo_bankAccountDataSet1
            // 
            this.dbo_bankAccountDataSet1.DataSetName = "dbo_bankAccountDataSet1";
            this.dbo_bankAccountDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.chartControl1);
            this.Name = "ucTrangChu";
            this.Size = new System.Drawing.Size(1650, 833);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_bankAccountDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private dbo_bankAccountDataSet1TableAdapters.tbl_logBalanceTableAdapter tbl_logBalanceTableAdapter;
        private System.Windows.Forms.BindingSource tbllogBalanceBindingSource;
        private dbo_bankAccountDataSet1 dbo_bankAccountDataSet1;
    }
}
