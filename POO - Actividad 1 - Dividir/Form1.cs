namespace POO___Actividad_1___Dividir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Divicion odivicion = new Divicion(int.Parse(Valor1.Text), int.Parse(Valor2.Text));
            Resultado.Text = odivicion.divide().ToString();
        }
    }
}