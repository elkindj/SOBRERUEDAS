
namespace TallerMecanico
{
    partial class FrmUsuario
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtApellidoPa = new System.Windows.Forms.TextBox();
            this.txtPallidoMa = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.cbTipDocumento = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtApellidoPa
            // 
            this.txtApellidoPa.Location = new System.Drawing.Point(135, 113);
            this.txtApellidoPa.Name = "txtApellidoPa";
            this.txtApellidoPa.Size = new System.Drawing.Size(228, 20);
            this.txtApellidoPa.TabIndex = 2;
            this.txtApellidoPa.TextChanged += new System.EventHandler(this.txtApellidoPa_TextChanged);
            // 
            // txtPallidoMa
            // 
            this.txtPallidoMa.Location = new System.Drawing.Point(135, 139);
            this.txtPallidoMa.Name = "txtPallidoMa";
            this.txtPallidoMa.Size = new System.Drawing.Size(228, 20);
            this.txtPallidoMa.TabIndex = 3;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(135, 191);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(228, 20);
            this.txtNumDocumento.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(135, 217);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(228, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(135, 243);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(228, 20);
            this.txtContraseña.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Numero de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Usauario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Perfil";
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(135, 269);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(228, 21);
            this.cbPerfil.TabIndex = 18;
            // 
            // cbTipDocumento
            // 
            this.cbTipDocumento.FormattingEnabled = true;
            this.cbTipDocumento.Location = new System.Drawing.Point(135, 164);
            this.cbTipDocumento.Name = "cbTipDocumento";
            this.cbTipDocumento.Size = new System.Drawing.Size(228, 21);
            this.cbTipDocumento.TabIndex = 19;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(385, 163);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(160, 23);
            this.btnGrabar.TabIndex = 20;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(135, 296);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(228, 21);
            this.cbEstado.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Estado";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(385, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido1,
            this.Documento,
            this.Usuario});
            this.gridUsuarios.Location = new System.Drawing.Point(12, 339);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.RowHeadersVisible = false;
            this.gridUsuarios.RowHeadersWidth = 51;
            this.gridUsuarios.Size = new System.Drawing.Size(506, 193);
            this.gridUsuarios.TabIndex = 25;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Usu_Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido1
            // 
            this.Apellido1.DataPropertyName = "Usu_ApellidoPat";
            this.Apellido1.HeaderText = "Apellido Paterno";
            this.Apellido1.MinimumWidth = 6;
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            this.Apellido1.Width = 125;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Usu_Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usu_Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(365, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "Administración de usuarios";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(385, 134);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(160, 23);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 563);
            this.ControlBox = false;
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cbTipDocumento);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.txtPallidoMa);
            this.Controls.Add(this.txtApellidoPa);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmUsuario";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtApellidoPa;
        private System.Windows.Forms.TextBox txtPallidoMa;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.ComboBox cbTipDocumento;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNuevo;
    }
}