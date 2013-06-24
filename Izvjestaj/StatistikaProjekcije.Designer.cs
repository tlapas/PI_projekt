namespace PI_projekt.Izvjestaj
{
    partial class StatistikaProjekcije
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.projekcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDBDataSet = new PI_projekt.KinoDBDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projekcijaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ProjekcijaTableAdapter();
            this.filmTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.FilmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projekcijaBindingSource
            // 
            this.projekcijaBindingSource.DataMember = "Projekcija";
            this.projekcijaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // kinoDBDataSet
            // 
            this.kinoDBDataSet.DataSetName = "KinoDBDataSet";
            this.kinoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Projekcija";
            reportDataSource1.Value = this.projekcijaBindingSource;
            reportDataSource2.Name = "Film";
            reportDataSource2.Value = this.filmBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptProjekcije.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(708, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // projekcijaTableAdapter
            // 
            this.projekcijaTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // StatistikaProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StatistikaProjekcije";
            this.Text = "StatistikaProjekcije";
            this.Load += new System.EventHandler(this.StatistikaProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource projekcijaBindingSource;
        private KinoDBDataSet kinoDBDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private KinoDBDataSetTableAdapters.ProjekcijaTableAdapter projekcijaTableAdapter;
        private KinoDBDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
    }
}