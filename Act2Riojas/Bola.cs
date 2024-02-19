using System;
using System.Collections.Generic;
using System.Text;

namespace Act2Riojas
{
    class Bola
    {
        // Miembro de la clase Bola: peso (en kilogramos)
        private double peso;

        // Constructor de la clase Bola
        public Bola(double peso)
        {
            this.peso = peso;
        }

        // Método de la clase Bola para calcular la distancia recorrida
        public double CalcularDistancia(double fuerza)
        {
            // Declaración de una variable local para la aceleración debido a la gravedad (en m/s^2)
            double gravedad = 9.8;

            // Cálculo de la aceleración usando la fuerza y el peso
            double aceleracion = fuerza / peso;

            // Cálculo de la distancia utilizando la fórmula de movimiento uniformemente acelerado
            double distancia = (fuerza / peso) * (fuerza / (2 * gravedad));

            // Retorno de la distancia calculada
            return distancia;
        }
    }
}

