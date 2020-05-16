using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite qualquer coisa... veja o que acontece!!!!");
            string frase1 = Console.ReadLine();
            string frase2 = frase1.Replace("r","l").Replace("R","L");

            Console.WriteLine(frase2);   
        }
    }
}
