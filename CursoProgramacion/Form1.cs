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
            String prueba = "prueba de manejo";
            label1.Text = prueba;
            byte b = (byte)12;
            MessageBox.Show(b+"");
        }
    }
}