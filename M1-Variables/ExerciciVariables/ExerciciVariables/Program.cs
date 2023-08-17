using System;

namespace ExerciciVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // FASE 1: Inicialización de variables
            string nom = "David";
            string cognom1 = "Tomás";
            string cognom2 = "Vergès";
            int dia = 19;
            int mes = 02;
            int any = 1998;

            Console.WriteLine("FASE 1: Inicialización de variables");
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Cognoms: {cognom1} {cognom2}");
            Console.WriteLine($"Data de naixement: {dia}/{mes}/{any}\n");

            // FASE 2: Cálculo de años bisiestos
            const int AnyTraspas = 1948;
            int cadaQuantsAnys = 4;
            int anyNaixement = 1998;

            int anysTraspas = (anyNaixement - AnyTraspas) / cadaQuantsAnys;

            Console.WriteLine("FASE 2: Cálculo de años bisiestos");
            Console.WriteLine($"Hi ha hagut {anysTraspas} anys de traspàs entre {AnyTraspas} i {anyNaixement}\n");

            // FASE 3: Bucle para mostrar años bisiestos
            Console.WriteLine("FASE 3: Bucle para mostrar años bisiestos");
            MostrarAnysBisiestos(AnyTraspas, anyNaixement);

            // FASE 4: Creación y visualización de variables compuestas
            string nomComplet = $"{nom} {cognom1} {cognom2}";
            string dataNaixement = $"{dia}/{mes}/{any}";

            Console.WriteLine("FASE 4: Creación y visualización de variables compuestas");
            Console.WriteLine($"El meu nom és {nomComplet}");
            Console.WriteLine($"Vaig néixer el {dataNaixement}");
            Console.WriteLine(EsAnyTraspas(anyNaixement) ? "El meu any de naixement és de traspàs." : "El meu any de naixement no és de traspàs.\n");

            // MILESTONE 2: Casting de un double a otros tipos
            PedirTeclaParaContinuar();
            double valorDouble = 12.3456;

            Console.WriteLine("MILESTONE 2: Casting de un double a otros tipos");
            MostrarCastingDeDouble(valorDouble);
            PedirTeclaParaContinuar();

            // MILESTONE 3: Rotación de un array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("\nMILESTONE 3: Rotación de un array");
            RotarArray(array);

            MostrarArray(array);
            PedirTeclaParaContinuar();
        }

        // FASE 3: Bucle para mostrar años bisiestos
        static void MostrarAnysBisiestos(int anyInicial, int anyFinal)
        {
            for (int anyActual = anyInicial; anyActual <= anyFinal; anyActual += 4)
            {
                Console.WriteLine(anyActual);
            }
        }

        // FASE 3: Comprobar si un año es bisiesto
        static bool EsAnyTraspas(int any)
        {
            return any % 4 == 0 && (any % 100 != 0 || any % 400 == 0);
        }

        // MILESTONE 2: Mostrar casting de un double a otros tipos
        static void MostrarCastingDeDouble(double valor)
        {
            int valorInt = (int)valor;
            float valorFloat = (float)valor;
            string valorString = valor.ToString("F4");

            Console.WriteLine($"Double: {valor}");
            Console.WriteLine($"Int: {valorInt}");
            Console.WriteLine($"Float: {valorFloat}");
            Console.WriteLine($"String: {valorString}\n");
        }

        // MILESTONE 3: Rotar los elementos de un array
        static void RotarArray(int[] array)
        {
            int temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }

        // MILESTONE 3: Mostrar los elementos de un array
        static void MostrarArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        // MILESTONE 3: Pedir al usuario que presione una tecla para continuar
        static void PedirTeclaParaContinuar()
        {
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
