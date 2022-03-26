using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {

        public int Id { get; set; }
        public string IdentidadCliente { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

        public Pedido()
        {
        }

        public Pedido(int id, string identidadCliente, string cliente, DateTime fecha, decimal subTotal, decimal iSV, decimal total)
        {
            Id = id;
            IdentidadCliente = identidadCliente;
            Cliente = cliente;
            Fecha = fecha;
            SubTotal = subTotal;
            ISV = iSV;
            Total = total;
        }
    }
}
