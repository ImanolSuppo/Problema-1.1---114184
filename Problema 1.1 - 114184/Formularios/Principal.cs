using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_1._1___114184.Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void agregarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarCarrera().ShowDialog();
        }

        private void eliminarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarCarrera().ShowDialog();
        }

        private void cantidadDeMateriasPorCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formularios.ReporteCantidadMaterias().ShowDialog();
        }
    }
}
