using System;

namespace PATrilhasAtiv07
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite uma palavra: ");
		    string palavra = Console.ReadLine();
			
		    int tamanho = palavra.Length;
			
			Console.Clear();
		
			Console.WriteLine("\n\rO total de letra da palavra {0} é {1}.", palavra, tamanho);
			Console.WriteLine("\n\rPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
		
		static int Contarletras(string palavra)
		{
			return palavra.Length;
		}
    
		}
	}
