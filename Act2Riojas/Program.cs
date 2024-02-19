using System;

namespace Act2Riojas
{
    class Program
    {
        
       
            static void Main(string[] args)
            {
                try
                {
                    // Creación de un objeto de la clase Bola con un peso de 1 kilogramo
                    Bola miBola = new Bola(1.0);
                    Console.WriteLine("Este programa simula la distancia que recorerria una bola que pesa 1k si es golpeada por una fuerza en newtons");

                    // Solicitar al usuario que ingrese la fuerza en Newton
                    Console.Write("Ingrese la fuerza en Newton: ");
                    double fuerza = Convert.ToDouble(Console.ReadLine());

                    // Calcular la distancia recorrida por la bola
                    double distanciaRecorrida = miBola.CalcularDistancia(fuerza);

                    // Mostrar la distancia recorrida por la bola
                    Console.WriteLine("La bola recorrerá una distancia de " + distanciaRecorrida.ToString("0.00") + " metros.");
                }
                catch (FormatException)
                {
                    // Captura y manejo de la excepción en caso de que el usuario ingrese un valor no válido
                    Console.WriteLine("Error: Por favor, ingrese un valor numérico válido.");
                }
                catch (Exception ex)
                {
                    // Captura y manejo de cualquier otra excepción no prevista
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }