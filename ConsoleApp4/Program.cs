using System;
using System.Collections.Generic;

namespace EncryptingMessage
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			string x = "áâãàéêíóõôúüç";
			Console.WriteLine("Digite algo a ser criptografado:");
			input = Console.ReadLine();

			Console.WriteLine("Texto criptografado:");
			Console.WriteLine(Encryption(input));

			Console.ReadKey();
		}
		

		public static string Encryption(string x)
		{
			List<char> Letras = new List<char> {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
												'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
												'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
												'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
												'á', 'â', 'ã', 'à', 'é', 'ê', 'í', 'ó', 'õ', 'ô', 'ú', 'ü', 'ç',
												'Á', 'Â', 'Ã', 'À', 'É', 'Ê', 'Í', 'Ó', 'Õ', 'Ô', 'Ú', 'Ü', 'Ç'};

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
					Random z = new Random();
					int i = Letras.BinarySearch(letra);
					int indexEncryption;
					
					if (i + i > Letras.Count)
					{
						indexEncryption = Letras.Count - i;
					}
					else
					{
						indexEncryption = i + i - 2;
					}
					char k = Letras[indexEncryption];
					encrypted += k;
				}
			}
			return encrypted;
		}
	}
}
