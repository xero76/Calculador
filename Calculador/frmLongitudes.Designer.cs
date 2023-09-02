namespace Calculador
{
    partial class frmLongitudes
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
            label1 = new System.Windows.Forms.Label();
            txtValor = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cmbOrigen = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cmbDestino = new System.Windows.Forms.ComboBox();
            btnProcesar = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtResultado = new System.Windows.Forms.TextBox();
            btnSalir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "CONVERTIR";
            // 
            // txtValor
            // 
            txtValor.Location = new System.Drawing.Point(86, 42);
            txtValor.Name = "txtValor";
            txtValor.Size = new System.Drawing.Size(133, 23);
            txtValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(59, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "DE";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "Metros", "Centimetros", "Milimetros" });
            cmbOrigen.Location = new System.Drawing.Point(86, 100);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new System.Drawing.Size(121, 23);
            cmbOrigen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(237, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(15, 15);
            label3.TabIndex = 4;
            label3.Text = "A";
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Metros", "Centimetros", "Milimetros" });
            cmbDestino.Location = new System.Drawing.Point(284, 100);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new System.Drawing.Size(121, 23);
            cmbDestino.TabIndex = 5;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new System.Drawing.Point(59, 171);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new System.Drawing.Size(90, 31);
            btnProcesar.TabIndex = 6;
            btnProcesar.Text = "PROCESAR";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(183, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "RESULTADO";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new System.Drawing.Point(284, 176);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new System.Drawing.Size(121, 23);
            txtResultado.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(330, 228);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLongitudes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(433, 263);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(btnProcesar);
            Controls.Add(cmbDestino);
            Controls.Add(label3);
            Controls.Add(cmbOrigen);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "frmLongitudes";
            Text = "frmLongitudes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}