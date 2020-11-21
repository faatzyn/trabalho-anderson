using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario
    {
        public int CdFuncionario { get; set; }
        public string NmFuncionario { get; set; }
        public DateTime DtNasc { get; set; }
        public char DsSexo { get; set; }
        public char DsEstadoCivil { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string DsLogin { get; set; }
        public string DsSenha { get; set; }
        public bool Status { get; set; }

    }
}
