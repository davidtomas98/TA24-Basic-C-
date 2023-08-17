using System;
using System.Collections.Generic;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración para mostrar caracteres UTF-8 (como el símbolo del euro)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // MILESTONE 1
            Milestone1();
            PedirTeclaParaContinuar();

            // MILESTONE 2
            Milestone2();
            PedirTeclaParaContinuar();

            // MILESTONE 3
            Milestone3();
            PedirTeclaParaContinuar();
        }

        static void Milestone1()
        {
            Console.WriteLine("MILESTONE 1:");

            // Definición de los valores de los billetes y el precio total
            int[] billets = { 500, 200, 100, 50, 20, 10, 5 };
            int preuTotal = 0;

            // Definición del menú y sus precios
            string[] menu = { "Pizza Margherita", "Hamburguesa", "Sopa de Verduras" };
            int[] preus = { 12, 8, 6 };

            // Lista para almacenar la comanda
            List<string> comanda = new List<string>();

            // Bucle para seleccionar los platos y calcular el precio total
            int continuar = 1;
            while (continuar == 1)
            {
                Console.WriteLine("Menú:");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]} - {preus[i]}€");
                }
                Console.Write("Escull un plat (1-3): ");
                int opcio = ReadIntWithRetry(1, 3); // Lee un entero válido entre 1 y 3

                comanda.Add(menu[opcio - 1]);
                preuTotal += preus[opcio - 1];

                Console.Write("Vols continuar demanant menjar? (1: Si / 0: No): ");
                continuar = ReadIntWithRetry(0, 1); // Lee un entero válido entre 0 y 1
            }

            Console.WriteLine($"Preu total: {preuTotal}€");
        }

        static void Milestone2()
        {
            Console.WriteLine("MILESTONE 2:");

            // Definición del menú y sus precios usando un diccionario
            Dictionary<string, int> menu = new Dictionary<string, int>
            {
                { "Pizza Margherita", 12 },
                { "Hamburguesa", 8 },
                { "Sopa de Verduras", 6 }
            };
            int preuTotal = 0;

            // Lista para almacenar la comanda
            List<string> comanda = new List<string>();

            // Bucle para seleccionar los platos y calcular el precio total
            int continuar = 1;
            while (continuar == 1)
            {
                Console.WriteLine("Menú:");
                foreach (var plat in menu)
                {
                    Console.WriteLine($"{plat.Key} - {plat.Value}€");
                }
                Console.Write("Escull un plat: ");
                string platSeleccionat = Console.ReadLine();
                if (menu.ContainsKey(platSeleccionat))
                {
                    comanda.Add(platSeleccionat);
                    preuTotal += menu[platSeleccionat];
                }
                else
                {
                    Console.WriteLine("Plat no disponible.");
                }

                Console.Write("Vols continuar demanant menjar? (1: Si / 0: No): ");
                continuar = ReadIntWithRetry(0, 1); // Lee un entero válido entre 0 y 1
            }

            Console.WriteLine($"Preu total: {preuTotal}€");
        }

        static void Milestone3()
        {
            Console.WriteLine("MILESTONE 3:");

            try
            {
                // MILESTONE 1
                Milestone1();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                // MILESTONE 2
                Milestone2();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int ReadIntWithRetry(int min, int max)
        {
            while (true)
            {
                try
                {
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value >= min && value <= max)
                    {
                        return value;
                    }
                    Console.Write($"Introdueix un valor entre {min} i {max}: ");
                }
                catch (FormatException)
                {
                    Console.Write("Format incorrecte. Torna-ho a provar: ");
                }
            }
        }

        static void PedirTeclaParaContinuar()
        {
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
