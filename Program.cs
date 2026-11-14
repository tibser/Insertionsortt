
using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("ORDENAMIENTO POR INSERCION");

		Console.Write("Ingrese los numeros separados por espacios: ");
		string entrada = Console.ReadLine() ?? "";

		string[] datos = entrada.Split(' ');
		int[] A = Array.ConvertAll(datos, int.Parse);

		int i = 1;

		while (i < A.Length)
		{
			int j = i;

			while (j > 0 && A[j - 1] > A[j])
			{
				int temporal = A[j];
				A[j] = A[j - 1];
				A[j - 1] = temporal;

				j = j - 1;
			}

			i = i + 1;
		}

		Console.WriteLine("Lista ordenada:");

		foreach (int numero in A)
		{
			Console.Write(numero + " ");
		}
	}
}



