using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class PedidoDA
    {
        readonly String Cadena = "Server=localhost; Port=3306; Database=examen_2; Uid=root; Pwd=21436587;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarPedido(Pedido Pedido)
        {
            int idPedido = 0;
            try
            {
                string sql = "INSERT INTO pedido (IdentidadCliente, Cliente, Fecha, SubTotal, Impuesto, Total) VALUES (@IdentidadCliente, @Cliente, @Fecha, @SubTotal, @Impuesto, @Total); select last_insert_id();";

                conn = new MySqlConnection(Cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdentidadCliente", Pedido.IdentidadCliente);
                cmd.Parameters.AddWithValue("@Cliente", Pedido.Cliente);
                cmd.Parameters.AddWithValue("@Fecha", Pedido.Fecha);
                cmd.Parameters.AddWithValue("@SubTotal", Pedido.SubTotal);
                cmd.Parameters.AddWithValue("@Impuesto", Pedido.ISV);
                cmd.Parameters.AddWithValue("@Total", Pedido.Total);
                idPedido = Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return idPedido;
        }

        public bool InsertarDetalle(DetallePedido detallePedido)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO detallepedidos (IdPedido, CodigoProducto, Descripcion, Cantidad, Precio, Total) VALUES (@IdFactura, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total);";

                conn = new MySqlConnection(Cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdFactura", detallePedido.IdFactura);
                cmd.Parameters.AddWithValue("@CodigoProducto", detallePedido.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", detallePedido.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detallePedido.Precio);
                cmd.Parameters.AddWithValue("@Total", detallePedido.Total);
                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }








    }
}
