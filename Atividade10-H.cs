using System;
using System.Collections.Generic;

class Program
{
	static double MediadosNumeros(List<int> lista)
	{
		if (lista.Count == 0)
		{
			return 0;
		}
		
		int soma = 0;
		
		foreach (int numero in lista)
		{
			soma += numero;		
		}
		
		return (double)soma / lista.Count;
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
			Console.WriteLine("Digite o elemento {0} da lista: ", i+1);
			int numero = int.Parse(Console.ReadLine());
			numeros.Add(numero);
			}
			Console.Clear();
		}
		
		else
		{
			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Digite o elemento {0} da lista: ", i+1);
			int numero = int.Parse(Console.ReadLine());
			numeros.Add(numero);
			}
		}
		
		double media = MediadosNumeros(numeros);
		
		Console.WriteLine("A média dos números é {0}.", media);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
}
				
