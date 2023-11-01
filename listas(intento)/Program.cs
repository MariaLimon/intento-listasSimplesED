using static listas_intento_.Clases.Ejercicio;

namespace listas_intento_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Lista lista = new Lista();
			/*
			lista.InsertarAlFrente(10);
			lista.InsertarAlFrente(20);
			lista.InsertarAlFrente(30);
			lista.InsertarAlFrente(40);
			lista.InsertarAlFrente(50);
			*/
			lista.InsertarAlFinal(50);
			lista.InsertarAlFinal(40);
			lista.InsertarAlFinal(30);
			lista.InsertarAlFinal(20);
			lista.InsertarAlFinal(10);
			
			lista.Imprimir();
		}
	}
}