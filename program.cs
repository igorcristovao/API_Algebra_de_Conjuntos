using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConjuntosApp
{
    class Program
    {
        static void Main(string[] args)
        {
  		Conjunto numeros = new Conjunto(1, 2, 3);

            Conjunto numeros2 = new Conjunto(4, 5, 6);

            Conjunto inter = new Conjunto();

            numeros2.ProdutoCartesiano(numeros);
            Console.ReadLine();
            

        }
    }
}
