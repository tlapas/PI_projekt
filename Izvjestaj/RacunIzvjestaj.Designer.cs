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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kinoDBDataSet = new PI_projekt.KinoDBDataSet();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.RacunTableAdapter();
            this.nacinplacanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nacin_placanjaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.Nacin_placanjaTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ArtiklTableAdapter();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjerna_jedinicaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_racunaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.stavka_racunaTableAdapter();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.KartaTableAdapter();
            this.racunkartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racun_kartaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.racun_kartaTableAdapter();
            this.projekcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekcijaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.ProjekcijaTableAdapter();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.FilmTableAdapter();
            this.cijenaUlaznicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaUlaznicaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.CijenaUlaznicaTableAdapter();
            this.popustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popustTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.PopustTableAdapter();
            this.cijenaArtikalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaArtikalaTableAdapter = new PI_projekt.KinoDBDataSetTableAdapters.CijenaArtikalaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacinplacanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunkartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaUlaznicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaArtikalaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Racun";
            reportDataSource1.Value = this.racunBindingSource;
            reportDataSource2.Name = "NacinPlacanja";
            reportDataSource2.Value = this.nacinplacanjaBindingSource;
            reportDataSource3.Name = "Zaposlenik";
            reportDataSource3.Value = this.zaposlenikBindingSource;
            reportDataSource4.Name = "Artikl";
            reportDataSource4.Value = this.artiklBindingSource;
            reportDataSource5.Name = "MjernaJedinica";
            reportDataSource5.Value = this.mjernajedinicaBindingSource;
            reportDataSource6.Name = "StavkaRacuna";
            reportDataSource6.Value = this.stavkaracunaBindingSource;
            reportDataSource7.Name = "Karta";
            reportDataSource7.Value = this.kartaBindingSource;
            reportDataSource8.Name = "RacunKarta";
            reportDataSource8.Value = this.racunkartaBindingSource;
            reportDataSource9.Name = "Projekcija";
            reportDataSource9.Value = this.projekcijaBindingSource;
            reportDataSource10.Name = "Film";
            reportDataSource10.Value = this.filmBindingSource;
            reportDataSource11.Name = "CijenaUlaznica";
            reportDataSource11.Value = this.cijenaUlaznicaBindingSource;
            reportDataSource12.Name = "Popust";
            reportDataSource12.Value = this.popustBindingSource;
            reportDataSource13.Name = "CijenaArtikala";
            reportDataSource13.Value = this.cijenaArtikalaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_projekt.Izvjestaj.rptRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 476);
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
            // nacinplacanjaBindingSource
            // 
            this.nacinplacanjaBindingSource.DataMember = "Nacin_placanja";
            this.nacinplacanjaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // nacin_placanjaTableAdapter
            // 
            this.nacin_placanjaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // mjernajedinicaBindingSource
            // 
            this.mjernajedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjernajedinicaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "stavka_racuna";
            this.stavkaracunaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // kartaBindingSource
            // 
            this.kartaBindingSource.DataMember = "Karta";
            this.kartaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // kartaTableAdapter
            // 
            this.kartaTableAdapter.ClearBeforeFill = true;
            // 
            // racunkartaBindingSource
            // 
            this.racunkartaBindingSource.DataMember = "racun_karta";
            this.racunkartaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // racun_kartaTableAdapter
            // 
            this.racun_kartaTableAdapter.ClearBeforeFill = true;
            // 
            // projekcijaBindingSource
            // 
            this.projekcijaBindingSource.DataMember = "Projekcija";
            this.projekcijaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // projekcijaTableAdapter
            // 
            this.projekcijaTableAdapter.ClearBeforeFill = true;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // cijenaUlaznicaBindingSource
            // 
            this.cijenaUlaznicaBindingSource.DataMember = "CijenaUlaznica";
            this.cijenaUlaznicaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // cijenaUlaznicaTableAdapter
            // 
            this.cijenaUlaznicaTableAdapter.ClearBeforeFill = true;
            // 
            // popustBindingSource
            // 
            this.popustBindingSource.DataMember = "Popust";
            this.popustBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // popustTableAdapter
            // 
            this.popustTableAdapter.ClearBeforeFill = true;
            // 
            // cijenaArtikalaBindingSource
            // 
            this.cijenaArtikalaBindingSource.DataMember = "CijenaArtikala";
            this.cijenaArtikalaBindingSource.DataSource = this.kinoDBDataSet;
            // 
            // cijenaArtikalaTableAdapter
            // 
            this.cijenaArtikalaTableAdapter.ClearBeforeFill = true;
            // 
            // RacunIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RacunIzvjestaj";
            this.Text = "RacunIzvjestaj";
            this.Load += new System.EventHandler(this.RacunIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacinplacanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunkartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaUlaznicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaArtikalaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private KinoDBDataSet kinoDBDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private KinoDBDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource nacinplacanjaBindingSource;
        private KinoDBDataSetTableAdapters.Nacin_placanjaTableAdapter nacin_placanjaTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private KinoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private KinoDBDataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private KinoDBDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private KinoDBDataSetTableAdapters.stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.BindingSource kartaBindingSource;
        private KinoDBDataSetTableAdapters.KartaTableAdapter kartaTableAdapter;
        private System.Windows.Forms.BindingSource racunkartaBindingSource;
        private KinoDBDataSetTableAdapters.racun_kartaTableAdapter racun_kartaTableAdapter;
        private System.Windows.Forms.BindingSource projekcijaBindingSource;
        private KinoDBDataSetTableAdapters.ProjekcijaTableAdapter projekcijaTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private KinoDBDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource cijenaUlaznicaBindingSource;
        private KinoDBDataSetTableAdapters.CijenaUlaznicaTableAdapter cijenaUlaznicaTableAdapter;
        private System.Windows.Forms.BindingSource popustBindingSource;
        private KinoDBDataSetTableAdapters.PopustTableAdapter popustTableAdapter;
        private System.Windows.Forms.BindingSource cijenaArtikalaBindingSource;
        private KinoDBDataSetTableAdapters.CijenaArtikalaTableAdapter cijenaArtikalaTableAdapter;

    }
}