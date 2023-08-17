using System;


namespace ExerciciNomsCiutats
{
    class Program
    {
        static void Main(string[] args)
        {
            // MILESTONE 1 - Noms Ciutats
            Milestone1_NomsCiutats();
            PedirTeclaParaContinuar();

            // MILESTONE 2 - Array Bidimensional de Notas
            Milestone2_ArrayBidimensional();
            PedirTeclaParaContinuar();

            // MILESTONE 3 - Secuencia de Fibonacci
            Milestone3_SecuenciaFibonacci();
            PedirTeclaParaContinuar();
        }

        static void Milestone1_NomsCiutats()
        {
            Console.WriteLine("MILESTONE 1 - Noms Ciutats:");

            string[] ciutats = new string[6];

            // FASE 1 - Introducir nombres de ciudades
            Console.WriteLine("FASE 1 - Introduce los nombres de las ciudades:");
            for (int i = 0; i < ciutats.Length; i++)
            {
                Console.Write($"Introduce el nombre de la ciudad {i + 1}: ");
                ciutats[i] = Console.ReadLine();
            }

            // Mostrar nombres de ciudades introducidos
            Console.WriteLine("\nNombres de ciudades introducidos:");
            foreach (string ciutat in ciutats)
            {
                Console.WriteLine(ciutat);
            }
            Console.WriteLine("Presiona Enter para continuar a la siguiente fase...");
            Console.ReadLine();

            // Ordenar las ciudades alfabéticamente
            Array.Sort(ciutats);

            // Modificar y ordenar las ciudades modificadas
            string[] arrayCiutatsModificades = new string[ciutats.Length];
            for (int i = 0; i < ciutats.Length; i++)
            {
                arrayCiutatsModificades[i] = ciutats[i].Replace('a', '4');
            }
            Array.Sort(arrayCiutatsModificades);

            // Invertir los nombres de ciudades
            string[] arrayNomsInvertits = new string[ciutats.Length];
            for (int i = 0; i < ciutats.Length; i++)
            {
                char[] nomCiutatArray = ciutats[i].ToCharArray();
                Array.Reverse(nomCiutatArray);
                arrayNomsInvertits[i] = new string(nomCiutatArray);
            }

            // Mostrar ciudades ordenadas alfabéticamente
            Console.WriteLine("\nFASE 2 - Ciudades ordenadas alfabéticamente:");
            foreach (string ciutat in ciutats)
            {
                Console.WriteLine(ciutat);
            }
            Console.WriteLine("Presiona Enter para continuar a la siguiente fase...");
            Console.ReadLine();

            // Mostrar ciudades modificadas y ordenadas
            Console.WriteLine("\nFASE 3 - Ciudades modificadas y ordenadas:");
            foreach (string ciutatModificada in arrayCiutatsModificades)
            {
                Console.WriteLine(ciutatModificada);
            }
            Console.WriteLine("Presiona Enter para continuar a la siguiente fase...");
            Console.ReadLine();

            // Mostrar nombres de ciudades invertidos
            Console.WriteLine("\nFASE 4 - Nombres de ciudades invertidos:");
            foreach (string nomInvertit in arrayNomsInvertits)
            {
                Console.WriteLine(nomInvertit);
            }
            Console.WriteLine("Presiona Enter para continuar al siguiente milestone...");
            Console.ReadLine();
        }

        static void Milestone2_ArrayBidimensional()
        {
            Console.WriteLine("MILESTONE 2 - Array Bidimensional de Notas:");

            double[,] notas = new double[5, 3];

            // Introducir notas de los alumnos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Alumno {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    double nota;
                    do
                    {
                        Console.Write($"Introduce la nota {j + 1}: ");
                    } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10);

                    notas[i, j] = nota;
                }
            }

            // Calcular promedio y mostrar estado de aprobación
            Console.WriteLine("\nNotas y estado de aprobación:");
            for (int i = 0; i < 5; i++)
            {
                double sumaNotas = 0;
                for (int j = 0; j < 3; j++)
                {
                    sumaNotas += notas[i, j];
                }
                double promedio = sumaNotas / 3;

                Console.Write($"Alumno {i + 1}: Notas [{string.Join(", ", notas[i, 0], notas[i, 1], notas[i, 2])}] ");
                Console.WriteLine(promedio >= 5 ? "Aprobado" : "Suspendido");
            }
            Console.WriteLine("Presiona Enter para continuar al siguiente milestone...");
            Console.ReadLine();
        }

        static void Milestone3_SecuenciaFibonacci()
        {
            Console.WriteLine("MILESTONE 3 - Secuencia de Fibonacci:");

            Console.Write("Introduce el número N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            Console.Write("Serie de Fibonacci: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }

        static void PedirTeclaParaContinuar()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}