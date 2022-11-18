using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoGestOficial
{
    internal class empresa
    {
        string nome_empresa;
        int cnpj_empresa;

        public string Nome_Empresa { get => nome_empresa; set => nome_empresa = value; }
        public int Cnpj_Empresa { get => cnpj_empresa; set => cnpj_empresa = value; }
    }
}
