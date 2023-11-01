using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_intento_.Clases
{
	public class Nodo
	{
		private int _valor;
		private Nodo? _siguiente;


		//se sobre carga el public Nodo se encarga solo de saber cual usar
		//se usa para añadir un unico elemento o un elemento a lo ultimo
		public Nodo(int Valor)
		{
			_valor = Valor;
			_siguiente = null;
		}
		//se agrega un elemento entre los nodos existentes
		public Nodo(int Valor, Nodo Siguiente)
		{
			_valor = Valor;
			_siguiente = Siguiente;
		}
		public int Valor
		{
			get { return _valor; }
			set { _valor = value; }
		}
		public Nodo Siguiente
		{
			get { return _siguiente; }
			set { _siguiente = value; }
		}
	}
}

