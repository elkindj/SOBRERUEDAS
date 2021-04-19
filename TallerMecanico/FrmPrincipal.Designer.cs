
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnAdministrar = new System.Windows.Forms.Panel();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.btnAdministrar = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnFrmPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.pnInventario = new System.Windows.Forms.Panel();
            this.bntMantenimiento = new FontAwesome.Sharp.IconButton();
            this.pnMantenimiento = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnCategoria = new FontAwesome.Sharp.IconButton();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.btnCompra = new FontAwesome.Sharp.IconButton();
            this.btnVenta = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnVehiculo = new FontAwesome.Sharp.IconButton();
            this.btnMantenimientoIn = new FontAwesome.Sharp.IconButton();
            this.pnMenu.SuspendLayout();
            this.pnAdministrar.SuspendLayout();
            this.pnFrmPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnInventario.SuspendLayout();
            this.pnMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(106)))), ((int)(((byte)(239)))));
            this.pnMenu.Controls.Add(this.btnSalir);
            this.pnMenu.Controls.Add(this.pnMantenimiento);
            this.pnMenu.Controls.Add(this.bntMantenimiento);
            this.pnMenu.Controls.Add(this.pnInventario);
            this.pnMenu.Controls.Add(this.btnInventario);
            this.pnMenu.Controls.Add(this.pnAdministrar);
            this.pnMenu.Controls.Add(this.btnAdministrar);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(172, 587);
            this.pnMenu.TabIndex = 0;
            // 
            // pnAdministrar
            // 
            this.pnAdministrar.Controls.Add(this.btnUsuario);
            this.pnAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAdministrar.Location = new System.Drawing.Point(0, 135);
            this.pnAdministrar.Name = "pnAdministrar";
            this.pnAdministrar.Size = new System.Drawing.Size(172, 50);
            this.pnAdministrar.TabIndex = 9;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Silver;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnUsuario.IconColor = System.Drawing.Color.White;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.IconSize = 24;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(172, 25);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ForeColor = System.Drawing.Color.White;
            this.btnAdministrar.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnAdministrar.IconColor = System.Drawing.Color.White;
            this.btnAdministrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrar.IconSize = 24;
            this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.Location = new System.Drawing.Point(0, 100);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(172, 35);
            this.btnAdministrar.TabIndex = 8;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(172, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // pnFrmPrincipal
            // 
            this.pnFrmPrincipal.Controls.Add(this.pictureBox1);
            this.pnFrmPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFrmPrincipal.Location = new System.Drawing.Point(172, 0);
            this.pnFrmPrincipal.Name = "pnFrmPrincipal";
            this.pnFrmPrincipal.Size = new System.Drawing.Size(878, 587);
            this.pnFrmPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 24;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 185);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(172, 35);
            this.btnInventario.TabIndex = 10;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pnInventario
            // 
            this.pnInventario.Controls.Add(this.btnVenta);
            this.pnInventario.Controls.Add(this.btnCompra);
            this.pnInventario.Controls.Add(this.btnProducto);
            this.pnInventario.Controls.Add(this.btnCategoria);
            this.pnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInventario.Location = new System.Drawing.Point(0, 220);
            this.pnInventario.Name = "pnInventario";
            this.pnInventario.Size = new System.Drawing.Size(172, 125);
            this.pnInventario.TabIndex = 11;
            // 
            // bntMantenimiento
            // 
            this.bntMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntMantenimiento.FlatAppearance.BorderSize = 0;
            this.bntMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMantenimiento.ForeColor = System.Drawing.Color.White;
            this.bntMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.bntMantenimiento.IconColor = System.Drawing.Color.White;
            this.bntMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntMantenimiento.IconSize = 24;
            this.bntMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntMantenimiento.Location = new System.Drawing.Point(0, 345);
            this.bntMantenimiento.Name = "bntMantenimiento";
            this.bntMantenimiento.Size = new System.Drawing.Size(172, 35);
            this.bntMantenimiento.TabIndex = 12;
            this.bntMantenimiento.Text = "Mantenimiento";
            this.bntMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntMantenimiento.UseVisualStyleBackColor = true;
            this.bntMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // pnMantenimiento
            // 
            this.pnMantenimiento.Controls.Add(this.btnMantenimientoIn);
            this.pnMantenimiento.Controls.Add(this.btnVehiculo);
            this.pnMantenimiento.Controls.Add(this.btnCliente);
            this.pnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMantenimiento.Location = new System.Drawing.Point(0, 380);
            this.pnMantenimiento.Name = "pnMantenimiento";
            this.pnMantenimiento.Size = new System.Drawing.Size(172, 100);
            this.pnMantenimiento.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 24;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.Silver;
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.btnCategoria.IconColor = System.Drawing.Color.White;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.IconSize = 24;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(172, 25);
            this.btnCategoria.TabIndex = 10;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.brnCategoria_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnProducto.IconColor = System.Drawing.Color.White;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 24;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 25);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProducto.Size = new System.Drawing.Size(172, 25);
            this.btnProducto.TabIndex = 11;
            this.btnProducto.Text = "Productos";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.Silver;
            this.btnCompra.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnCompra.IconColor = System.Drawing.Color.White;
            this.btnCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompra.IconSize = 24;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(0, 50);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCompra.Size = new System.Drawing.Size(172, 25);
            this.btnCompra.TabIndex = 12;
            this.btnCompra.Text = "Compras";
            this.btnCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.Silver;
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnVenta.IconColor = System.Drawing.Color.White;
            this.btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenta.IconSize = 24;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(0, 75);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVenta.Size = new System.Drawing.Size(172, 25);
            this.btnVenta.TabIndex = 13;
            this.btnVenta.Text = "Ventas";
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCliente.IconColor = System.Drawing.Color.White;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 24;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(172, 25);
            this.btnCliente.TabIndex = 14;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculo.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculo.ForeColor = System.Drawing.Color.Silver;
            this.btnVehiculo.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnVehiculo.IconColor = System.Drawing.Color.White;
            this.btnVehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVehiculo.IconSize = 24;
            this.btnVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculo.Location = new System.Drawing.Point(0, 25);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVehiculo.Size = new System.Drawing.Size(172, 25);
            this.btnVehiculo.TabIndex = 15;
            this.btnVehiculo.Text = "Vehiculos";
            this.btnVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnMantenimientoIn
            // 
            this.btnMantenimientoIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoIn.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoIn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnMantenimientoIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoIn.ForeColor = System.Drawing.Color.Silver;
            this.btnMantenimientoIn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnMantenimientoIn.IconColor = System.Drawing.Color.White;
            this.btnMantenimientoIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoIn.IconSize = 24;
            this.btnMantenimientoIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoIn.Location = new System.Drawing.Point(0, 50);
            this.btnMantenimientoIn.Name = "btnMantenimientoIn";
            this.btnMantenimientoIn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMantenimientoIn.Size = new System.Drawing.Size(172, 25);
            this.btnMantenimientoIn.TabIndex = 16;
            this.btnMantenimientoIn.Text = "Mantenimiento";
            this.btnMantenimientoIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenimientoIn.UseVisualStyleBackColor = true;
            this.btnMantenimientoIn.Click += new System.EventHandler(this.btnMantenimientoIn_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 587);
            this.Controls.Add(this.pnFrmPrincipal);
            this.Controls.Add(this.pnMenu);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal2";
            this.pnMenu.ResumeLayout(false);
            this.pnAdministrar.ResumeLayout(false);
            this.pnFrmPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnInventario.ResumeLayout(false);
            this.pnMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnFrmPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAdministrar;
        private System.Windows.Forms.Panel pnAdministrar;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel pnMantenimiento;
        private FontAwesome.Sharp.IconButton btnMantenimientoIn;
        private FontAwesome.Sharp.IconButton btnVehiculo;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton bntMantenimiento;
        private System.Windows.Forms.Panel pnInventario;
        private FontAwesome.Sharp.IconButton btnVenta;
        private FontAwesome.Sharp.IconButton btnCompra;
        private FontAwesome.Sharp.IconButton btnProducto;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private FontAwesome.Sharp.IconButton btnInventario;
    }
}