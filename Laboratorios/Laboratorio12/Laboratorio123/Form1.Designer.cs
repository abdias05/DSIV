namespace Laboratorio123
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
            lblLadoA = new Label();
            lblLadoB = new Label();
            lblLadoC = new Label();
            lblSemiPerimetro = new Label();
            lblArea = new Label();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            txtSemiPerimetro = new TextBox();
            txtArea = new TextBox();
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(50, 41);
            lblLadoA.Margin = new Padding(4, 0, 4, 0);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(246, 25);
            lblLadoA.TabIndex = 0;
            lblLadoA.Text = "Ingresa la longitud del lado A";
            lblLadoA.Click += lblLadoA_Click;
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(52, 116);
            lblLadoB.Margin = new Padding(4, 0, 4, 0);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(244, 25);
            lblLadoB.TabIndex = 1;
            lblLadoB.Text = "Ingresa la longitud del lado B";
            // 
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Location = new Point(50, 192);
            lblLadoC.Margin = new Padding(4, 0, 4, 0);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(245, 25);
            lblLadoC.TabIndex = 2;
            lblLadoC.Text = "Ingresa la longitud del lado C";
            // 
            // lblSemiPerimetro
            // 
            lblSemiPerimetro.AutoSize = true;
            lblSemiPerimetro.Location = new Point(80, 347);
            lblSemiPerimetro.Margin = new Padding(4, 0, 4, 0);
            lblSemiPerimetro.Name = "lblSemiPerimetro";
            lblSemiPerimetro.Size = new Size(195, 25);
            lblSemiPerimetro.TabIndex = 3;
            lblSemiPerimetro.Text = "Calcular Semiperimetro";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(80, 423);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(153, 25);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area del triangulo";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(335, 41);
            txtLadoA.Margin = new Padding(4, 5, 4, 5);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(141, 31);
            txtLadoA.TabIndex = 5;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(335, 110);
            txtLadoB.Margin = new Padding(4, 5, 4, 5);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(141, 31);
            txtLadoB.TabIndex = 6;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(333, 186);
            txtLadoC.Margin = new Padding(4, 5, 4, 5);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(141, 31);
            txtLadoC.TabIndex = 7;
            // 
            // txtSemiPerimetro
            // 
            txtSemiPerimetro.Location = new Point(333, 344);
            txtSemiPerimetro.Margin = new Padding(4, 5, 4, 5);
            txtSemiPerimetro.Name = "txtSemiPerimetro";
            txtSemiPerimetro.Size = new Size(141, 31);
            txtSemiPerimetro.TabIndex = 8;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(333, 417);
            txtArea.Margin = new Padding(4, 5, 4, 5);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(141, 31);
            txtArea.TabIndex = 9;
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(42, 264);
            btnSemiperimetro.Margin = new Padding(4, 5, 4, 5);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(145, 47);
            btnSemiperimetro.TabIndex = 10;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiperimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(201, 264);
            btnArea.Margin = new Padding(4, 5, 4, 5);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(124, 47);
            btnArea.TabIndex = 11;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(338, 264);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(136, 47);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(486, 266);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 45);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 500);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Controls.Add(txtArea);
            Controls.Add(txtSemiPerimetro);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
            Controls.Add(lblArea);
            Controls.Add(lblSemiPerimetro);
            Controls.Add(lblLadoC);
            Controls.Add(lblLadoB);
            Controls.Add(lblLadoA);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Calculos Triangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblLadoC;
        private Label lblSemiPerimetro;
        private Label lblArea;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private TextBox txtSemiPerimetro;
        private TextBox txtArea;
        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalir;
    }
}