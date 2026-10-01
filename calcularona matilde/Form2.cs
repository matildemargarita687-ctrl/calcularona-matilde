using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularona_matilde
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)//Este es el indentificador de nuestro boton de suma
        {
            byte Num1 = byte.Parse(textNum1.Text); //Aqui guardamos el valor de la priemra variable que ingresamos
            byte Num2 = byte.Parse(textNum2.Text); //Aqui gaurdamos el valor de la segunda variable que ingresamos 
            int Suma = Num1 + Num2; //Realizamos la operacion y la guardamos en la variable suma
            MessageBox.Show("El R// es" + Suma); //Mostramos el resultado de la operacion

        }

        private void BtnResta_Click(object sender, EventArgs e)// Este es el identificador de nuestro boton de resta
        {
            byte Num1 = byte.Parse(textNum1.Text); //Aqui guardamos el valor de la primera variable que ingresamos
            byte Num2 = byte.Parse(textNum2.Text); //Aqui guardamos el valor de la primera variable que ingresamos
            int Resta = Num1 - Num2; //Realizamos la operacion y la guardamos en la variable resta
            MessageBox.Show("El R// es" + Resta); //Mostramos el resultado de la operacion

        }

        private void BtnDiv_Click(object sender, EventArgs e)// Este es el identificador de nuestro boton de division
        {
            float Num1 = byte.Parse(textNum1.Text);// aqui obtenemos el primer numero  y se guarda en la variable num1
            float Num2 = byte.Parse(textNum2.Text);// aqui ibtenemos el segundo numero y se guarda en la variable num2
            if (Num2 > 0)//es el inicio de la condicion if tomando en cuenta  que cualquier numero positivo si tiene un resultado real
            {//llave de incio del if
                float division = Num1 / Num2;// esta es la operacion de la division 
                MessageBox.Show("El R// es" + division);// mostramos el resultado de la division
            }//finalizamos el if
            else// es el else anidado a la  condicion if sucede cuando la condicion inicial no se cumple
            {// llave de inicio else 
                MessageBox.Show("La divison es indefinida");// mostramos el mensaje cuando sengundo numero  es 0

            }//fin del else y la condicion

        }

        private void BtnPro_Click(object sender, EventArgs e)// Este es el identificador de nuestro boton de producto
        {
            byte Num1 = byte.Parse(textNum1.Text); //Aqui guardamos el valor de la primera variable que ingresamos
            byte Num2 = byte.Parse(textNum2.Text); //Aqui guardamos el valor de la primera variable que ingresamos
            int Producto = Num1 * Num2; //Realizamos la operacion y la guardamos en la variable producto
            MessageBox.Show("El R// es" + Producto); //Mostramos el resultado de la operacion

        }

        private void BtnRaiz_Click(object sender, EventArgs e)// Este es el identificador de nuestro boton de raiz
        {
            float Num1 = float.Parse(textNum1.Text);//aqui pedimos el numero que deseamos ver la raiz
            if (Num1 < 0)//primera  condicion if porque no existe raiz de un numero negativo 
            {// llave de inicio if
                MessageBox.Show("No existe raiz para un numero negativo");// Mostramos el mensaje  cuando el numero es negativo
            }//fin de if1
            if (Num1 == 0)//segundo condicion if cuando el numero es 0
            {//llave de inicio
                MessageBox.Show("El Resultado es : 0");//mostramos el resultado de 0 raiz se 0 es 0

                return;//retorno para volver al form2
            }//fin de if2
            else//else anidado a ambos if si ninguna de las condiciones se cumple 
            {//inicio de la ecuacopn de la raiz utilizando el metodo rhapsody
                float raiz = Num1 / 2;//iniciamos el metodo diviendo el numero entre 2 por ejemplo (26/2)=13
                float anterior;//asignamos la variable anterior
                double Tolerancia = 0.00001;//asiganamos  la toredancia que tan exacata queremos la raiz entre  mas 0 es mas exsacta

                do// es el inicio del ciclo para ejecutar el metodo Rhapsody cada vez que se  repite la raiz es mas exacta 
                {//inicio del ciclo
                    anterior = raiz;//utilizamos anterior para empezar el ciclo y guardar el dato  ingresado 
                    raiz = (raiz + (Num1 / raiz)) / 2;// se hace el metodo rhapsody dividiendo el resultado en 2
                    float diferencia = raiz - anterior;//hacemos una diferencia entre la ultima resta y el resultado del metodo

                    if (diferencia < 0)// es la condicion si la diferencia es mayor que 0 vamos a disminuir  su mismo valor para determinar la tolerancia
                    {//llave de inicio de if
                        diferencia = -anterior;//restamos la diferencia a 
                    }//fin de llave if
                    if (diferencia > Tolerancia)//segunda condicion con el valor de la diferencia asumiendo que un cumple condicion de ser menor que la tolerancia
                    {//llave de inicio del if
                        break;//cremos una pausa para finalizar
                    }//fin del if
                }// fin del ciclo do
                while (true);//cuando el resultado este listo el ciclo do while   termina asumiendo un valor verdadero
                MessageBox.Show("El resultado es raiz" + raiz);//mostramos resultado de la raiz
            }// cada vez que el ciclo repite el resultado se acerca su valor // la tplerrancia entre mas ceros tengas mas exacta la raiz lo ideal es tener entre 6 a 8 ceros paras calcular una raiz

        }//fin de la operacion raiz
        //el metodo rhapsody es el  2ds metodo 
        private void BtnExp_Click(object sender, EventArgs e)//identificar del boton de una potencia (exponente)
        {
            int Num1 = int.Parse(textNum1.Text);
            int Num2 = int.Parse(textNum2.Text);
            int Potencia = 1;
            int J = 0;
            while (J != Num2)
            {
                Potencia = Potencia * Num1;
                J++;
            }
            MessageBox.Show("El resultado es" + Potencia);
        }

        private void BtnFac_Click(object sender, EventArgs e)// Este es el identificador de nuestro boton  de factorial
        {
            int Num1 = int.Parse(textNum1.Text);
            int Num2 = int.Parse(textNum2.Text);
            long j = 1;
            for (int i = 0; i < Num1;)
            {
                j = j * i;
            }
            MessageBox.Show("El Resultado es" + j);

        }
    }
}

