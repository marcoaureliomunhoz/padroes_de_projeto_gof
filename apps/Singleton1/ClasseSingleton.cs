using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    //assim que a classe for acionada pela primeira vez o atributo estático será resolvido
    public class ClasseSingleton
    {
        private static readonly ClasseSingleton _instancia = new ClasseSingleton();

        //como o construtor fica escondido será difícil algum cliente conseguir instanciar
        private ClasseSingleton() { }

        public static ClasseSingleton getInstancia()
        {
            return _instancia;
        }

        public string Propriedade1 { get; set; }
    }
}
