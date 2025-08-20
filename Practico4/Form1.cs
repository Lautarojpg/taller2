namespace Practico4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BFuncion_Click(object sender, EventArgs e)
        {
            if (TDesde.Text == "" || THasta.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en ambos campos.");
                return;
            }
            else if (int.TryParse(TDesde.Text, out int desde) && int.TryParse(THasta.Text, out int hasta))
            {
                if (desde > hasta)
                {
                    MessageBox.Show("El valor de 'Desde' debe ser menor o igual al valor de 'Hasta'.");
                    return;
                }
                else
                {
                    chart1.Series["Series1"].Points.Clear();
                    for (int i = desde; i <= hasta; i++)
                    {
                        LBLista.Items.Add(i);
                        chart1.Series["Series1"].Points.AddXY(i, i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            if (TDesde.Text == "" || THasta.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en ambos campos.");
                return;
            }
            else if (int.TryParse(TDesde.Text, out int desde) && int.TryParse(THasta.Text, out int hasta))
            {
                if (desde > hasta)
                {
                    MessageBox.Show("El valor de 'Desde' debe ser menor o igual al valor de 'Hasta'.");
                    return;
                }
                else
                {
                    chart1.Series["Series1"].Points.Clear();
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (i % 2 != 0)
                        {
                            LBLista.Items.Add(i);
                            chart1.Series["Series1"].Points.AddXY(i, i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void BPares_Click(object sender, EventArgs e)
        {
            if (TDesde.Text == "" || THasta.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en ambos campos.");
                return;
            }
            else if (int.TryParse(TDesde.Text, out int desde) && int.TryParse(THasta.Text, out int hasta))
            {
                if (desde > hasta)
                {
                    MessageBox.Show("El valor de 'Desde' debe ser menor o igual al valor de 'Hasta'.");
                    return;
                }
                else
                {
                    chart1.Series["Series1"].Points.Clear();
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (i % 2 == 0)
                        {
                            LBLista.Items.Add(i);
                            chart1.Series["Series1"].Points.AddXY(i, i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            if (TDesde.Text == "" || THasta.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en ambos campos.");
                return;
            }
            else if (int.TryParse(TDesde.Text, out int desde) && int.TryParse(THasta.Text, out int hasta))
            {
                if (desde > hasta)
                {
                    MessageBox.Show("El valor de 'Desde' debe ser menor o igual al valor de 'Hasta'.");
                    return;
                }
                else
                {
                    chart1.Series["Series1"].Points.Clear();
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (esPrimo(i))
                        {
                            LBLista.Items.Add(i);
                            chart1.Series["Series1"].Points.AddXY(i, i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        bool esPrimo(int numero)
        {
            if (numero < 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
