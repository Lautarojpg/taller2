namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            var apellido = textBox1.Text;
            var nombre = textBox2.Text;
            textBox3.Text = nombre + " " + apellido;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BSalir.Visible = true;
            }
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
