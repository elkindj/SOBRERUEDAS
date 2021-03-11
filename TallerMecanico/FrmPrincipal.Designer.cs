
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.tSmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMCategoria,
            this.tSMProducto,
            this.tSMUsuarios});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // tSMUsuarios
            // 
            this.tSMUsuarios.Name = "tSMUsuarios";
            this.tSMUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tSMUsuarios.Text = "Usuarios";
            this.tSMUsuarios.Click += new System.EventHandler(this.tSMUsuarios_Click);
            // 
            // tSMCategoria
            // 
            this.tSMCategoria.Name = "tSMCategoria";
            this.tSMCategoria.Size = new System.Drawing.Size(180, 22);
            this.tSMCategoria.Text = "Categorias";
            this.tSMCategoria.Click += new System.EventHandler(this.tSMCategoria_Click);
            // 
            // tSmSalir
            // 
            this.tSmSalir.Name = "tSmSalir";
            this.tSmSalir.Size = new System.Drawing.Size(41, 20);
            this.tSmSalir.Text = "Salir";
            this.tSmSalir.Click += new System.EventHandler(this.tSmSalir_Click);
            // 
            // tSMProducto
            // 
            this.tSMProducto.Name = "tSMProducto";
            this.tSMProducto.Size = new System.Drawing.Size(180, 22);
            this.tSMProducto.Text = "Productos";
            this.tSMProducto.Click += new System.EventHandler(this.tSMProducto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSmSalir;
        private System.Windows.Forms.ToolStripMenuItem tSMUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tSMCategoria;
        private System.Windows.Forms.ToolStripMenuItem tSMProducto;
    }
}