using System;
using System.Collections.Generic;

class Program
{
	static int NumeroMenor(List<int> lista)
	{
		int menor = lista[0];
		
		foreach (int numero in lista)
		{
			if (numero < menor)
				{
				menor = numero;
				}			
		}
		
		return menor;
	}
	
	
	static void Main()
	{
		
		Console.WriteLine("Digite o tamanho da lista: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		List<int> numeros = new List<int> ();
		
		if (tamanho > 6)
		{
			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			int numero = int.Parse(Console.ReadLine());
			
			numeros.Add(numero);
			}
		}
		
		else
		{
			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			int numero = int.Parse(Console.ReadLine());
			
			numeros.Add(numero);
			}
		}
		
		int menor = NumeroMenor(numeros);
		
		Console.WriteLine("\n\rO menor número da lista é {0}.", menor);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
