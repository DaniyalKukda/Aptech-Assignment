namespace inventaryManagementSystem
{
    partial class Form2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet2 = new inventaryManagementSystem.DataSet2();
            this.order_item1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_item1TableAdapter = new inventaryManagementSystem.DataSet2TableAdapters.order_item1TableAdapter();
            this.Custompurchase = new inventaryManagementSystem.Custompurchase();
            this.PurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PurchaseTableAdapter = new inventaryManagementSystem.CustompurchaseTableAdapters.PurchaseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_item1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Custompurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PurchaseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "inventaryManagementSystem.ReportCP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(755, 245);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_item1BindingSource
            // 
            this.order_item1BindingSource.DataMember = "order_item1";
            this.order_item1BindingSource.DataSource = this.DataSet2;
            // 
            // order_item1TableAdapter
            // 
            this.order_item1TableAdapter.ClearBeforeFill = true;
            // 
            // Custompurchase
            // 
            this.Custompurchase.DataSetName = "Custompurchase";
            this.Custompurchase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PurchaseBindingSource
            // 
            this.PurchaseBindingSource.DataMember = "Purchase";
            this.PurchaseBindingSource.DataSource = this.Custompurchase;
            // 
            // PurchaseTableAdapter
            // 
            this.PurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(428, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_item1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Custompurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource order_item1BindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.order_item1TableAdapter order_item1TableAdapter;
        private System.Windows.Forms.BindingSource PurchaseBindingSource;
        private Custompurchase Custompurchase;
        private CustompurchaseTableAdapters.PurchaseTableAdapter PurchaseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}