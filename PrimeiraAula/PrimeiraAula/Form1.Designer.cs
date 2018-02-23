namespace PrimeiraAula
{
    partial class frmPrincipal
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
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.txbSegundoNumero = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AccessibleName = "";
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(29, 18);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AccessibleName = "";
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(29, 67);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNumero.TabIndex = 1;
            this.lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // lblResultado
            // 
            this.lblResultado.AccessibleName = "";
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Aqua;
            this.lblResultado.Location = new System.Drawing.Point(29, 276);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txbPrimeiroNumero
            // 
            this.txbPrimeiroNumero.Location = new System.Drawing.Point(32, 34);
            this.txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            this.txbPrimeiroNumero.Size = new System.Drawing.Size(241, 20);
            this.txbPrimeiroNumero.TabIndex = 3;
            // 
            // txbSegundoNumero
            // 
            this.txbSegundoNumero.Location = new System.Drawing.Point(32, 83);
            this.txbSegundoNumero.Name = "txbSegundoNumero";
            this.txbSegundoNumero.Size = new System.Drawing.Size(241, 20);
            this.txbSegundoNumero.TabIndex = 4;
            // 
            // btnSoma
            // 
            this.btnSoma.AccessibleName = "btnSoma";
            this.btnSoma.BackColor = System.Drawing.Color.Maroon;
            this.btnSoma.ForeColor = System.Drawing.Color.White;
            this.btnSoma.Location = new System.Drawing.Point(49, 133);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(86, 42);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.Text = "Somar";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.AccessibleName = "btnSubtração";
            this.btnSubtração.BackColor = System.Drawing.Color.Maroon;
            this.btnSubtração.Location = new System.Drawing.Point(174, 133);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(86, 42);
            this.btnSubtração.TabIndex = 6;
            this.btnSubtração.Text = "Subtrair";
            this.btnSubtração.UseVisualStyleBackColor = false;
            this.btnSubtração.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.AccessibleName = "btnMultiplicação";
            this.btnMultiplicação.BackColor = System.Drawing.Color.Maroon;
            this.btnMultiplicação.Location = new System.Drawing.Point(49, 194);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(86, 42);
            this.btnMultiplicação.TabIndex = 7;
            this.btnMultiplicação.Text = "Multiplicar";
            this.btnMultiplicação.UseVisualStyleBackColor = false;
            this.btnMultiplicação.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.AccessibleName = "btnDivisão";
            this.btnDivisão.BackColor = System.Drawing.Color.Maroon;
            this.btnDivisão.Location = new System.Drawing.Point(174, 194);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(86, 42);
            this.btnDivisão.TabIndex = 8;
            this.btnDivisão.Text = "Dividir";
            this.btnDivisão.UseVisualStyleBackColor = false;
            this.btnDivisão.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPrincipal
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(305, 308);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnMultiplicação);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txbSegundoNumero);
            this.Controls.Add(this.txbPrimeiroNumero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MINI CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbPrimeiroNumero;
        private System.Windows.Forms.TextBox txbSegundoNumero;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btnMultiplicação;
        private System.Windows.Forms.Button btnDivisão;
    }
}

