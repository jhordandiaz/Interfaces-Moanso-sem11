using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Proveedor
        public List<entProveedor> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro= new entProveedor();
                    Pro.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                    Pro.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    Pro.Nombre = dr["Nombre"].ToString();
                    Pro.RubroID = Convert.ToInt32(dr["RubroID"]);
                    Pro.Ruc = Convert.ToInt32(dr["Ruc"]);
                    Pro.estProveedor = Convert.ToBoolean(dr["estProveedor"]);
                    lista.Add(Pro);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        /////////////////////////Insertar Proveedor
        public Boolean InsertarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", Pro.CiudadID);
                cmd.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                cmd.Parameters.AddWithValue("@RubroID", Pro.RubroID);
                cmd.Parameters.AddWithValue("@Ruc", Pro.Ruc);
                cmd.Parameters.AddWithValue("@estCliente", Pro.estProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //////////////////////////////////Editar Proveedor
        public Boolean EditarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", Pro.CiudadID);
                cmd.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                cmd.Parameters.AddWithValue("@RubroID", Pro.RubroID);
                cmd.Parameters.AddWithValue("@Ruc", Pro.Ruc);
                cmd.Parameters.AddWithValue("@estProveedor", Pro.estProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitar Proveedor

        public Boolean DeshabilitarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PrveedorID", Pro.ProveedorID);
                cmd.Parameters.AddWithValue("@estProveedor", Pro.estProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion Metodos
    }
}
