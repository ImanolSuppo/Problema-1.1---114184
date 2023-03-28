using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Problema_1._1___114184.AccesoDatos
{
    internal class ConexionDB
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlTransaction trs;

        public ConexionDB()
        {
           cnn = new SqlConnection();
           cnn.ConnectionString = Properties.Resources.String1;
        }

        public DataTable ConsultarDatos(string SP,string carrera)
        {
            cnn.Open(); 
            cmd=new SqlCommand(SP,cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable table = new DataTable();
            if (SP == "SP_SELECT_CARRERA")
                cmd.Parameters.AddWithValue("@carrera", carrera);
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }

        public bool EjecutarDatos(Dominio.Carrera carrera)
        {
            bool result = true;
            trs = null;
            try
            {
                cnn.Open();
                trs = cnn.BeginTransaction();
                cmd = new SqlCommand("SP_INSERT_CARRERA", cnn, trs);
                cmd.CommandType = CommandType.StoredProcedure;

                //parámetro de Entrada:
                cmd.Parameters.AddWithValue("@carrera", carrera.Nombre);

                //parámetro de salida:
                SqlParameter pOut = new SqlParameter("@new_id_carrera", DbType.Int32);
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int id_carrera = (int)pOut.Value;

                foreach (Dominio.DetalleCarrera det in carrera.Detalle)
                {
                    cmd = new SqlCommand("SP_INSERT_MATERIA", cnn, trs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_carrera", id_carrera);
                    cmd.Parameters.AddWithValue("@id_materia", det.Materia.Id_materia);
                    cmd.Parameters.AddWithValue("@anioCursado", det.AnioCursado);
                    cmd.Parameters.AddWithValue("@cuatrimestre", det.Cuatrimestre);
                    cmd.ExecuteNonQuery();
                }
                trs.Commit();
            }
            catch
            {
                if (trs != null)
                    trs.Rollback();
                result = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return result;
        }

        public void EliminarDatos(string carrera)
        {
            cnn.Open();
            cmd = new SqlCommand("SP_ELIMINAR_CARRERA", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carrera", carrera);
            SqlParameter pOut = new SqlParameter("@id_carrera", DbType.Int32);
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public int ProximaId(string SP)
        {
            SqlParameter param = new SqlParameter();
            cnn.Open();
            cmd = new SqlCommand(SP, cnn);
            cmd.CommandType= CommandType.StoredProcedure;
            param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            int nextId;
            if (param.Value != DBNull.Value)
                nextId = Convert.ToInt32(param.Value);
            else
                nextId = 0;
            cnn.Close();
            return nextId;
        }
    }
}
