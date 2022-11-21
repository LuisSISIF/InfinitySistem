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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabFunc.Show();
            marcador.Height = btnfunc.Height;
            marcador.Top = btnfunc.Top;
            tabFunc.SelectedTab = tabFunc.TabPages[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            
            funcionarios f = new funcionarios();
            f.Nome = txt_nome.Text;
            f.Cpf = txt_cpf.Text;
            f.Login = txt_login.Text;
            f.Senha = txt_senha.Text;
            f.End = txt_end.Text;
            f.Tel = txt_fone.Text;
            f.Salario = Convert.ToInt32(txt_sal.Text);
            f.Cargo = txt_func.Text;
            if(chkadm.Checked) 
            {
                f.Adm = 1;
            }
            else 
            {
                f.Adm = 0;
            }

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.cad_func(f);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
                MessageBox.Show("Erro ao cadastrar novo Funcionário");

        }//  fim confima insere banda

        private void chkadm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            tabFunc.Hide();
        }
    }

}
