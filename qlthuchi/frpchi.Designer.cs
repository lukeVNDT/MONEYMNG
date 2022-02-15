namespace qlthuchi
{
    partial class frpchi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frpchi));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlthuchiDataSet2 = new qlthuchi.qlthuchiDataSet2();
            this.USP_chiinforpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_chiinforpTableAdapter = new qlthuchi.qlthuchiDataSet2TableAdapters.USP_chiinforpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlthuchiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_chiinforpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.USP_chiinforpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "qlthuchi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 8);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // qlthuchiDataSet2
            // 
            this.qlthuchiDataSet2.DataSetName = "qlthuchiDataSet2";
            this.qlthuchiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_chiinforpBindingSource
            // 
            this.USP_chiinforpBindingSource.DataMember = "USP_chiinforp";
            this.USP_chiinforpBindingSource.DataSource = this.qlthuchiDataSet2;
            // 
            // USP_chiinforpTableAdapter
            // 
            this.USP_chiinforpTableAdapter.ClearBeforeFill = true;
            // 
            // frpchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frpchi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo chi";
            this.Load += new System.EventHandler(this.frpchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlthuchiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_chiinforpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_chiinforpBindingSource;
        private qlthuchiDataSet2 qlthuchiDataSet2;
        private qlthuchiDataSet2TableAdapters.USP_chiinforpTableAdapter USP_chiinforpTableAdapter;
    }
}