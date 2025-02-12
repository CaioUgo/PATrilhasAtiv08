using System;
using System.Collections.Generic;

class Program
{
	static int ParouImpar(int numero)
	{
		
		if (numero % 2 == 0)
		{
			Console.WriteLine("\n\rO número {0} é verdadeiro!", numero);
		}
		else 
		{
			Console.WriteLine("\n\rO número {0} é falso!", numero);
		}
		return numero;
	}
	
	static void Main()
	{
		Console.WriteLine("Digite um número inteiro: ");
		int numero = int.Parse(Console.ReadLine());
		
		int par = ParouImpar(numero);
		
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
