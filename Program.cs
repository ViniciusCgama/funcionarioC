using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Funcionario> funcionarios = new List<Funcionario>();

    class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Cpf { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }
    }

    enum TipoFuncionarioEnum
    {
        CLT = 1,
        Estagiario = 2
    }

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar funcionário");
            Console.WriteLine("2 - Buscar funcionário por nome");
            Console.WriteLine("3 - Listar funcionários recentes");
            Console.WriteLine("4 - Exibir estatísticas");
            Console.WriteLine("5 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarFuncionario();
                    break;

                case 2:
                    BuscarFuncionarioPorNome();
                    break;

                case 3:
                    ListarFuncionariosRecentes();
                    break;

                case 4:
                    ExibirEstatisticas();
                    break;

                case 5:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Escolha novamente.");
                    break;
            }
        }
    }

    static void AdicionarFuncionario()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Salário: ");
        decimal salario = decimal.Parse(Console.ReadLine());
        Console.Write("Data de Admissão (dd/mm/aaaa): ");
        DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario
        {
            Nome = nome,
            Id = id,
            Cpf = cpf,
            Salario = salario,
            DataAdmissao = dataAdmissao
        };

        Console.WriteLine("Escolha o tipo de funcionário (1 - CLT, 2 - Estagiario):");
        funcionario.TipoFuncionario = (TipoFuncionarioEnum)int.Parse(Console.ReadLine());

        if (ValidarSalarioAdmissao(salario, dataAdmissao))
        {
            funcionarios.Add(funcionario);
            Console.WriteLine("Funcionário adicionado com sucesso.");
        }
    }

    static void BuscarFuncionarioPorNome()
    {
        Console.Write("Nome a ser buscado: ");
        string nomeBusca = Console.ReadLine();
        Funcionario funcionarioEncontrado = ObterPorNome(nomeBusca);
        if (funcionarioEncontrado != null)
        {
            Console.WriteLine($"Funcionário encontrado: {funcionarioEncontrado.Nome}");
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }

    static void ListarFuncionariosRecentes()
    {
        List<Funcionario> funcionariosRecentes = ObterFuncionariosRecentes();
        foreach (var f in funcionariosRecentes)
        {
            Console.WriteLine($"Nome: {f.Nome}, Salário: {f.Salario}");
        }
    }

    static void ExibirEstatisticas()
    {
        int quantidadeFuncionarios = funcionarios.Count;
        decimal somaSalarios = funcionarios.Sum(f => f.Salario);
        Console.WriteLine($"Quantidade de funcionários: {quantidadeFuncionarios}, Soma dos salários: {somaSalarios}");
    }

    static bool ValidarSalarioAdmissao(decimal salario, DateTime dataAdmissao)
    {
        if (salario == 0 || dataAdmissao < DateTime.Now)
        {
 return true;
        }
               Console.WriteLine("Erro: Salário ou data de admissão inválidos.");
            return false;
    }

    static Funcionario ObterPorNome(string nome)
    {
        return funcionarios.FirstOrDefault(f => f.Nome == nome);
    }

    static List<Funcionario> ObterFuncionariosRecentes()
    {
        List<Funcionario> funcionariosFiltrados = funcionarios.Where(f => f.Id >= 1).ToList();
        return funcionariosFiltrados.OrderByDescending(f => f.Salario).ToList();
    }
}
