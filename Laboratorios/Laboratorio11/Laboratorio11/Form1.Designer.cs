namespace Laboratorio11
{
    partial class btnClickThis
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
            button1 = new Button();
            lblHelloWord = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(291, 141);
            button1.Name = "button1";
            button1.Size = new Size(147, 64);
            button1.TabIndex = 0;
            button1.Text = "Click this";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblHelloWord
            // 
            lblHelloWord.AutoSize = true;
            lblHelloWord.Location = new Point(289, 228);
            lblHelloWord.Name = "lblHelloWord";
            lblHelloWord.Size = new Size(59, 25);
            lblHelloWord.TabIndex = 1;
            lblHelloWord.Text = "label1";
            lblHelloWord.Click += lblHelloWord_Click;
            // 
            // btnClickThis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWord);
            Controls.Add(button1);
            Name = "btnClickThis";
            Text = "Form1";
            Load += btnClickThis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblHelloWord;
    }
}
