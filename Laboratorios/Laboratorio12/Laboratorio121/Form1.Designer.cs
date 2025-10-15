namespace Laboratorio121
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblVelocidad = new Label();
            lblTiempo = new Label();
            lblDistanciaTotal = new Label();
            txtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            txtDistanciaTotal = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(193, 27);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(147, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculo del movil";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(59, 78);
            lblVelocidad.Margin = new Padding(4, 0, 4, 0);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(89, 25);
            lblVelocidad.TabIndex = 1;
            lblVelocidad.Text = "Velocidad";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(76, 147);
            lblTiempo.Margin = new Padding(4, 0, 4, 0);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(72, 25);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo";
            // 
            // lblDistanciaTotal
            // 
            lblDistanciaTotal.AutoSize = true;
            lblDistanciaTotal.Location = new Point(59, 301);
            lblDistanciaTotal.Margin = new Padding(4, 0, 4, 0);
            lblDistanciaTotal.Name = "lblDistanciaTotal";
            lblDistanciaTotal.Size = new Size(125, 25);
            lblDistanciaTotal.TabIndex = 3;
            lblDistanciaTotal.Text = "Distancia Total";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(180, 72);
            txtVelocidad.Margin = new Padding(4, 5, 4, 5);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(228, 31);
            txtVelocidad.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(180, 144);
            txtTiempo.Margin = new Padding(4, 5, 4, 5);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(228, 31);
            txtTiempo.TabIndex = 5;
            // 
            // txtDistanciaTotal
            // 
            txtDistanciaTotal.Location = new Point(211, 295);
            txtDistanciaTotal.Margin = new Padding(4, 5, 4, 5);
            txtDistanciaTotal.Name = "txtDistanciaTotal";
            txtDistanciaTotal.Size = new Size(228, 31);
            txtDistanciaTotal.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(59, 223);
            btnCalcular.Margin = new Padding(4, 5, 4, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 38);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(193, 223);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 38);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(332, 223);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 525);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistanciaTotal);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(lblDistanciaTotal);
            Controls.Add(lblTiempo);
            Controls.Add(lblVelocidad);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblVelocidad;
        private Label lblTiempo;
        private Label lblDistanciaTotal;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private TextBox txtDistanciaTotal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
