using System.Windows.Forms;

namespace Aula03_jaq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConsultaP P = null;
        Pedido pedido = new Pedido();
        private void btnFechar_Click(object sender, EventArgs e)
        {
            pedido.Cliente1 = txtbn.Text;
            pedido.ValorTotal1 = 0;
            pedido.CaloriasTotal1 = 0;

            if (rdbpf.Checked)
            {
                pedido.ValorTotal1 = +pedido.PrecoPao1[0];
                pedido.CaloriasTotal1 = +pedido.CaloriasPao1[0];
            }
            else
            {
                pedido.ValorTotal1 = +pedido.PrecoPao1[1];
                pedido.CaloriasTotal1 = +pedido.CaloriasPao1[1];
            }

            if (rdbB.Checked)
            {
                pedido.ValorTotal1 += pedido.PrecoCarne1[0];
                pedido.CaloriasTotal1 += pedido.CaloriasCarne1[0];
            }
            else
            {
                pedido.ValorTotal1 += pedido.PrecoCarne1[1];
                pedido.CaloriasTotal1 += pedido.CaloriasCarne1[1];
            }

            if (ckbC.Checked)
            {
                pedido.ValorTotal1 += pedido.PrecoComplemento1[0];
                pedido.CaloriasTotal1 += pedido.PrecoComplemento1[0];
            }
            if (ckbT.Checked)
            {
                pedido.ValorTotal1 += pedido.PrecoComplemento1[1];
                pedido.CaloriasTotal1 += pedido.PrecoComplemento1[1];
            }
            if (ckbP.Checked)
            {
                pedido.ValorTotal1 += pedido.PrecoComplemento1[2];
                pedido.CaloriasTotal1 += pedido.PrecoComplemento1[2];
            }
            if (ckbM.Checked)
            {
                pedido.ValorTotal1 += pedido.PrecoComplemento1[3];
                pedido.CaloriasTotal1 += pedido.PrecoComplemento1[3];
            }

            lblP.Text = "Nome do cliente: " + pedido.Cliente1 + " Valor total: " + "R$"+pedido.ValorTotal1 + " Total de calorias: " + pedido.CaloriasTotal1 + "g";
            
            foreach(Control item in gpbComp.Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox c = (CheckBox)item;
                    c.Checked = false;
                }
            }
            foreach (Control item in gbxC.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton r = (RadioButton)item;
                    r.Checked = false;
                }
            }
            foreach (Control item in gbxP.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton r = (RadioButton)item;
                    r.Checked = false;
                }
            }
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }


            P = new ConsultaP();
            P.Nome = txtbn.Text;
            P.Valor = pedido.ValorTotal1;
            P.Caloria = pedido.CaloriasTotal1;
            Program.Listapedido.Add(P);
           
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}