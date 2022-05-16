// See https://aka.ms/new-console-template for more information
 int n, entero;
            double dec;
            Console.Write("Ingrese un #: ");
            n = Convert.ToInt32(Console.ReadLine());

            entero = n / 2;
            dec = (double)n / 2;
            if (entero - dec == 0)
            {
                Console.WriteLine("El numero {0} es par.", n);
            }

            else
            {
                Console.WriteLine("El numero {0} es impar.", n);

            }// fin del if
            Console.ReadKey();
