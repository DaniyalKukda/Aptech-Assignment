namespace MusicCompany
{
    partial class SingerRPT
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.musicCompanyDataSet = new MusicCompany.musicCompanyDataSet();
            this.singerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singerTableAdapter = new MusicCompany.musicCompanyDataSetTableAdapters.singerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.musicCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkRed;
            this.reportViewer1.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.ForeColor = System.Drawing.SystemColors.ControlDark;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.singerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MusicCompany.singerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 303);
            this.reportViewer1.TabIndex = 0;
            // 
            // musicCompanyDataSet
            // 
            this.musicCompanyDataSet.DataSetName = "musicCompanyDataSet";
            this.musicCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singerBindingSource
            // 
            this.singerBindingSource.DataMember = "singer";
            this.singerBindingSource.DataSource = this.musicCompanyDataSet;
            // 
            // singerTableAdapter
            // 
            this.singerTableAdapter.ClearBeforeFill = true;
            // 
            // SingerRPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 327);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SingerRPT";
            this.Text = "SingerRPT";
            this.Load += new System.EventHandler(this.SingerRPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource singerBindingSource;
        private musicCompanyDataSet musicCompanyDataSet;
        private musicCompanyDataSetTableAdapters.singerTableAdapter singerTableAdapter;
    }
}