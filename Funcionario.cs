using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEmpresa
{
    public class Funcionario : Pessoa
    {
        private int matricula;
        private int tipo;

        public int GetMatricula()
        { 
            return matricula;
        }

        public int GetTipo()
        {
            return tipo;
        }

        public void SetMatricula(int matricula)
        { 
            this.matricula = matricula;
        }

        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }
    }
}
