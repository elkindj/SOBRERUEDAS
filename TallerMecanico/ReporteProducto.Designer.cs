﻿
namespace TallerMecanico
{
    partial class ReporteProducto
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
            this.DataSetProductos = new TallerMecanico.DataSetProductos();
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosTableAdapter = new TallerMecanico.DataSetProductosTableAdapters.ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DatasetProductos";
            reportDataSource1.Value = this.ProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.InventarioProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetProductos
            // 
            this.DataSetProductos.DataSetName = "DataSetProductos";
            this.DataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.DataSetProductos;
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProducto";
            this.Text = "ReporteProducto";
            this.Load += new System.EventHandler(this.ReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private DataSetProductos DataSetProductos;
        private DataSetProductosTableAdapters.ProductosTableAdapter ProductosTableAdapter;
    }
}