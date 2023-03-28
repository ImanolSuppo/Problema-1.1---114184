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
    public partial class AgregarCarrera : Form
    {
        Dominio.Carrera carrera;
        AccesoDatos.ConexionDB helper;
        public AgregarCarrera()
        {
            InitializeComponent();
            carrera = new Dominio.Carrera();
            helper = new AccesoDatos.ConexionDB();
        }

        private void AgregarCarrera_Load(object sender, EventArgs e)
        {
            ProximoID();
            CargarCombo("SP_SELECT_MATERIA_COMBO", CboMateria, "nombre", "id_materia");
        }
        private void CargarCombo(string SP, ComboBox cbn, string display, string value)
        {
            DataTable table = helper.ConsultarDatos(SP, null);
            cbn.DataSource = table;
            cbn.DisplayMember = display;
            cbn.ValueMember = value;
            cbn.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ProximoID()
        {
            int next = helper.ProximaId("SP_PROXIMO_NRO_DETALLE");
            LblProPresupuesto.Text = "Detalle Nro: " + next.ToString();
        }

        public bool Valida()
        {
            if (TxtAnioCursado.Text.Equals(string.Empty))
                return false;
            if (!int.TryParse(TxtAnioCursado.Text, out int a))
                return false;
            return true;
        }

        private bool Existe()
        {
            string carrera = txtCarrera.Text;
            DataTable filas = helper.ConsultarDatos("SP_SELECT_CARRERA", carrera);
            if (filas.Rows.Count >= 1)
            {
                return true;
            }
            return false;
        }

        public void Clear()
        {
            TxtAnioCursado.Clear();
            txtCarrera.Clear();
            carrera.LimpiarDetalle();
            dgvDetalles.Rows.Clear();
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Error, verifique los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    if (row.Cells["colProd"].Value.ToString().Equals(CboMateria.Text))
                    {
                        MessageBox.Show("Materia: " + CboMateria.Text + " ya se encuentra como detalle!", "Control",

                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                DataRowView item = (DataRowView)CboMateria.SelectedItem;
                int id = Convert.ToInt32(item.Row.ItemArray[0]);
                string nombre = item.Row.ItemArray[1].ToString();
                Dominio.Materia m = new Dominio.Materia(id, nombre);
                int anioCurs = Convert.ToInt32(TxtAnioCursado.Text);
                int cuatrimestre = 0;
                if (rbtPrimero.Checked) cuatrimestre = 1; else cuatrimestre = 2;
                Dominio.DetalleCarrera detalle = new Dominio.DetalleCarrera(anioCurs, cuatrimestre, m);
                carrera.AgregarDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1] });

            }
        }

        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 2)
            {
                carrera.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                //presupuesto.quitarDetalle();

            }
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!",
                "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Existe())
            {
                MessageBox.Show("La Carrera ya existe!",
                "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            carrera.Nombre = txtCarrera.Text;
            if (helper.EjecutarDatos(carrera))
            {
                MessageBox.Show("Carrera registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Dispose();
                Clear();
                ProximoID();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
