using System;
using System.Collections.Generic;

namespace EncryptingMessage
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;

			Console.WriteLine("Digite algo a ser criptografado:");
			input = Console.ReadLine();
						
			Console.WriteLine(input + " " + Encryption(input));
			Console.ReadKey();
		}


		public static string Encryption(string x)
		{
			List<char> Letras = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k','l', 'm',
												'n', 'o','p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
												'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
												'Q','R','S','T','U','V','W','X','Y','Z'};
			
			char[] message = x.ToCharArray();
			string encrypted = "";
			
			foreach (char letra in message)
			{
				if (letra == ' ')
				{
					encrypted += " ";
				}
				else
				{
					int i = Letras.BinarySearch(letra);
					char k = Letras[i + 3];
					encrypted += k;
				}
			}
			return encrypted;
		}
	}
}
