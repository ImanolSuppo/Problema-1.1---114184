namespace Problema_1._1___114184.Presentacion
{
    partial class Principal
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeMateriasPorCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.carrerasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCarreraToolStripMenuItem,
            this.eliminarCarreraToolStripMenuItem});
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            // 
            // agregarCarreraToolStripMenuItem
            // 
            this.agregarCarreraToolStripMenuItem.Name = "agregarCarreraToolStripMenuItem";
            this.agregarCarreraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarCarreraToolStripMenuItem.Text = "Agregar Carrera";
            this.agregarCarreraToolStripMenuItem.Click += new System.EventHandler(this.agregarCarreraToolStripMenuItem_Click);
            // 
            // eliminarCarreraToolStripMenuItem
            // 
            this.eliminarCarreraToolStripMenuItem.Name = "eliminarCarreraToolStripMenuItem";
            this.eliminarCarreraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarCarreraToolStripMenuItem.Text = "Eliminar Carrera";
            this.eliminarCarreraToolStripMenuItem.Click += new System.EventHandler(this.eliminarCarreraToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeMateriasPorCarreraToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cantidadDeMateriasPorCarreraToolStripMenuItem
            // 
            this.cantidadDeMateriasPorCarreraToolStripMenuItem.Name = "cantidadDeMateriasPorCarreraToolStripMenuItem";
            this.cantidadDeMateriasPorCarreraToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.cantidadDeMateriasPorCarreraToolStripMenuItem.Text = "Cantidad de materias por carrera";
            this.cantidadDeMateriasPorCarreraToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeMateriasPorCarreraToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeMateriasPorCarreraToolStripMenuItem;
    }
}