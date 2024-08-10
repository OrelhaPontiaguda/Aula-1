namespace Aula_1
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 116);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 0;
            label1.Text = "Resposta";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Swis721 BlkEx BT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(153, 171);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 1;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(153, 288);
            button2.Name = "button2";
            button2.Size = new Size(129, 35);
            button2.TabIndex = 4;
            button2.Text = "Multiplicação";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 345);
            button3.Name = "button3";
            button3.Size = new Size(128, 38);
            button3.TabIndex = 5;
            button3.Text = "Subtração";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Swis721 BlkEx BT", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(154, 230);
            button4.Name = "button4";
            button4.Size = new Size(128, 36);
            button4.TabIndex = 6;
            button4.Text = "Divisão";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}