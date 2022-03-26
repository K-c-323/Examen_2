using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class FrmMenu : SfForm
    {
        public FrmMenu()
        {
            InitializeComponent();

            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }


        FrmProducto frmProducto= null;
        FrmPedidos frmpedido = null; 
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.FormClosed += FrmProducto_FormClosed;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }

        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProducto = null;
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        private void PedidoToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmpedido == null)
            {
                frmpedido = new FrmPedidos();
                frmpedido.MdiParent = this;
                frmpedido.FormClosed += Frmpedido_FormClosed;
                frmpedido.Show();
            }
            else
            {
                frmpedido.Activate();
            }
        }

        private void Frmpedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmpedido = null;
        }
    }
}
