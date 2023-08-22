using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03Colecoes.Models.Enuns;

namespace Aula03Colecoes.Models
{
    public class Funcionario
    {
       //Programção aqui.
       //Prop + TAB
       public int Id { get; set; }
       public string Nome { get; set; }
       public string Cpf { get; set; }
       public DateTime DataAdmissao { get; set; }
       public decimal Salario { get; set; }

       public TipoFuncionarioEnum TipoFuncionario { get; set; }

       public void ReajustarSalario()
       {
            Salario = Salario + (Salario * 10 / 100);
       }

       public decimal CalcularDescontoVT(decimal percentual)
       {
            decimal desconto = Salario * percentual / 100;
            return desconto;
       }

       public string ExibirPeriodoExperiencia()
       {
         string periodoExperiencia = 
            $"Período de Experiência: {DataAdmissao} até {DataAdmissao.AddMonths(3)}";
            
            return periodoExperiencia;
       }

       private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidarCpf()
        {
            if(ContarCaracteres(Cpf) == 11)
                return true;
            else
                return false;
        }

    }

}