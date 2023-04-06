using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maioriade
{
    class Program
    { 
static void Main(string[] args)
{
    Processar();

    Console.ReadKey();

}

private static void Processar()
{
    int Idade;
    Console.Write("Informa idade: ");
    int.TryParse(Console.ReadLine(), out Idade);

    if (Idade >= 18)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Acesso Permitido");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Acesso Negado");

    }
  }
 }
}

