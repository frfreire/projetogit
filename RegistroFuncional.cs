using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjEmpresa
{
    public class RegistroFuncional : IRegistro
    {
        private ArrayList funcionarios = new ArrayList();

        public void Cadastrar(Funcionario f)
        {
            this.funcionarios.Add(f);
        }

        public ArrayList ListarFuncionarios()
        {
            return this.funcionarios;
        }
    }
}
