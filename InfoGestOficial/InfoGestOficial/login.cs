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
    }
}