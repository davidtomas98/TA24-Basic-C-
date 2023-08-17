using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // MILESTONE 1 - FASE 1
        Console.WriteLine("MILESTONE 1 - FASE 1:");
        char[] nameArray = { 'D', 'a', 'v', 'i', 'd' };
        MostrarArray(nameArray);
        PedirTeclaParaContinuar();

        // MILESTONE 1 - FASE 2
        Console.WriteLine("MILESTONE 1 - FASE 2:");
        List<char> nameList = new List<char>(nameArray);
        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        MostrarLetrasYTipo(nameList, vowels);
        PedirTeclaParaContinuar();

        // MILESTONE 1 - FASE 3
        Console.WriteLine("MILESTONE 1 - FASE 3:");
        Dictionary<char, int> letterFrequency = CalcularFrecuenciaLetras(nameList);
        MostrarFrecuenciaLetras(letterFrequency);
        PedirTeclaParaContinuar();

        // MILESTONE 1 - FASE 4
        Console.WriteLine("MILESTONE 1 - FASE 4:");
        List<char> surnameList = new List<char> { 'T', 'o', 'm', 'à', 's' };
        List<char> fullNameList = ConstruirNombreCompleto(nameList, surnameList);
        MostrarArray(fullNameList);
        PedirTeclaParaContinuar();

        // MILESTONE 2 - Ejercicio 1
        Console.WriteLine("MILESTONE 2 - Ejercicio 1:");
        ImprimirPiramideAscendente(5);
        PedirTeclaParaContinuar();

        // MILESTONE 2 - Ejercicio 2
        Console.WriteLine("MILESTONE 2 - Ejercicio 2:");
        ImprimirPiramideDescendente(5);
        PedirTeclaParaContinuar();

        // MILESTONE 3 - Reloj Digital
        Console.WriteLine("MILESTONE 3 - Reloj Digital:");
        MostrarRelojDigital();
    }

    // Mostrar los elementos de un array
    static void MostrarArray(char[] array)
    {
        foreach (char item in array)
        {
            Console.WriteLine(item);
        }
    }

    // Mostrar letras y su tipo (vocal, consonante)
    static void MostrarLetrasYTipo(List<char> lista, List<char> vocales)
    {
        foreach (char letra in lista)
        {
            if (Char.IsDigit(letra))
            {
                Console.WriteLine("Els noms de persones no contenen números!");
            }
            else if (Char.IsLetter(letra))
            {
                if (vocales.Contains(Char.ToLower(letra)))
                {
                    Console.WriteLine("VOCAL");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                }
            }
            else
            {
                Console.WriteLine(letra);
            }
        }
    }

    // Calcular frecuencia de letras en una lista
    static Dictionary<char, int> CalcularFrecuenciaLetras(List<char> lista)
    {
        Dictionary<char, int> frecuencia = new Dictionary<char, int>();
        foreach (char letra in lista)
        {
            if (Char.IsLetter(letra))
            {
                char lowerLetter = Char.ToLower(letra);
                if (frecuencia.ContainsKey(lowerLetter))
                {
                    frecuencia[lowerLetter]++;
                }
                else
                {
                    frecuencia[lowerLetter] = 1;
                }
            }
        }
        return frecuencia;
    }

    // Construir nombre completo a partir de nombres y apellidos
    static List<char> ConstruirNombreCompleto(List<char> nombre, List<char> apellido)
    {
        List<char> nombreCompleto = new List<char>(nombre);
        nombreCompleto.Add(' ');
        nombreCompleto.AddRange(apellido);
        return nombreCompleto;
    }

    // Imprimir pirámide ascendente
    static void ImprimirPiramideAscendente(int altura)
    {
        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    // Imprimir pirámide descendente
    static void ImprimirPiramideDescendente(int altura)
    {
        for (int i = altura; i >= 1; i--)
        {
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Mostrar reloj digital en consola
    static void MostrarRelojDigital()
    {
        int hour = 0, minutes = 0, seconds = 0;

        while (true)
        {
            Console.WriteLine($"{hour:D2}:{minutes:D2}:{seconds:D2}");
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
                if (minutes == 60)
                {
                    minutes = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    // Pausa y espera por la tecla Enter
    static void PedirTeclaParaContinuar()
    {
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
    }
}
