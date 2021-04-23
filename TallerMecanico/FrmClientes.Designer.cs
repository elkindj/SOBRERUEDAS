
namespace TallerMecanico
{
    partial class FrmClientes
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtTarjetaOp = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliCategoriaConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliLicenciaTransito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliTarjetaOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbControl.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdConductor,
            this.CliNombres,
            this.CliApellidos,
            this.CliCorreo,
            this.CliEmpresa,
            this.CliCategoriaConductor,
            this.CliLicenciaTransito,
            this.CliTarjetaOperacion});
            this.dgvDatos.Location = new System.Drawing.Point(66, 288);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(747, 150);
            this.dgvDatos.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(55, 51);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(55, 80);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(55, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnNuevo);
            this.gbControl.Controls.Add(this.btnEditar);
            this.gbControl.Controls.Add(this.btnGrabar);
            this.gbControl.Location = new System.Drawing.Point(683, 62);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(181, 195);
            this.gbControl.TabIndex = 7;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "groupBox1";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtTarjetaOp);
            this.gbDatos.Controls.Add(this.txtLicencia);
            this.gbDatos.Controls.Add(this.txtCategoria);
            this.gbDatos.Controls.Add(this.txtCorreo);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Location = new System.Drawing.Point(66, 25);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(522, 232);
            this.gbDatos.TabIndex = 8;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "groupBox2";
            // 
            // txtTarjetaOp
            // 
            this.txtTarjetaOp.Location = new System.Drawing.Point(148, 178);
            this.txtTarjetaOp.Name = "txtTarjetaOp";
            this.txtTarjetaOp.Size = new System.Drawing.Size(280, 20);
            this.txtTarjetaOp.TabIndex = 6;
            this.txtTarjetaOp.TextChanged += new System.EventHandler(this.txtTarjetaOp_TextChanged);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(148, 153);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(280, 20);
            this.txtLicencia.TabIndex = 5;
            this.txtLicencia.TextChanged += new System.EventHandler(this.txtLicencia_TextChanged);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(148, 126);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(280, 20);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(148, 99);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(280, 20);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(148, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(148, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Licencia";
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IdConductor
            // 
            this.IdConductor.HeaderText = "cédula";
            this.IdConductor.Name = "IdConductor";
            // 
            // CliNombres
            // 
            this.CliNombres.HeaderText = "Nombres";
            this.CliNombres.Name = "CliNombres";
            // 
            // CliApellidos
            // 
            this.CliApellidos.HeaderText = "Apellidos";
            this.CliApellidos.Name = "CliApellidos";
            // 
            // CliCorreo
            // 
            this.CliCorreo.HeaderText = "Correo";
            this.CliCorreo.Name = "CliCorreo";
            // 
            // CliEmpresa
            // 
            this.CliEmpresa.HeaderText = "Empresa";
            this.CliEmpresa.Name = "CliEmpresa";
            this.CliEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CliEmpresa.Visible = false;
            // 
            // CliCategoriaConductor
            // 
            this.CliCategoriaConductor.HeaderText = "Categoria Conductor";
            this.CliCategoriaConductor.Name = "CliCategoriaConductor";
            // 
            // CliLicenciaTransito
            // 
            this.CliLicenciaTransito.HeaderText = "Licencia";
            this.CliLicenciaTransito.Name = "CliLicenciaTransito";
            // 
            // CliTarjetaOperacion
            // 
            this.CliTarjetaOperacion.HeaderText = "Tarjeta Operación";
            this.CliTarjetaOperacion.Name = "CliTarjetaOperacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tarjeta de Operación";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gbControl);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbControl.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtTarjetaOp;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliCategoriaConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliLicenciaTransito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliTarjetaOperacion;
        private System.Windows.Forms.Label label7;
    }
}