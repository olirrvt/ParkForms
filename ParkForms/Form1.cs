namespace ParkForms
{
    public partial class Form1 : Form
    {
        private List<Veiculo> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Veiculo>();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            lblEntrada.Enabled = true;

            lblSaida.Enabled = false;
            lblSaida.Clear();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            lblSaida.Enabled = true;

            lblEntrada.Enabled = false;
            lblEntrada.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculo;
            bool remove = false;
            string placaVeiculo = lblPlaca.Text;
            string horaEntrada = lblEntrada.Text;
            string horaSaida = lblSaida.Text;

            if (!String.IsNullOrEmpty(horaEntrada))
            {
                veiculo = new Veiculo(placaVeiculo, horaEntrada);

                if (!lista.Contains(veiculo))
                {
                    lista.Add(veiculo);
                    lstEntrada.Items.Add($"Placa: {veiculo.PlacaVeiculo} | Data: {veiculo.DataEntrada} | Entrada: {veiculo.HoraEntrada}");
                }
                else
                {
                    MessageBox.Show("Esse veículo já está na garagem!");
                }

            }
            else if (!String.IsNullOrEmpty(horaSaida))
            {
                veiculo = lista.Find(v => v.PlacaVeiculo.Equals(placaVeiculo, StringComparison.OrdinalIgnoreCase));

                if (veiculo != null)
                {
                    // Removendo o veículo da lista

                    for (int i = lista.Count - 1; i >= 0; i--)
                    {
                        if (placaVeiculo == lista[i].PlacaVeiculo)
                        {
                            lista.RemoveAt(i);
                            remove = true;
                        }
                    }

                    if (remove)
                    {
                        veiculo.RegistrarSaida(horaSaida);
                        veiculo.CalculaTempoPermanencia();

                        lstSaida.Items.Add($"{veiculo.PlacaVeiculo} | {veiculo.DataEntrada} | {veiculo.HoraEntrada} | {veiculo.TempoPermanencia} minutos | R$ {veiculo.ValorCobrado},00");
                    }
                }
                else
                {
                    MessageBox.Show("Veículo não encontrado na garagem!");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor para registrar!");
            }
        }
    }
}
