using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios
{
	internal class Carro
	{
		public string modelo { get; set; }
		public string marca { get; set; }
		public string codigoChassi { get; set; }
		public string placa { get; set; }
		public string cor { get; set; }
		public string fabricante { get; set; }
		public int ano
		{
			//Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
			get { return ano; }
			set
			{
				if (value < 1960 || value > 2023)
				{
					throw new ArgumentException("Valor Inválido. Insira entre 1960 e 2023");
				}
				else
				{
					ano = value;
				}
			}
		}
		public string DescricaoDetalhada
		{
			get 
			{
				return $"Fabricante: {fabricante}\nModelo: {modelo};\nAno: {ano}";
			}
		}

		void acelerar()
		{
			Console.WriteLine("VRUM VRUM");
		}
		void frear()
		{
            Console.WriteLine("IIIIIIIIH");
        }
		void buzinar()
		{
            Console.WriteLine("BEEP BEEP!!!");
        }

	}
}
