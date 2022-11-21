namespace InfoGestOficial
{
    internal static class Program
    {
        public static ConectaBanco cx = new ConectaBanco();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if(cx.testeConection())
            {
                login_form login = new login_form();
                DialogResult resultado = login.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Application.Run(new principal());
                }
            }
            else
            {
                MessageBox.Show(cx.mensagem,"Erro de Conexão com o Banco de Dados",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
            
            
        }

    }

}