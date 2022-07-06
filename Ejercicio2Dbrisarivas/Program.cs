using System;

namespace PSeInt
{
	class ejercicio2debrisarivas
	{

		static void Main(string[] args)
		{
			string acutangulo;
			double ladoa;
			double ladob;
			double ladoc;
			string obtusangulo;
			string rectangulo;
			Console.Write("ladoA es");
			ladoa = Double.Parse(Console.ReadLine());
			Console.Write("ladoB es");
			ladob = Double.Parse(Console.ReadLine());
			Console.Write("ladoC es");
			ladoc = Double.Parse(Console.ReadLine());
			if (Math.Pow(ladoa, 2) == Math.Pow(ladob, 2) + Math.Pow(ladoc, 2))
			{
				Console.WriteLine(Math.Pow(ladoa, 2) + ":" + Math.Pow(ladob, 2) + ":" + Math.Pow(ladoc, 2) + rectangulo);
				if (Math.Pow(ladoa, 2) > Math.Pow(ladob, 2) + Math.Pow(ladoc, 2))
				{
					Console.WriteLine(Math.Pow(ladoa, 2) + ":" + Math.Pow(ladob, 2) + ":" + ladoc + obtusangulo);
					if (Math.Pow(ladoa, 2) < Math.Pow(ladob, 2) + Math.Pow(ladoc, 2))
					{
						Console.WriteLine(Math.Pow(ladoa, 2) + ":" + Math.Pow(ladob, 2) + ":" + ladoc + acutangulo);
					}
					else
					{
						Console.WriteLine("error");
					}
				}
				else
				{
				}
			}
			else
			{
			}
		}

	}

}

