namespace Laboratorio122
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblPromedio = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtPromedio = new TextBox();
            btnPromedio = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(169, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nota Promedio";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(84, 68);
            lblNota1.Margin = new Padding(4, 0, 4, 0);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(106, 25);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "NOTA No. 1";
            lblNota1.Click += lblNota1_Click;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(84, 126);
            lblNota2.Margin = new Padding(4, 0, 4, 0);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(106, 25);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "NOTA No. 2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(84, 182);
            lblNota3.Margin = new Padding(4, 0, 4, 0);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(106, 25);
            lblNota3.TabIndex = 3;
            lblNota3.Text = "NOTA No. 3";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(77, 338);
            lblPromedio.Margin = new Padding(4, 0, 4, 0);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(134, 25);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Nota Promedio";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(219, 65);
            txtNota1.Margin = new Padding(4, 5, 4, 5);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(141, 31);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(219, 120);
            txtNota2.Margin = new Padding(4, 5, 4, 5);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(141, 31);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(219, 182);
            txtNota3.Margin = new Padding(4, 5, 4, 5);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(141, 31);
            txtNota3.TabIndex = 7;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(219, 332);
            txtPromedio.Margin = new Padding(4, 5, 4, 5);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(141, 31);
            txtPromedio.TabIndex = 8;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(41, 258);
            btnPromedio.Margin = new Padding(4, 5, 4, 5);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(107, 38);
            btnPromedio.TabIndex = 9;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(178, 258);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(107, 38);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(319, 258);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 492);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblPromedio);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Calcular Promedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblPromedio;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtPromedio;
        private Button btnPromedio;
        private Button btnReset;
        private Button btnSalir;
    }
}
