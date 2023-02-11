using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

           decimal resultado = await calcularPromedio (nota1,nota2,nota3,nota4);

            MessageBox.Show(" El promedio final es: " + resultado );
        }


        private async Task<decimal> calcularPromedio(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (nota1 + nota2 + nota3 + nota4)/4;
            });
                return promedio;
        }

    }
}
