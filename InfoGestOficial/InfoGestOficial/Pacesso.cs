using InfoGestOficial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoGestOficial
{
    public partial class Pacesso : Form
    {
        public Pacesso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnverifica_Click(object sender, EventArgs e)
        {
            int senha = Convert.ToInt32(txt_ativacao.Text);
            if (senha == 3201596)
            {
                MessageBox.Show("Acesso Permitido");
                Hide();
                primeiro_cad form3 = new primeiro_cad();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }
    }
}


