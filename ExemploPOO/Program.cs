using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string [] args)
        {
           //Valores Validos
            Retangulo r1 = new Retangulo();
            r1.DefinirMedidas(30 , 30);
            System.Console.WriteLine($"Área:{r1.ObterArea()}");
            
            //Valores Invalidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0 , 0);
            System.Console.WriteLine($"Área:{r2.ObterArea()}");
            
            
            
            
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Pedro";
            // p1.Idade = 37;

            // p1.Apresentar();
        }
    }
}
