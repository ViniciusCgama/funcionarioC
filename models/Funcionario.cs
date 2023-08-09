using Aula02DS.models.Enuns;

namespace Aula02DS.models
{
    public class Funcionario
    {
        //PROP TAB
        public int Id { get; set; } //GET - RESGATAR INFO | SET - JOGAR INFO
        public string Nome { get; set; } =string.Empty;
        public string CPF { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        //Inserir no topo ---> using pasta.pasta.pasta;  ...
        public TipoFuncionarioEnum TipoFuncionario { get; set; }
        public void ReajustarSalario()
        {
            Salario = (Salario * 10 / 100);
        }
        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia = 
                string.Format("Períodos de experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
                return periodoExperiencia;
        }
        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal Desconto = this.Salario * percentual/100;
            return Desconto;
        }
        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }
        public bool ValidarCpf()
        {
            if(ContarCaracteres(CPF) == 11)
                return true;
            else
                return false;
        }







































    }
}