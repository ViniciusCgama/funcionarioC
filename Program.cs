using System; using Aula02DS.models;

namespace Aula02DS
{
    class Program
    {
        static void Main(string[] args)
        {      
            Funcionario func = new Funcionario();

        func.Id = ;
        func.Nome = "Neymar";
        func.CPF = "12345678910";
        func.DataAdmissao = DateTime.Parse("01/01/2000");
        func.Salario = 10000.00M; 
        func.TipoFuncionario = models.Enuns.TipoFuncionarioEnum.CLT;    

        string mensagem = func.ExibirPeriodoExperiencia();
        Console.WriteLine("==========================");
        Console.WriteLine(mensagem);
        Console.WriteLine("==========================");












        }
    }
}



