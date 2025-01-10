using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios
{
	internal class Carro
	{
		string modelo, marca, codigoChassi, placa, cor;

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
