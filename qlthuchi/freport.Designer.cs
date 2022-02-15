namespace qlthuchi
{
    partial class freport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(freport));
            this.USP_infothurpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlthuchiDataSet1 = new qlthuchi.qlthuchiDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_infothurpTableAdapter = new qlthuchi.qlthuchiDataSet1TableAdapters.USP_infothurpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_infothurpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlthuchiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_infothurpBindingSource
            // 
            this.USP_infothurpBindingSource.DataMember = "USP_infothurp";
            this.USP_infothurpBindingSource.DataSource = this.qlthuchiDataSet1;
            // 
            // qlthuchiDataSet1
            // 
            this.qlthuchiDataSet1.DataSetName = "qlthuchiDataSet1";
            this.qlthuchiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_infothurpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "qlthuchi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // USP_infothurpTableAdapter
            // 
            this.USP_infothurpTableAdapter.ClearBeforeFill = true;
            // 
            // freport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "freport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thu";
            this.Load += new System.EventHandler(this.freport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_infothurpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlthuchiDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_infothurpBindingSource;
        private qlthuchiDataSet1 qlthuchiDataSet1;
        private qlthuchiDataSet1TableAdapters.USP_infothurpTableAdapter USP_infothurpTableAdapter;
    }
}