using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class FormPago : Form
    {
        private double total;
        String mesa = "M003";
        public FormPago()
        {
            InitializeComponent();
            this.total = Form1.total;
            labelTotal.Text = total + "€";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Descuento item in Form1.descuentos)
            {
                Console.WriteLine(item.codigo);
                if (textBoxCod.Text == item.codigo)
                {
                    Console.WriteLine("APLICA: " + item.codigo);
                    Console.WriteLine("DESCUENTO: " + item.descuento);
                    Console.WriteLine("TOTAL ANTES: " + total);
                    double operacion = (item.descuento / 100.0);
                    Console.WriteLine("VALOR OPERACION: " + ((Form1.total * 1.0) * operacion));
                    total = Form1.total - (Form1.total * operacion);
                    Console.WriteLine("TOTAL DESPUES: " + total);
                    labelTotal.Text = total + "€";
                    break;
                }
            }
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pago se ha realizado correctamente. Este pendiente a la pantalla con el codigo: " + mesa,"Pago correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.ClearCarrito();
            this.Close();
        }
    }
}
