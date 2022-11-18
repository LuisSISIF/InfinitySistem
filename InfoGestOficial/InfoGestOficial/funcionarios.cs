using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfoGestOficial
{
    internal class funcionarios
    {
        string nome_func, login_func, senha_func, tel_func, end_func, funcao_func, cpf_func;
        int adm, idempresa;
        decimal salario_func;
        public string Nome { get => nome_func; set => nome_func = value; }
        public string Cpf { get => cpf_func; set => cpf_func = value; }
        public string Login { get => login_func; set => login_func = value; }
        public string Senha { get => senha_func; set => senha_func = value; }
        public string Tel { get => tel_func; set => tel_func = value; }
        public string End { get => end_func; set => end_func = value; }
        public string Cargo { get => funcao_func; set => funcao_func = value; }
        public decimal  Salario { get => salario_func; set => salario_func = value; }
        public int Adm { get => adm; set => adm = value; }
        public int IdEmpresa { get => idempresa; set => idempresa = value; }
    }
}
