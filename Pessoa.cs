using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEmpresa
{
    public class Pessoa
    {
        private string? nome;
        private string? cpf;
        private string? rg;

        public string GetNome()
        {
            return nome ?? string.Empty;
        }

        public string GetCpf()
        {
            return cpf ?? string.Empty;
        }

        public string GetRg()
        {
            return rg ?? string.Empty;
        }

        public void SetNome(string nome)
        { 
            this.nome = nome;
        }

        public void SetCpf(string cpf)
        { 
            this.cpf = cpf;
        }

        public void SetRg(string rg)
        {
            this.rg = rg;
        }

    }
}
