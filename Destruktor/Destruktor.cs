﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Destruktor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

			for (int i = 0; i < 50; ++i)
			{
				KlasaSDestruktorom ksd = new KlasaSDestruktorom();
			}
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
