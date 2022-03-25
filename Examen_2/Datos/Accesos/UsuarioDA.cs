using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class UsuarioDA
    {


        readonly String Cadena = "Server=localhost; Port=3306; Database=examen_2; Uid=root; Pwd=21436587;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(String Codigo, String Clave)
        {
            Usuario User = null;

            try
            {
                String Sql = "SELECT * FROM usuario WHERE Codigo = @Codigo AND Clave= @Clave";
                conn = new MySqlConnection(Cadena);
                conn.Open();

                cmd = new MySqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.Parameters.AddWithValue("@Clave", Clave);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User = new Usuario();
                    User.Codigo = reader[0].ToString();
                    User.Nombre = reader[1].ToString();
                    User.Clave = reader[2].ToString();
                }
                reader.Close();
                conn.Close();


            }
            catch (Exception)
            {

                throw;
            }
            return User;
           

        }









    }
}
