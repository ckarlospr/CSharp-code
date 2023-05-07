namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*String edad = "28";
            int edad_n = int.Parse(edad);

            String prueba = "prueba de manejo";
            label1.Text = prueba;
            byte b = (byte)255;
            MessageBox.Show(b + "");*/
            /*if (txtAltura.Text != "" && txtPeso.Text != "")
            {
                Double altura = Double.Parse(txtAltura.Text);
                Double peso = Double.Parse(txtPeso.Text);


                lblResultado.Text = (peso / (altura * altura)).ToString();
            }*/

            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(20);   
            lista.Add(15);
            lista.Add(100);

            for (int i = 0; i < lista.Count; i++)
            {
                MessageBox.Show((lista[i]).ToString());
            }
        }
    }
}