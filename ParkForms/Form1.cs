using System.Globalization;

namespace ParkForms
{
    public partial class Form1 : Form
    {
        private List<Veiculo> lista;
        private int vagas = 50;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Veiculo>();
            exibeVagas();
        }

        private void exibeVagas()
        {
            lblVagas.Text = $"{vagas.ToString()} vagas";
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

        private static bool VerificarHorarioEntrada(string horaEntrada)
        {
            if (DateTime.TryParseExact(horaEntrada, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime hora))
            {
                DateTime horaMinima = DateTime.ParseExact("07:00", "HH:mm", CultureInfo.InvariantCulture);
                DateTime horaMaxima = DateTime.ParseExact("20:00", "HH:mm", CultureInfo.InvariantCulture);

                if (hora >= horaMinima && hora <= horaMaxima)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Horário de entrada inválido. \n Os carros só podem ser cadastrados de 07:00 às 20:00. ");
                }
            }
            else
            {
                MessageBox.Show("Formato de hora inválido. Use o formato HH:mm.");
            }

            return false;
        }

        // Registrar Entrada ou Saída
        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculo;
            bool remove = false;
            string placaVeiculo = lblPlaca.Text;
            string horaEntrada = lblEntrada.Text;
            string horaSaida = lblSaida.Text;

            if (vagas == 0)
            {
                MessageBox.Show("Não temos vagas no momento!");
            }
            else
            {
                if (!String.IsNullOrEmpty(horaEntrada))
                {
                    if (VerificarHorarioEntrada(horaEntrada))
                    {
                        veiculo = new Veiculo(placaVeiculo, horaEntrada);

                        if (!lista.Contains(veiculo))
                        {
                            vagas--;
                            exibeVagas();

                            lista.Add(veiculo);
                            lstEntrada.Items.Add($"Placa: {veiculo.PlacaVeiculo} | Data: {veiculo.DataEntrada} | Entrada: {veiculo.HoraEntrada}");
                        }
                        else
                        {
                            MessageBox.Show("Esse veículo já está na garagem!");
                        }
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

                            vagas++;
                            exibeVagas();

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
}
