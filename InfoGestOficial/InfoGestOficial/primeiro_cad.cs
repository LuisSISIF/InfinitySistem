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
    public partial class primeiro_cad : Form
    {
        public primeiro_cad()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void primeiro_cad_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empresa em = new empresa();
            em.Nome_Empresa = txt_nomeEmpresa.Text;
            em.Cnpj_Empresa = Convert.ToInt32(txt_cnpj.Text);

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereEmpresa(em);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso! Você será redirecionado para cadastrar seu primeiro Funcionário.");
                Hide();
                cad_func form3 = new cad_func();
                form3.ShowDialog();
            }
            else
                MessageBox.Show("Erro ao cadastrar nova empresa");

        }//  fim confima insere banda

    }
}
