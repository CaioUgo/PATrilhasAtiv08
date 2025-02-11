using System;

namespace PATrilhasAtiv07
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite um número inteiro: ");
			int numero = int.Parse(Console.ReadLine());
			
			int resultado = CalcularQuadrado(numero);
			
			Console.Clear();
		
			Console.WriteLine("\n\rO quadrado do número {0} é {1}", numero, resultado);
			Console.WriteLine("\n\rPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
		
		static int CalcularQuadrado (int num)
		{
			return num * num;
		}
		
		}
	}
