using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03_jaq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            foreach(var item in Program.Listapedido)
            {
                if(item.Nome == txtbn.Text)
                {
                    listBox1.Items.Add(item.Nome + " | " + item.Caloria + " | " + item.Valor);
                }
            }
        }
    }
}
