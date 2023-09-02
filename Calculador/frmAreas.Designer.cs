namespace Calculador
{
    partial class frmAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            rbtTriangulo = new System.Windows.Forms.RadioButton();
            rbtRectangulo = new System.Windows.Forms.RadioButton();
            rbtCirculo = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            lblValor1 = new System.Windows.Forms.Label();
            gboxAreas = new System.Windows.Forms.GroupBox();
            lblValor2 = new System.Windows.Forms.Label();
            txtValor1 = new System.Windows.Forms.TextBox();
            txtValor2 = new System.Windows.Forms.TextBox();
            btnCalcular = new System.Windows.Forms.Button();
            txtResultado = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gboxAreas.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(292, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(341, 351);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rbtTriangulo
            // 
            rbtTriangulo.AutoSize = true;
            rbtTriangulo.Location = new System.Drawing.Point(15, 47);
            rbtTriangulo.Name = "rbtTriangulo";
            rbtTriangulo.Size = new System.Drawing.Size(74, 19);
            rbtTriangulo.TabIndex = 1;
            rbtTriangulo.Text = "Triangulo";
            rbtTriangulo.UseVisualStyleBackColor = true;
            rbtTriangulo.CheckedChanged += rbtTriangulo_CheckedChanged;
            // 
            // rbtRectangulo
            // 
            rbtRectangulo.AutoSize = true;
            rbtRectangulo.Checked = true;
            rbtRectangulo.Location = new System.Drawing.Point(15, 22);
            rbtRectangulo.Name = "rbtRectangulo";
            rbtRectangulo.Size = new System.Drawing.Size(85, 19);
            rbtRectangulo.TabIndex = 2;
            rbtRectangulo.TabStop = true;
            rbtRectangulo.Text = "Rectangulo";
            rbtRectangulo.UseVisualStyleBackColor = true;
            rbtRectangulo.CheckedChanged += rbtRectangulo_CheckedChanged;
            // 
            // rbtCirculo
            // 
            rbtCirculo.AutoSize = true;
            rbtCirculo.Location = new System.Drawing.Point(15, 72);
            rbtCirculo.Name = "rbtCirculo";
            rbtCirculo.Size = new System.Drawing.Size(63, 19);
            rbtCirculo.TabIndex = 3;
            rbtCirculo.Text = "Circulo";
            rbtCirculo.UseVisualStyleBackColor = true;
            rbtCirculo.CheckedChanged += rbtCirculo_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(239, 15);
            label1.TabIndex = 4;
            label1.Text = "SELECCIONE EL TIPO DE AREA A CALCULAR";
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new System.Drawing.Point(44, 175);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new System.Drawing.Size(31, 15);
            lblValor1.TabIndex = 5;
            lblValor1.Text = "Base";
            lblValor1.Click += lblValor_Click;
            // 
            // gboxAreas
            // 
            gboxAreas.Controls.Add(rbtRectangulo);
            gboxAreas.Controls.Add(rbtTriangulo);
            gboxAreas.Controls.Add(rbtCirculo);
            gboxAreas.Location = new System.Drawing.Point(29, 57);
            gboxAreas.Name = "gboxAreas";
            gboxAreas.Size = new System.Drawing.Size(231, 100);
            gboxAreas.TabIndex = 6;
            gboxAreas.TabStop = false;
            gboxAreas.Text = "TIPO DE AREAS";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new System.Drawing.Point(44, 213);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new System.Drawing.Size(39, 15);
            lblValor2.TabIndex = 7;
            lblValor2.Text = "Altura";
            // 
            // txtValor1
            // 
            txtValor1.Location = new System.Drawing.Point(126, 167);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new System.Drawing.Size(134, 23);
            txtValor1.TabIndex = 8;
            // 
            // txtValor2
            // 
            txtValor2.Location = new System.Drawing.Point(126, 205);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new System.Drawing.Size(134, 23);
            txtValor2.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new System.Drawing.Point(32, 295);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new System.Drawing.Point(126, 246);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new System.Drawing.Size(134, 23);
            txtResultado.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 249);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 12;
            label3.Text = "Area";
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(185, 385);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmAreas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(659, 425);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblValor2);
            Controls.Add(gboxAreas);
            Controls.Add(lblValor1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmAreas";
            Text = "frmAreas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gboxAreas.ResumeLayout(false);
            gboxAreas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtTriangulo;
        private System.Windows.Forms.RadioButton rbtRectangulo;
        private System.Windows.Forms.RadioButton rbtCirculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.GroupBox gboxAreas;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}