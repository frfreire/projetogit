
using System.Reflection;

namespace ProjEmpresa
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario f1 = new();

            f1.SetMatricula(1234);
            f1.SetTipo(1);
            f1.SetNome("Maria");
            f1.SetCpf("555.666.777-88");


            Funcionario f2 = new();
            f2.SetMatricula(4321);
            f2.SetTipo(1);
            f2.SetNome("José");
            f2.SetCpf("111.222.333-44");


            RegistroFuncional rf = new();

            rf.Cadastrar(f1);
            rf.Cadastrar(f2);

            System.Console.WriteLine("Informações de Funcionários");
            foreach (Funcionario f in rf.ListarFuncionarios())
            {
                System.Console.WriteLine("###############################");
                System.Console.WriteLine("Nome: "+f.GetNome());
                System.Console.WriteLine("CPF: " + f.GetCpf());
                System.Console.WriteLine("Matricula: " + f.GetMatricula());
                System.Console.WriteLine("###############################");
                System.Console.WriteLine(" ");

            }

        }

    }

}


