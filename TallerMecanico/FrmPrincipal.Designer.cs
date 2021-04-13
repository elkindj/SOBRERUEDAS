
namespace TallerMecanico
{
    partial class FrmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tSMAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.DodgerBlue;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMAdministracion,
            this.tSmInventario,
            this.mantenimientoToolStripMenuItem,
            this.tSmSalir});
            this.mnuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(148, 624);
            this.mnuPrincipal.TabIndex = 0;
            // 
            // tSMAdministracion
            // 
            this.tSMAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMUsuarios});
            this.tSMAdministracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tSMAdministracion.ForeColor = System.Drawing.Color.White;
            this.tSMAdministracion.Image = global::TallerMecanico.Properties.Resources.user;
            this.tSMAdministracion.Name = "tSMAdministracion";
            this.tSMAdministracion.Size = new System.Drawing.Size(135, 24);
            this.tSMAdministracion.Text = "Administración";
            this.tSMAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSMUsuarios
            // 
            this.tSMUsuarios.Name = "tSMUsuarios";
<<<<<<< HEAD
            this.tSMUsuarios.Size = new System.Drawing.Size(224, 28);
=======
            this.tSMUsuarios.Size = new System.Drawing.Size(135, 24);
>>>>>>> 77a6aa87592b9049674df08e685ab1e4e381d53d
            this.tSMUsuarios.Text = "Usuarios";
            this.tSMUsuarios.Click += new System.EventHandler(this.tSMUsuarios_Click);
            // 
            // tSmInventario
            // 
            this.tSmInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMCategoria,
            this.tSMProducto,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.tSmInventario.ForeColor = System.Drawing.Color.White;
            this.tSmInventario.Image = global::TallerMecanico.Properties.Resources.inventario;
            this.tSmInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSmInventario.Name = "tSmInventario";
            this.tSmInventario.Size = new System.Drawing.Size(135, 24);
            this.tSmInventario.Text = "Inventario";
            this.tSmInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSMCategoria
            // 
            this.tSMCategoria.Name = "tSMCategoria";
            this.tSMCategoria.Size = new System.Drawing.Size(150, 24);
            this.tSMCategoria.Text = "Categorias";
            this.tSMCategoria.Click += new System.EventHandler(this.tSMCategoria_Click);
            // 
            // tSMProducto
            // 
            this.tSMProducto.Name = "tSMProducto";
            this.tSMProducto.Size = new System.Drawing.Size(150, 24);
            this.tSMProducto.Text = "Productos";
            this.tSMProducto.Click += new System.EventHandler(this.tSMProducto_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.mantenimientoToolStripMenuItem1});
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(135, 23);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(179, 24);
            this.mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            // 
            // tSmSalir
            // 
            this.tSmSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tSmSalir.ForeColor = System.Drawing.Color.White;
            this.tSmSalir.Image = global::TallerMecanico.Properties.Resources.Salir;
            this.tSmSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSmSalir.Name = "tSmSalir";
            this.tSmSalir.Size = new System.Drawing.Size(135, 24);
            this.tSmSalir.Text = "Salir";
            this.tSmSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSmSalir.Click += new System.EventHandler(this.tSmSalir_Click);
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActual.Location = new System.Drawing.Point(12, 566);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(67, 18);
            this.lblUsuarioActual.TabIndex = 2;
            this.lblUsuarioActual.Text = "Usuario";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 624);
            this.ControlBox = false;
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tSMAdministracion;
        private System.Windows.Forms.ToolStripMenuItem tSmSalir;
        private System.Windows.Forms.ToolStripMenuItem tSMUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tSmInventario;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSMCategoria;
        private System.Windows.Forms.ToolStripMenuItem tSMProducto;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}