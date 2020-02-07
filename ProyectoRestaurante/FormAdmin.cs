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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            updateDescuentos();
            this.panelLog.Visible = true;
            this.panelLog.BringToFront();
            this.panelAdmin.Visible = false;
        }
        public void updateDescuentos()
        {
            this.comboBox1.Items.Clear();
            foreach (Descuento item in Form1.descuentos)
            {
                this.comboBox1.Items.Add(item.codigo);
            }
        }
        public void deleteDescuento()
        {
            int a = 0;
            foreach (Descuento item in Form1.descuentos)
            {
                if (this.comboBox1.Text == item.codigo)
                {
                    Form1.descuentos.RemoveAt(a);
                    break;
                }
                a++;
            }
            updateDescuentos();
            this.comboBox1.Text = "";
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxCodigo.Text != "" && this.textBoxPorc.Text != "")
            {
                Form1.descuentos.Add(new Descuento(this.textBoxCodigo.Text, Int32.Parse(this.textBoxPorc.Text)));
            }
            this.textBoxCodigo.Text = "";
            this.textBoxPorc.Text = "";
            updateDescuentos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteDescuento();
            updateDescuentos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBoxLogin.Text == "0000")
            {
                this.panelLog.Visible = false;
                this.panelAdmin.Visible = true;
                this.panelAdmin.BringToFront();
            }
        }
    }
}
