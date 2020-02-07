namespace ProyectoRestaurante
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeaderTittle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonQuitarCarrito = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ucDrinks1 = new ProyectoRestaurante.UCDrinks();
            this.ucDessert1 = new ProyectoRestaurante.UCDessert();
            this.cuFood1 = new ProyectoRestaurante.CUFood();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonDessert = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Azure;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.labelHeaderTittle);
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1256, 116);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeaderTittle
            // 
            this.labelHeaderTittle.AutoSize = true;
            this.labelHeaderTittle.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTittle.Location = new System.Drawing.Point(19, 30);
            this.labelHeaderTittle.Name = "labelHeaderTittle";
            this.labelHeaderTittle.Size = new System.Drawing.Size(477, 46);
            this.labelHeaderTittle.TabIndex = 0;
            this.labelHeaderTittle.Text = "LA ESQUINITA DE MATT";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Azure;
            this.panelMain.Controls.Add(this.ucDrinks1);
            this.panelMain.Controls.Add(this.ucDessert1);
            this.panelMain.Controls.Add(this.cuFood1);
            this.panelMain.Controls.Add(this.buttonAdmin);
            this.panelMain.Controls.Add(this.buttonDessert);
            this.panelMain.Controls.Add(this.buttonFood);
            this.panelMain.Controls.Add(this.buttonDrinks);
            this.panelMain.Location = new System.Drawing.Point(12, 127);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(829, 581);
            this.panelMain.TabIndex = 1;
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.Azure;
            this.panelCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCheck.Controls.Add(this.labelTotalAPagar);
            this.panelCheck.Controls.Add(this.button3);
            this.panelCheck.Controls.Add(this.button2);
            this.panelCheck.Controls.Add(this.buttonQuitarCarrito);
            this.panelCheck.Controls.Add(this.listBox1);
            this.panelCheck.Location = new System.Drawing.Point(840, 127);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(428, 581);
            this.panelCheck.TabIndex = 2;
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Location = new System.Drawing.Point(336, 533);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(36, 17);
            this.labelTotalAPagar.TabIndex = 4;
            this.labelTotalAPagar.Text = "0.0€";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Vaciar Carrito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonQuitarCarrito
            // 
            this.buttonQuitarCarrito.Location = new System.Drawing.Point(6, 516);
            this.buttonQuitarCarrito.Name = "buttonQuitarCarrito";
            this.buttonQuitarCarrito.Size = new System.Drawing.Size(94, 51);
            this.buttonQuitarCarrito.TabIndex = 1;
            this.buttonQuitarCarrito.Text = "Quitar del Carrito";
            this.buttonQuitarCarrito.UseVisualStyleBackColor = true;
            this.buttonQuitarCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 484);
            this.listBox1.TabIndex = 0;
            // 
            // ucDrinks1
            // 
            this.ucDrinks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDrinks1.Location = new System.Drawing.Point(139, 7);
            this.ucDrinks1.Name = "ucDrinks1";
            this.ucDrinks1.Size = new System.Drawing.Size(685, 568);
            this.ucDrinks1.TabIndex = 7;
            // 
            // ucDessert1
            // 
            this.ucDessert1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDessert1.Location = new System.Drawing.Point(139, 7);
            this.ucDessert1.Name = "ucDessert1";
            this.ucDessert1.Size = new System.Drawing.Size(685, 568);
            this.ucDessert1.TabIndex = 6;
            // 
            // cuFood1
            // 
            this.cuFood1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuFood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuFood1.Location = new System.Drawing.Point(139, 7);
            this.cuFood1.Name = "cuFood1";
            this.cuFood1.Size = new System.Drawing.Size(685, 568);
            this.cuFood1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ProyectoRestaurante.Properties.Resources.pagar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(229, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Pagar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdmin.BackgroundImage = global::ProyectoRestaurante.Properties.Resources.admin;
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Location = new System.Drawing.Point(4, 511);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(133, 64);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = " ";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonDessert
            // 
            this.buttonDessert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDessert.BackgroundImage = global::ProyectoRestaurante.Properties.Resources.dessert;
            this.buttonDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDessert.Location = new System.Drawing.Point(4, 285);
            this.buttonDessert.Name = "buttonDessert";
            this.buttonDessert.Size = new System.Drawing.Size(133, 133);
            this.buttonDessert.TabIndex = 3;
            this.buttonDessert.Text = " ";
            this.buttonDessert.UseVisualStyleBackColor = false;
            this.buttonDessert.Click += new System.EventHandler(this.buttonDessert_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFood.BackgroundImage = global::ProyectoRestaurante.Properties.Resources.food;
            this.buttonFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFood.Location = new System.Drawing.Point(3, 146);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(133, 133);
            this.buttonFood.TabIndex = 2;
            this.buttonFood.Text = " ";
            this.buttonFood.UseVisualStyleBackColor = false;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDrinks.BackgroundImage = global::ProyectoRestaurante.Properties.Resources.drinks;
            this.buttonDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrinks.Location = new System.Drawing.Point(4, 7);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(133, 133);
            this.buttonDrinks.TabIndex = 1;
            this.buttonDrinks.Text = " ";
            this.buttonDrinks.UseVisualStyleBackColor = false;
            this.buttonDrinks.Click += new System.EventHandler(this.buttonDrinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Restaurante";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.Label labelHeaderTittle;
        private System.Windows.Forms.Button buttonDessert;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Button buttonAdmin;
        private CUFood cuFood1;
        private UCDrinks ucDrinks1;
        private UCDessert ucDessert1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonQuitarCarrito;
        private System.Windows.Forms.Label labelTotalAPagar;
    }
}

