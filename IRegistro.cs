using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEmpresa
{
    public interface IRegistro
    {
        public void Cadastrar(Funcionario f);
        public ArrayList ListarFuncionarios();
    }
}
