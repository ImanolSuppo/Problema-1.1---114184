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
    public partial class EliminarCarrera : Form
    {
        AccesoDatos.ConexionDB helper;
        string carrera = "";
        public EliminarCarrera()
        {
            InitializeComponent();
            helper = new AccesoDatos.ConexionDB();
        }

        private void EliminarCarrera_Load(object sender, EventArgs e)
        {
            CargarCombo("SP_SELECT_CARRERA_COMBO", cboCarrera  , "nombre", "id_carrera");
        }
        private void CargarCombo(string SP, ComboBox cbn, string display, string value)
        {
            DataTable table = helper.ConsultarDatos(SP, null);
            cbn.DataSource = table;
            cbn.DisplayMember = display;
            cbn.ValueMember = value;
            cbn.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool Existe()
        {
            carrera = cboCarrera.Text;
            DataTable filas = helper.ConsultarDatos("SP_SELECT_CARRERA", carrera);
            if (filas.Rows.Count >= 1)
            {
                return true;
            }
            return false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar esta carrera?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Existe())
                    MessageBox.Show("No se elimino la carrera debido a que ya no existia!", "NO_ELIMINA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    carrera = cboCarrera.Text;
                    helper.EliminarDatos(carrera);
                    MessageBox.Show("Se elimino la carrera correctamente!", "SI_ELIMINA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
