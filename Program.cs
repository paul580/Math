using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double redondear = 8.55;
            int cuatro = 4;

            
            Console.WriteLine("Escribe un numero para sacar la raiz cuadrada");
            int numeroRaiz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Raiz cuadrada: {System.Math.Sqrt(numeroRaiz)}");

          
            Console.WriteLine("Escribe un numero para elevarlo a la 3ta potencia");
            int numero4ta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {System.Math.Pow(numero4ta, cuatro)}");

        
            Console.WriteLine("Escribe un numero para sacar el signo");
            int signoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {System.Math.Sign(signoNumero)}");

            
            Console.WriteLine("Escribe un numero para verificar cual es el mas grande");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero para ver cual es mas grande");
            int numeroDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero mas grande: {System.Math.Max(numeroUno, numeroDos)}");

            Console.WriteLine("Escribe un numero para ver cual es mas grande sin importar el simbolo ");
            int numeroUnoSimbolo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero para ver cual es mas grande sin importar el simbolo ");
            int numeroDosSimbolo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero mas grande: {System.Math.Max(System.Math.Abs(numeroUnoSimbolo), System.Math.Abs(numeroDosSimbolo))}");

            Console.WriteLine("Escribe un numero con decimales, para quitárselos");
            decimal numeroDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Numero sin decimales: {System.Math.Truncate(numeroDecimal)}");
            Console.WriteLine($"8.55 redondeado: {System.Math.Round(redondear)}");
        }
    }
}