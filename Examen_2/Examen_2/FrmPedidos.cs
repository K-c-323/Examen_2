using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        Pedido Pedido = new Pedido();
        Producto producto;
        //FacturaDA facturaDA = new FacturaDA();


        List<DetallePedido> DetallePedidoslista = new List<DetallePedido>();

        decimal subTotal = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal totalAPagar = decimal.Zero;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            DetalledataGridView.DataSource = DetallePedidoslista;
        }
    }
}
