using System;

namespace Exercicio.Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdFuncionarios = 10;
            string[qtdFuncionarios] funcionario = new string[qtdFuncionarios];
            double[qtdFuncionarios] salario = new double[qtdFuncionarios];
            int[qtdFuncionarios] tempo = new int[qtdFuncionarios];

            for (int i = 0; i < qtdFuncionarios; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º funcionario:");
                funcionario[i] = Console.ReadLine();

                Console.WriteLine($"Digite o salário do {funcionarios[i]}:");
                salario[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite o tempo (em anos) de empresa do {funcionarios[i]}:");
                tempo[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < qtdFuncionarios; i++)
            {
                switch (tempos[i])
                {
                    case < 5:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {salario[i]}");
                        break;
                    case 5:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {(salario[i] * 20) / 100}");
                        break;
                    case 6:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {(salario[i] * 25) / 100}");
                        break;
                    case 7:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {(salario[i] * 30) / 100}");
                        break;
                    case 8:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {(salario[i] * 40) / 100}");
                        break;
                    case 9:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {(salario[i] * 50) / 100}");
                        break;
                    default:
                        Console.WriteLine($"O novo salario de {funcionario[i]} é de: {(salario[i] * 60) / 100}");
                        break;                    
                }
            }
        }
    }
}
