namespace taller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
            int numero = 1231;
            MessageBox.Show($"El numero es: {numero}");
        }
    }
}
