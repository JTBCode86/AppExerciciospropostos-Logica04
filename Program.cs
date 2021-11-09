using System;
using System.Globalization;

namespace AppExerciciospropostos_Logica04
{
    class Program
    {
        /// <summary>
        /// Exercicios propostos 04
        /// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        /// hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
        /// decimais.
        /// </summary>
        /// <param name="vlHora"></param>
        /// <param name="hrTrabalhada"></param>
        /// <returns></returns>
        /// 
        public static double CalcularSalario(double vlHora, int hrTrabalhada) 
        {
            double salario = hrTrabalhada * vlHora;
                return salario;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe: Sua matricula, horas trabalhadas e o valor-hora: ");
            string[] vet = Console.ReadLine().Split(" ");

            int matricula = int.Parse(vet[0]);
            int hrTrabalhada = int.Parse(vet[1]);
            double vlHora= double.Parse(vet[2]);

            double salario = CalcularSalario(vlHora, hrTrabalhada);
            Console.WriteLine("Matricula: {0}", matricula);
            Console.WriteLine("Seu salário será de: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
