namespace Proyecto1Avanzada
{
    partial class Crear_Categorias
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
            label1 = new Label();
            label2 = new Label();
            txtNombreC = new TextBox();
            txtDescripcionC = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 188);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 231);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(208, 185);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(147, 23);
            txtNombreC.TabIndex = 4;
            // 
            // txtDescripcionC
            // 
            txtDescripcionC.Location = new Point(208, 228);
            txtDescripcionC.Name = "txtDescripcionC";
            txtDescripcionC.Size = new Size(147, 23);
            txtDescripcionC.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(159, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 76);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 18);
            label3.Name = "label3";
            label3.Size = new Size(203, 37);
            label3.TabIndex = 7;
            label3.Text = "Crear Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(79, 271);
            button1.Name = "button1";
            button1.Size = new Size(276, 43);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Crear_Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 326);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtDescripcionC);
            Controls.Add(txtNombreC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Crear_Categorias";
            Text = "Crear_Categorias";
            Load += Crear_Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreC;
        private TextBox txtDescripcionC;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
    }
}