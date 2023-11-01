using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_intento_.Clases
{
	
	public class ListaSimple
	{
		private Nodo primerNodo;
		private Nodo ultimoNodo;
		public ListaSimple()
		{
			primerNodo= null;
		}

		public bool vacio()
		{
			 if(primerNodo == null)
			{
				return true;
			}
			return false;
		}
			
		
		public void InsertarAlFrente(int elemento)
		{
			if (vacio())
			{
				primerNodo = ultimoNodo =new Nodo(elemento);
				
			}

		}
		public void InsertarAlFinal(int elemento)
		{
			Nodo actual = primero;

			ultimoNodo = new Nodo(elemento, ultimoNodo);
		}
		public void Imprimir()
		{
			Nodo actual = primerNodo;

			//puede convertirse en un contador para insertar en el medio de la lista
			while (actual != null)
			{
				Console.WriteLine(actual.Valor);
				actual = actual.Siguiente;
			}
		}
	}
}
