using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace repasoexamenDAO
{
   public class loginusuarioDAO
    {
        //cadena de conexion
        string cnx = Properties.Settings.Default.Cnx;
        //metodo para baliidar login
        public bool ValidaUsuario(string Usuario, string Clave)
        {
            using (SqlConnection cn= new SqlConnection(cnx))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ValidaLogin",cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Clave", Clave);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        return dr.HasRows;
                    }
                }
            }
        }
    }
}
