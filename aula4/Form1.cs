using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4
{
    public partial class Form1 : Form
    {
        int valor1 = 0, valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = int.Parse(textBoxV1.Text);
                valor2 = int.Parse(textBoxV2.Text);
                while (valor1 <= valor2)
                {
                    if (valor1 % 2 == 0)
                    {
                        listBoxPar.Items.Add(valor1);
                    }
                    else 
                    {
                        listBoxImpar.Items.Add(valor1);
                    }
                    valor1++;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }
    }
}
