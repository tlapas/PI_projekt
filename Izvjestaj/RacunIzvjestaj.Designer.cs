namespace PI_projekt.Izvjestaj
{
    partial class RacunIzvjestaj
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
            this.kinoDBDataSet = new PI_projekt.KinoDBDataSet();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.RacunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Racun";
            reportDataSource1.Value = this.racunBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // kinoDBDataSet
            // 
            this.kinoDBDataSet.DataSetName = "KinoDBDataSet";
            this.kinoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // RacunIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 445);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RacunIzvjestaj";
            this.Text = "RacunIzvjestaj";
            this.Load += new System.EventHandler(this.RacunIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private KinoDBDataSet kinoDBDataSet;
        private KinoDBDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
    }
}