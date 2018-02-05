using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaracion de objetos globales
        Pen lapizNegro = new Pen(Color.Black); //dibujamos las lineas del plano
        Pen lapizRojo = new Pen(Color.Red, 2);//dibujamos los puntos rojos
        Pen lapizAzul = new Pen(Color.Blue, 2);//dibujamos los puntos azules
        Pen lapizVerde = new Pen(Color.Green);//dibujamos la linea del perceptron

        //Listas donde se guardaran los puntos
        List<Punto> listaPuntos = new List<Punto>(); // 1 son Azules -1 son rojos
        //Lista de pesos
        List<float[]> listaPesos = new List<float[]>();


        /// <summary>
        /// Inicializamos el plano
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plano_Paint(object sender, PaintEventArgs e)
        {
            //dibujamos el plano
            int xcentro = Plano.Width/2;//obtenemos el centro
            int ycentro = Plano.Height/2;//obtenemos el centro
            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1,-1);
            //Dibujamos los ejes X y Y
            e.Graphics.DrawLine(lapizNegro, xcentro*-1,0, xcentro*2,0);//eje X
            e.Graphics.DrawLine(lapizNegro, 0,ycentro, 0, ycentro*-1);//eje X
        }

        /// <summary>
        /// Metodo que dibuja los puntos rojos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plano_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.Plano.CreateGraphics();
            //int X = 0, Y = 0;
            //dibujamos el plano
            //int xcentro = Plano.Width / 2;//obtenemos el centro
            //int ycentro = Plano.Height / 2;//obtenemos el centro
            //Coordenada en X segun el click
            //X = e.X - xcentro;
            //Coordenada en Y segun el click
            //Y = ycentro - e.Y;

            //Checamos cual boton del mouse se preciono
            if(e.Button == MouseButtons.Right) { //puntos azules
                g.DrawPie(lapizAzul, e.X, e.Y, 6, 6, 360, 360);
                listaPuntos.Add(new Punto(e.Location,1));
            }
            else//puntos azules
            {
                g.DrawPie(lapizRojo, e.X, e.Y, 6, 6, 360, 360);
                listaPuntos.Add(new Punto(e.Location,-1));
            }
        }

        /// <summary>
        /// Dibuja una linea dados dos puntos
        /// Esta funcion dibujara la linea que genere el perceptron
        /// </summary>
        /// <param name="coordenada1"></param>
        /// <param name="coordenada2"></param>
        /// <param name="color"></param>
        private void dibujarLinea(Point coordenada1, Point coordenada2, Pen color)
        {
            Graphics g = this.Plano.CreateGraphics();
            g.DrawLine(color,coordenada1,coordenada2);
        }

        /// <summary>
        /// Dibuja una linea dados dos puntos
        /// Esta funcion dibujara solo un momento para simular los cambios que hara el perceptron
        /// </summary>
        /// <param name="coordenada1"></param>
        /// <param name="coordenada2"></param>
        /// <param name="color"></param>
        private void dibujarLineaTemporal(Point coordenada1, Point coordenada2, Pen color)
        {
            Graphics g = this.Plano.CreateGraphics();
            g.DrawLine(color, coordenada1, coordenada2);
            Thread.Sleep(100);
            g.DrawLine(new Pen(SystemColors.Control), coordenada1, coordenada2);
            Thread.Sleep(100);
        }

        /// <summary>
        /// Inicia el entrenamiento del perceptron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Validamos que se haya puntos en el mapa
            if(listaPuntos.Count == 0)
            {
                MessageBox.Show("Debe agregar minimo un punto de cada tipo");
                return;
            }

            int tamEntradas = listaPuntos.Count;
            Perceptron P = new Perceptron();
            bool terminado = false;
            int contadorEpocas = 0;
            int error = 0;
            //Inicializa la lista de pesos
            listaPesos = P.generaPesosRandom(tamEntradas);

            //Mientras no este terminado o se alla agotado la cantidad de epocas
            while (contadorEpocas < (int)epocas.Value && !terminado)
            {
                terminado = true;
                //Vamos pasando cada entrada con su respectivo peso
                for(int i = 0; i < tamEntradas; i++)
                {
                    //dibujamos la linea resultante
                    dibujarLinea(new Point(0, (int)coordenadaY(listaPesos.ElementAt(i), 0)), new Point(500,(int)coordenadaY(listaPesos.ElementAt(i), 500)), lapizAzul);
                    error = P.calculaError(listaPuntos.ElementAt(i), listaPesos.ElementAt(i), listaPuntos.ElementAt(i).tipo);
                    //Hay que entrenar ese peso
                    if (error != 0)
                    {
                        terminado = false;
                        //Realiza el ajuste
                        listaPesos.ElementAt(i)[0] = error * listaPuntos.ElementAt(i).coordenada.X * (float)learningRate.Value;
                        listaPesos.ElementAt(i)[1] = error * listaPuntos.ElementAt(i).coordenada.Y * (float)learningRate.Value;

                    }
                }
                contadorEpocas++;
                
            }

            //Mostramos las epocas en las que se concluyo el entrenamiento
            muestraEpocas.Text = contadorEpocas.ToString();
            muestraEpocas.Refresh();

            
            if(contadorEpocas == epocas.Value)
                MessageBox.Show("El perceptron no pudo terminar el entrenamiento");
            else
            {
                MessageBox.Show("Ha concluido el entrenamiento sin errores");
            }
            
        }

        float coordenadaY(float[] peso, float x)
        {
            //Sacamos la funcion de la recta y= mx + b
            //x es la entrada
            // w2 es el umbral que siempre es 1
            float w0 = peso[0];
            float w1 = peso[1];
            float w2 = 1; //Siempre sera 1
            return -(w2 / w1) - (w0 / w1) * x;
        }

    }
}
