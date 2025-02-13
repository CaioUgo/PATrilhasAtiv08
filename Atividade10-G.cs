using System;
using System.Collections.Generic;

class Program
{
	static string CaracterImpares(string entrada)
	{
		string resultado = "";
		
		for (int i = 0; i < entrada.Length; i+=2)
		{
			resultado += entrada[i];
		}
		return resultado;
	}
	
	static void Main()
	{
		Console.WriteLine("Digite uma palavra: ");
		string entrada = Console.ReadLine();
		
		string resultado = CaracterImpares(entrada);
		
		Console.WriteLine("\n\rA palavra com apenas caracteres impares é {0}", resultado);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
