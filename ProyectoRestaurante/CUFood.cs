using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class CUFood : UserControl
    {
        public CUFood()
        {
            InitializeComponent();
        }

        private void panelFood1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Boquerones Frescos", 10.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Boquerones Frescos");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Boquerones Frescos", 10.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Boquerones Frescos");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Boquerones Frescos", 10.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Boquerones Frescos");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Boquerones Frescos", 10.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Boquerones Frescos");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Bacaladilla", 15.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Bacaladilla");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Bacaladilla", 15.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Bacaladilla");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Bacaladilla", 15.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Bacaladilla");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Bacaladilla", 15.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Bacaladilla");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Tataki", 17.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Tataki");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Tataki", 17.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Tataki");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Tataki", 17.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Tataki");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1.comidas.Add(new Comida("Tataki", 17.0));
            Form1.UpdateCarrito();
            Console.WriteLine("Tataki");
        }
    }
}
