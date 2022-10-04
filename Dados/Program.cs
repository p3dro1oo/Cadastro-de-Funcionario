using System;
using System.Globalization;

namespace Dados {
    class Program {
        static void Main(string[] args) {
            Funcionario pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados: " + pessoa);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); pessoa.AumentarSalario(porcent);
            Console.WriteLine(); Console.WriteLine("Dados atualizados: " + pessoa);
        }
    }
}
