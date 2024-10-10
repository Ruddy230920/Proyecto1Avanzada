namespace Proyecto1Avanzada
{
    partial class Crear_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreP = new TextBox();
            txtPrecioUnidad = new TextBox();
            txtUnidadStock = new TextBox();
            cmboxSuplidorP = new ComboBox();
            cmboxCategoriaP = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUnidadPedido = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            txtCantidadUnidad = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(189, 98);
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(200, 23);
            txtNombreP.TabIndex = 0;
            // 
            // txtPrecioUnidad
            // 
            txtPrecioUnidad.Location = new Point(189, 161);
            txtPrecioUnidad.Name = "txtPrecioUnidad";
            txtPrecioUnidad.Size = new Size(200, 23);
            txtPrecioUnidad.TabIndex = 1;
            // 
            // txtUnidadStock
            // 
            txtUnidadStock.Location = new Point(189, 224);
            txtUnidadStock.Name = "txtUnidadStock";
            txtUnidadStock.Size = new Size(200, 23);
            txtUnidadStock.TabIndex = 2;
            // 
            // cmboxSuplidorP
            // 
            cmboxSuplidorP.FormattingEnabled = true;
            cmboxSuplidorP.Location = new Point(189, 380);
            cmboxSuplidorP.Name = "cmboxSuplidorP";
            cmboxSuplidorP.Size = new Size(200, 23);
            cmboxSuplidorP.TabIndex = 3;
            // 
            // cmboxCategoriaP
            // 
            cmboxCategoriaP.FormattingEnabled = true;
            cmboxCategoriaP.Location = new Point(189, 438);
            cmboxCategoriaP.Name = "cmboxCategoriaP";
            cmboxCategoriaP.Size = new Size(200, 23);
            cmboxCategoriaP.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 101);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 164);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Precio por Unidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 227);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 7;
            label3.Text = "Unidad por Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 291);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 8;
            label4.Text = "Unidad bajo Pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 383);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Suplidor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 30);
            label6.Name = "label6";
            label6.Size = new Size(276, 37);
            label6.TabIndex = 10;
            label6.Text = "Creacion De Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 441);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 11;
            label7.Text = "Categoria";
            // 
            // txtUnidadPedido
            // 
            txtUnidadPedido.Location = new Point(189, 288);
            txtUnidadPedido.Name = "txtUnidadPedido";
            txtUnidadPedido.Size = new Size(200, 23);
            txtUnidadPedido.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(82, 497);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(56, 555);
            button1.Name = "button1";
            button1.Size = new Size(333, 44);
            button1.TabIndex = 14;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCantidadUnidad
            // 
            txtCantidadUnidad.Location = new Point(189, 339);
            txtCantidadUnidad.Name = "txtCantidadUnidad";
            txtCantidadUnidad.Size = new Size(200, 23);
            txtCantidadUnidad.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 342);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 15;
            label8.Text = "Cantidad por Unidad";
            // 
            // Crear_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 611);
            Controls.Add(txtCantidadUnidad);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(txtUnidadPedido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmboxCategoriaP);
            Controls.Add(cmboxSuplidorP);
            Controls.Add(txtUnidadStock);
            Controls.Add(txtPrecioUnidad);
            Controls.Add(txtNombreP);
            Name = "Crear_Productos";
            Text = "Crear_Productos";
            Load += Crear_Productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreP;
        private TextBox txtPrecioUnidad;
        private TextBox txtUnidadStock;
        private ComboBox cmboxSuplidorP;
        private ComboBox cmboxCategoriaP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUnidadPedido;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox txtCantidadUnidad;
        private Label label8;
    }
}