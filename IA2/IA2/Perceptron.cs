using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA2
{
    class Perceptron
    {

        public Perceptron() { }

        /// <summary>
        /// Genera el random de pesos entre los valores de 1 y -1
        /// </summary>
        /// <returns></returns>
        public List<float[]> generaPesosRandom(int tam)
        {
            List<float[]> peso = new List<float[]>();
            Random random = new Random();
            var buffer = new byte[4];
            for (int i = 0; i < tam; i++)
            {
                float[] aux = new float[2];
                double mantissa = (random.NextDouble() * 2.0) - 1.0;
                double exponent = Math.Pow(2.0, random.Next(-1, 1));
                aux[0] = (float)(mantissa * exponent);

                mantissa = (random.NextDouble() * 2.0) - 1.0;
                exponent = Math.Pow(2.0, random.Next(-1, 1));
                aux[1] = (float)(mantissa * exponent);
                peso.Add(aux);
            }
            return peso;
        }

        /// <summary>
        /// Calcula el producto punto de dos listas
        /// listaPuntos es el vector de entradas
        /// listaPesos es el vector de pesos
        /// </summary>
        /// <param name="listaPuntos">Vector de entradas</param>
        /// <param name="listaPesos">Vectro de pesos</param>
        /// <returns></returns>
        public int adivina(Punto entrada, float[] Pesos)
        {
            float suma = 0;
            //Producto punto

                //Se repite para los dos elementos de los vectores
                suma += entrada.coordenada.X * Pesos.ElementAt(0);
                suma += entrada.coordenada.Y * Pesos.ElementAt(1);

            return signo(suma);
        }

        /// <summary>
        /// Funcion de activacion
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int signo(float sum) { 
            if(sum >= 0 ) return 1;
            else return -1;
        }

        /// <summary>
        /// Calcula el error del perceptron
        /// </summary>
        /// <param name="entrada"></param>
        /// <param name="Pesos"></param>
        /// <param name="salidaDeseada"></param>
        /// <returns></returns>
        public int calculaError(Punto entrada, float[] Pesos, int salidaDeseada)
        {
            int res = adivina(entrada, Pesos);
            return salidaDeseada - res;
        }
    }
}
