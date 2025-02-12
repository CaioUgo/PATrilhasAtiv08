using System;
using System.Collections.Generic;

class Program
{
	static string Concatenador(List<string> listadeStrings)
	{
		return string.Join("", listadeStrings);
	}
	
	static void Main()
	{
		List<string> listadeStrings = new List<string>();
		
		Console.WriteLine("Digite a quantidade de itens da lista: ");
		int quantidade = int.Parse(Console.ReadLine());
		
		Console.WriteLine();
		
		if (quantidade > 6)
		{
			for (int i = 0; i < quantidade; i++)
			{
			Console.WriteLine("Digite o {0}º da lista:", i + 1);
			string character = Console.ReadLine();
			
			listadeStrings.Add(character);
			}
			Console.Clear();
		}
		
		else 
		{
			for (int i = 0; i < quantidade; i++)
			{
			Console.WriteLine("Digite o {0}º da lista:", i + 1);
			string character = Console.ReadLine();
			
			listadeStrings.Add(character);
			}
		}
		
		string resultaConcatenado = Concatenador(listadeStrings);
		
		Console.WriteLine("\n\rA lista concatenada é: {0}", resultaConcatenado);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
