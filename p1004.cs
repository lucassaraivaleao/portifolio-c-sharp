/*
Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
A seguir mostre a variável PROD com mensagem correspondente.   

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. 
Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
*/
using System;
					
public class Program
{
	public static void Main()
	{
		int A = int.Parse(Console.ReadLine());
		int B = int.Parse(Console.ReadLine());
		
		int PROD = A * B;
		
		Console.WriteLine("PROD = "+ PROD);
	}
}
