namespace Aula_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int soma = numero1 + numero2;
            label1.Text = "Soma: " + soma.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int multiplicar = numero1 * numero2;
            label1.Text = "Multiplicação: " + multiplicar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int subtrair = numero1 - numero2;
            label1.Text = "Subtração: " + subtrair.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(textBox1.Text);
            double numero2 = double.Parse(textBox2.Text);
            double dividir = numero1 / numero2;
            label1.Text = "Divisão: " + dividir.ToString();
        }
    }
}