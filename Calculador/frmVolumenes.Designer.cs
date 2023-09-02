namespace Calculador
{
    partial class frmVolumenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVolumenes));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnCalcular = new System.Windows.Forms.Button();
            txtValor1 = new System.Windows.Forms.TextBox();
            lblValor1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbtCono = new System.Windows.Forms.RadioButton();
            rbtCilindro = new System.Windows.Forms.RadioButton();
            rbtEsfera = new System.Windows.Forms.RadioButton();
            rbtCubo = new System.Windows.Forms.RadioButton();
            lblValor2 = new System.Windows.Forms.Label();
            txtValor2 = new System.Windows.Forms.TextBox();
            lblResultado = new System.Windows.Forms.Label();
            txtResultado = new System.Windows.Forms.TextBox();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(405, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(383, 426);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new System.Drawing.Point(71, 230);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(100, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new System.Drawing.Point(71, 138);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new System.Drawing.Size(100, 23);
            txtValor1.TabIndex = 2;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new System.Drawing.Point(10, 141);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new System.Drawing.Size(33, 15);
            lblValor1.TabIndex = 3;
            lblValor1.Text = "Lado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCono);
            groupBox1.Controls.Add(rbtCilindro);
            groupBox1.Controls.Add(rbtEsfera);
            groupBox1.Controls.Add(rbtCubo);
            groupBox1.Location = new System.Drawing.Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(387, 79);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el Volumen a calcular";
            // 
            // rbtCono
            // 
            rbtCono.AutoSize = true;
            rbtCono.Location = new System.Drawing.Point(137, 44);
            rbtCono.Name = "rbtCono";
            rbtCono.Size = new System.Drawing.Size(54, 19);
            rbtCono.TabIndex = 3;
            rbtCono.TabStop = true;
            rbtCono.Text = "Cono";
            rbtCono.UseVisualStyleBackColor = true;
            rbtCono.CheckedChanged += rbtCono_CheckedChanged;
            // 
            // rbtCilindro
            // 
            rbtCilindro.AutoSize = true;
            rbtCilindro.Location = new System.Drawing.Point(137, 19);
            rbtCilindro.Name = "rbtCilindro";
            rbtCilindro.Size = new System.Drawing.Size(67, 19);
            rbtCilindro.TabIndex = 2;
            rbtCilindro.Text = "Cilindro";
            rbtCilindro.UseVisualStyleBackColor = true;
            rbtCilindro.CheckedChanged += rbtCilindro_CheckedChanged;
            // 
            // rbtEsfera
            // 
            rbtEsfera.AutoSize = true;
            rbtEsfera.Location = new System.Drawing.Point(43, 44);
            rbtEsfera.Name = "rbtEsfera";
            rbtEsfera.Size = new System.Drawing.Size(56, 19);
            rbtEsfera.TabIndex = 1;
            rbtEsfera.Text = "Esfera";
            rbtEsfera.UseVisualStyleBackColor = true;
            rbtEsfera.CheckedChanged += rbtEsfera_CheckedChanged;
            // 
            // rbtCubo
            // 
            rbtCubo.AutoSize = true;
            rbtCubo.Checked = true;
            rbtCubo.Location = new System.Drawing.Point(43, 19);
            rbtCubo.Name = "rbtCubo";
            rbtCubo.Size = new System.Drawing.Size(54, 19);
            rbtCubo.TabIndex = 0;
            rbtCubo.TabStop = true;
            rbtCubo.Text = "Cubo";
            rbtCubo.UseVisualStyleBackColor = true;
            rbtCubo.CheckedChanged += rbtCubo_CheckedChanged;
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new System.Drawing.Point(10, 188);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new System.Drawing.Size(39, 15);
            lblValor2.TabIndex = 5;
            lblValor2.Text = "Altura";
            lblValor2.Visible = false;
            // 
            // txtValor2
            // 
            txtValor2.Location = new System.Drawing.Point(71, 186);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new System.Drawing.Size(100, 23);
            txtValor2.TabIndex = 6;
            txtValor2.Visible = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new System.Drawing.Point(203, 141);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new System.Drawing.Size(54, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Volumen";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new System.Drawing.Point(263, 138);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new System.Drawing.Size(100, 23);
            txtResultado.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(203, 230);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(102, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmVolumenes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(txtValor2);
            Controls.Add(lblValor2);
            Controls.Add(groupBox1);
            Controls.Add(lblValor1);
            Controls.Add(txtValor1);
            Controls.Add(btnCalcular);
            Controls.Add(pictureBox1);
            Name = "frmVolumenes";
            Text = "Calculadora de Volumenes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCilindro;
        private System.Windows.Forms.RadioButton rbtEsfera;
        private System.Windows.Forms.RadioButton rbtCubo;
        private System.Windows.Forms.RadioButton rbtCono;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}