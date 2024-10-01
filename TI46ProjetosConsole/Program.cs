using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int nota1, nota2, nota3, nota4, resultado;
            Console.WriteLine("Escreva o nome do aluno: ");
            nome = Console.ReadLine();

            //Entre com as notas!
            Console.WriteLine("Digita as notas do aluno "+nome,"\n");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());
            nota3 = int.Parse(Console.ReadLine());
            nota4 = int.Parse(Console.ReadLine());

            Console.WriteLine("A média do aluno " + nome + " é: ");
            resultado = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(resultado);


            Console.ReadKey();

        }
    }
}
