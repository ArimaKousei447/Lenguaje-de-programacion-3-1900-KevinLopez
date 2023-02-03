using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            decimal numero1 = 0;
            


            //Cuerpo de programa
            numero1 = Convert.ToDecimal(txtNumero.Text);

            
            lblRespuesta1.Text = comprobarParOImpar(numero1);
            lblRespuesta2.Text = comprobarSigno(numero1);

        }

        //Funciones
        private string comprobarParOImpar(decimal numero1)
        {
            //Declaracion de variables
            string respuesta1;

            //Cuerpo de la funcion 
            if (numero1 %  2 == 0)
            {
                respuesta1 = "El numero es par";
            }
            else
            {
                respuesta1 = "El numero es impar";

            }

            return respuesta1;
        }

        private string comprobarSigno(decimal numero1)
        {
            //Declaracion de variables
            string respuesta2;


            //Cuerpo de la funcion
            if (numero1 > 0)
            {
                respuesta2 = "El numero es positivo";
            }
            else
            {
                respuesta2 = "El numero es negativo";

            }


            return respuesta2;
        }


    }
}
