using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Problema_1._1___114184.Formularios
{
    public partial class ReporteCantidadMaterias : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public ReporteCantidadMaterias()
        {
            InitializeComponent();
        }

        private void ReporteCantidadMaterias_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = Properties.Resources.String1;
            cnn.Open();
            cmd = new SqlCommand("SP_Report_Carreras", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));
            reportViewer1.RefreshReport();
            cnn.Close();
        }
    }
}
