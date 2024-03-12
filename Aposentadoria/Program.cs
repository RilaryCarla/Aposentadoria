using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos anos você tem: ");
            double idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos anos você trabalhou: ");
            double trabalho = double.Parse(Console.ReadLine());

            if ( idade >= 65 || trabalho >= 30 || idade >= 60 && trabalho >= 25)
            {
                Console.WriteLine("Você tem direito a aposentadoria!");
            }
            else
            {
                Console.WriteLine("Você não tem direito a aposentadoria!");
            }
            Console.ReadKey();
        }
    }
}
