using System;

namespace Atividades_de_La_os
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero que deseja para fazer a sua tabuada");
            int numero = int.Parse(Console.ReadLine());
            int resultado; 
            Console.WriteLine("-------------");
            
            for(var tabuada = 0; tabuada <= 10; tabuada++)
            {
                resultado = numero * tabuada;
                Console.WriteLine(+numero+" x "+tabuada+" = "+resultado);
            }
        }
    }
}
