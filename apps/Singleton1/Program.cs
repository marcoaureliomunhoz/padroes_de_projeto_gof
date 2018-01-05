using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            //apesar de declarmos duas variáveis do tipo ClasseSingleton
            //ambas apontam para a mesma instância
            //por isso ao final o valor da Propriedade1 é igual a "s2" para a variável s1 e para s2

            ClasseSingleton s1 = ClasseSingleton.getInstancia();
            s1.Propriedade1 = "s1";

            ClasseSingleton s2 = ClasseSingleton.getInstancia();
            s2.Propriedade1 = "s2";

            Console.WriteLine($"s1 = {s1.Propriedade1}");
            Console.WriteLine($"s2 = {s2.Propriedade1}");

            Console.ReadKey();
        }
    }
}
