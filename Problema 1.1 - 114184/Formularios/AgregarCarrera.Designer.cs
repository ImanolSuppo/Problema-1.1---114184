namespace Problema_1._1___114184.Presentacion
{
    partial class AgregarCarrera
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
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.rbtSegundo = new System.Windows.Forms.RadioButton();
            this.rbtPrimero = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.LblProPresupuesto = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CboMateria = new System.Windows.Forms.ComboBox();
            this.TxtAnioCursado = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(139, 47);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(458, 20);
            this.txtCarrera.TabIndex = 49;
            // 
            // rbtSegundo
            // 
            this.rbtSegundo.AutoSize = true;
            this.rbtSegundo.Location = new System.Drawing.Point(287, 123);
            this.rbtSegundo.Name = "rbtSegundo";
            this.rbtSegundo.Size = new System.Drawing.Size(68, 17);
            this.rbtSegundo.TabIndex = 52;
            this.rbtSegundo.TabStop = true;
            this.rbtSegundo.Text = "Segundo";
            this.rbtSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtPrimero
            // 
            this.rbtPrimero.AutoSize = true;
            this.rbtPrimero.Location = new System.Drawing.Point(140, 123);
            this.rbtPrimero.Name = "rbtPrimero";
            this.rbtPrimero.Size = new System.Drawing.Size(60, 17);
            this.rbtPrimero.TabIndex = 51;
            this.rbtPrimero.TabStop = true;
            this.rbtPrimero.Text = "Primero";
            this.rbtPrimero.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Materia";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.Location = new System.Drawing.Point(54, 50);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(41, 13);
            this.LblDescuento.TabIndex = 61;
            this.LblDescuento.Text = "Carrera";
            // 
            // LblProPresupuesto
            // 
            this.LblProPresupuesto.AutoSize = true;
            this.LblProPresupuesto.Location = new System.Drawing.Point(52, 18);
            this.LblProPresupuesto.Name = "LblProPresupuesto";
            this.LblProPresupuesto.Size = new System.Drawing.Size(63, 13);
            this.LblProPresupuesto.TabIndex = 60;
            this.LblProPresupuesto.Text = "Detalle Nro:";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(52, 123);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(65, 13);
            this.LblCliente.TabIndex = 59;
            this.LblCliente.Text = "Cuatrimestre";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColProd,
            this.ColAccion});
            this.dgvDetalles.Location = new System.Drawing.Point(55, 207);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(694, 177);
            this.dgvDetalles.TabIndex = 58;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick_1);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColProd
            // 
            this.ColProd.HeaderText = "Materia";
            this.ColProd.Name = "ColProd";
            this.ColProd.ReadOnly = true;
            this.ColProd.Width = 200;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Acciones";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Text = "QUITAR";
            this.ColAccion.Width = 250;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(674, 162);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 54;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(522, 409);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 56;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(242, 409);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 55;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click_1);
            // 
            // CboMateria
            // 
            this.CboMateria.FormattingEnabled = true;
            this.CboMateria.Location = new System.Drawing.Point(139, 162);
            this.CboMateria.Name = "CboMateria";
            this.CboMateria.Size = new System.Drawing.Size(458, 21);
            this.CboMateria.TabIndex = 53;
            // 
            // TxtAnioCursado
            // 
            this.TxtAnioCursado.Location = new System.Drawing.Point(139, 84);
            this.TxtAnioCursado.Name = "TxtAnioCursado";
            this.TxtAnioCursado.Size = new System.Drawing.Size(86, 20);
            this.TxtAnioCursado.TabIndex = 50;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(52, 87);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(26, 13);
            this.LblFecha.TabIndex = 57;
            this.LblFecha.Text = "Año";
            // 
            // AgregarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.rbtSegundo);
            this.Controls.Add(this.rbtPrimero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDescuento);
            this.Controls.Add(this.LblProPresupuesto);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CboMateria);
            this.Controls.Add(this.TxtAnioCursado);
            this.Controls.Add(this.LblFecha);
            this.Name = "AgregarCarrera";
            this.Text = "AgregarCarrera";
            this.Load += new System.EventHandler(this.AgregarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.RadioButton rbtSegundo;
        private System.Windows.Forms.RadioButton rbtPrimero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label LblProPresupuesto;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CboMateria;
        private System.Windows.Forms.TextBox TxtAnioCursado;
        private System.Windows.Forms.Label LblFecha;
    }
}