using System.Data;

namespace InfoGestOficial
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpri_Click(object sender, EventArgs e)
        {
            Pacesso form2= new Pacesso();
            form2.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string login = txtlogin.Text;
            string cmdSql = "call infogest.valida_user('"+login+"');";
            var dados = Program.cx.listaFuncionarios(cmdSql);
            if(dados.Rows.Count > 0 ) 
            {
                DataRow linhadados = dados.Rows[0];
                string senhabanco = linhadados["Senha"].ToString();
                if(senhabanco == txtsenha.Text ) 
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Senha Inválida.");
                }
            }
            else
            {
                MessageBox.Show("Loguin Inválido.");
            }

        }
    }
}