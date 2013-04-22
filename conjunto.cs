using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConjuntosApp
{
    class Conjunto : IEnumerable, IEnumerator
    {
        public List<Object> lista { get; set; }
        int index = 0;

        public Conjunto()
        {
            lista = new List<object>();
        }

        public bool Continencia(Object elemento)
        {

            if (lista.Contains(elemento))
                return true;

            return false;
        }

        public bool Pertinencia(Conjunto conj)
        {
            foreach (var item in conj.lista)
            {
                if (!lista.Contains(item))
                {
                    break;
                }

            }
            return true;
        }

        public List<Object> Uniao(Conjunto conj)
        {
            List<Object> listaUniao = new List<object>();


            return lista.Union(conj.lista).ToList();
        }

        public List<Object> Diferenca(Conjunto conj)
        {
            return lista.Except(conj.lista).ToList();
        }

        public IEnumerable<Object> Interseccao(Conjunto conj)
        {
            return lista.Intersect(conj.lista);
        }
  	
		
		public List<Object> Complemento(Conjunto conj)
		{	
			return this.Diferenca(conj.lista);
		}
		
		public Conjunto<T> Complemento(Conjunto<T> universo)
		{	
			return this.Diferenca(universo);
		}
	
		public void ProdutoCartesiano(Conjunto conj)
        {
            List<Object> cartesiano = new List<object>();

            for (int i = 0; i < valoresConjunto.Count(); i++)
            {
                for (int j = 0; j < conj.valoresConjunto.Count; j++)
                {
                    List<Object> valores = new List<object>();
                    valores.Add(valoresConjunto.ElementAt(i));
                    valores.Add(conj.valoresConjunto.ElementAt(j));
                    cartesiano.Add(valores);
                }
            }

            foreach (List<Object> item in cartesiano)
            {
                Console.WriteLine("({0}, {1})", item.ElementAt(0), item.ElementAt(1));
            }
        }


        public virtual void display()
        {
            foreach (var item in valoresConjunto)
            {
                Console.WriteLine(item); 
            }
        }


    }
}
