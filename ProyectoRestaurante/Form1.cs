using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class Form1 : Form
    {
        //TODO: refactorizar  -->
        public static ArrayList bebidas;
        public static ArrayList comidas;
        public static ArrayList postres;
        public static ArrayList descuentos;
        public static ListBox lista;
        public static Label totalAPagar;
        public static double total;
        private static int descuento = 0;
        //<--
        public Form1()
        {
            InitializeComponent();
            comidas = new ArrayList();
            bebidas = new ArrayList();
            postres = new ArrayList();
            descuentos = new ArrayList();
            total = 0;
            this.ucDrinks1.Visible = true;
            this.ucDessert1.Visible = false;
            this.cuFood1.Visible = false;
            lista = this.listBox1;
            totalAPagar = this.labelTotalAPagar;
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.button3, "Boton para realizar el pago.");
        }
        public static void ClearCarrito()
        {
            bebidas.Clear();
            comidas.Clear();
            postres.Clear();
            UpdateCarrito();
        }
        public static void UpdateCarrito()
        {
            lista.Items.Clear();
            total = 0;
            int indice = 0;
            foreach (Bebida item in bebidas)
            {
                lista.Items.Add("B" + indice + " \t" + item.nombre + "\t\t--> " + item.precio + "€");
                total += item.precio;
                indice++;
            }
            indice = 0;
            foreach (Comida item in comidas)
            {
                if (item.nombre == "Tataki")
                {
                    lista.Items.Add("C" + indice + " \t" + item.nombre + "\t\t\t--> " + item.precio + "€");
                }
                else if (item.nombre == "Boquerones Frescos")
                {
                    lista.Items.Add("C" + indice + " \t" + item.nombre + "\t--> " + item.precio + "€");
                }
                else
                {
                    lista.Items.Add("C" + indice + " \t" + item.nombre + "\t\t--> " + item.precio + "€");
                }
                indice++;
            }
            indice = 0;
            foreach (Postre item in postres)
            {
                lista.Items.Add("P" + indice + " \t" + item.nombre + "\t\t--> " + item.precio + "€");
                indice++;
            }
            if (descuento > 0)
            {
                totalAPagar.Text = total * (descuento/100) + "€";
            }
            else
            {
                totalAPagar.Text = total + "€";
            }
            
        }
        public void WindowsManager(String select)
        {
            if (select == "food")
            {
                this.ucDrinks1.Visible = false;
                this.ucDessert1.Visible = false;
                this.cuFood1.Visible = true;
            }
            else if (select == "dessert")
            {
                this.ucDrinks1.Visible = false;
                this.ucDessert1.Visible = true;
                this.cuFood1.Visible = false;
            }
            else if (select == "drinks")
            {
                this.ucDrinks1.Visible = true;
                this.ucDessert1.Visible = false;
                this.cuFood1.Visible = false;
            }
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            WindowsManager("dessert");
        }

        private void panelFood1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            WindowsManager("drinks");
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            WindowsManager("food");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (total <= 0.0)
            {
                MessageBox.Show("No hay nada que pagar.", "No hay articulos en el carrito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormPago pago = new FormPago();
                pago.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                char[] aux = listBox1.SelectedItem.ToString().ToCharArray();
                Console.WriteLine(aux);
                String indice = "";
                if (aux[0] == 'B')
                {
                    foreach (char item in aux)
                    {
                        if (item != 'B' & item != ' ')
                        {
                            indice += item;
                        }
                        else if (item == ' ')
                        {
                            break;
                        }
                    }
                    bebidas.RemoveAt(Int32.Parse(indice));

                }
                if (aux[0] == 'C')
                {
                    foreach (char item in aux)
                    {
                        if (item != 'C' & item != ' ')
                        {
                            indice += item;
                        }
                        else if (item == ' ')
                        {
                            break;
                        }
                    }
                    comidas.RemoveAt(Int32.Parse(indice));

                }
                if (aux[0] == 'P')
                {
                    foreach (char item in aux)
                    {
                        if (item != 'P' & item != ' ')
                        {
                            indice += item;
                        }
                        else if (item == ' ')
                        {
                            break;
                        }
                    }
                    postres.RemoveAt(Int32.Parse(indice));

                }
            }
            
            UpdateCarrito();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearCarrito();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }
    }
}
