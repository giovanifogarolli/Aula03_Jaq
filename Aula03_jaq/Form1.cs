using System.Windows.Forms;

namespace Aula03_jaq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pedido pedido = new Pedido();
        private void btnFechar_Click(object sender, EventArgs e)
        {
            pedido.Cliente1 = txtbn.Text;
            pedido.ValorTotal1 = 0;
            pedido.CaloriasTotal1 = 0;

            if (rdbpf.Checked)
            {
                pedido.ValorTotal1 += +5;
                pedido.CaloriasTotal1 += 108;
            }
            else
            {
                pedido.ValorTotal1 += +7;
                pedido.CaloriasTotal1 += +100;
            }

            if (rdbB.Checked)
            {
                pedido.ValorTotal1 += +15;
                pedido.CaloriasTotal1 += +200;
            }
            else
            {
                pedido.ValorTotal1 += +13;
                pedido.CaloriasTotal1 += +180;
            }

            if (ckbC.Checked)
            {
                pedido.ValorTotal1 += +1;
                pedido.CaloriasTotal1 += +50;
            }
            if (ckbT.Checked)
            {
                pedido.ValorTotal1 += +1;
                pedido.CaloriasTotal1 += +50;
            }
            if (ckbP.Checked)
            {
                pedido.ValorTotal1 += +1;
                pedido.CaloriasTotal1 += +50;
            }
            if (ckbM.Checked)
            {
                pedido.ValorTotal1 += +1;
                pedido.CaloriasTotal1 += +50;
            }

            lblP.Text = "Nome do cliente: " + pedido.Cliente1 + " Valor total: " + "R$"+pedido.ValorTotal1 + " Total de calorias: " + pedido.CaloriasTotal1 + "g";
        }
    }
}