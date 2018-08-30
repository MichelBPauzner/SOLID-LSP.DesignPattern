using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Falha
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.DefineAltura(2);
            retangulo.DefineLargura(4);

            Console.WriteLine($"Área do retângulo: {retangulo.CalculaArea()}");

            Retangulo subtipoRetangulo = new Quadrado();
            subtipoRetangulo.DefineAltura(2);
            subtipoRetangulo.DefineLargura(4);

            Console.WriteLine($"Área do retângulo (subtipo): {subtipoRetangulo.CalculaArea()}");
            Console.ReadKey();
        }
    }
}
