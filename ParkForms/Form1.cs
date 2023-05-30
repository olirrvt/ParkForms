using System.Globalization;
using System.IO;

namespace ParkForms
{
    public partial class Form1 : Form
    {
        private string caminhoEntrada = @"C:\Users\taylor.oliveira\Desktop\parkforms\EntradaVeiculos.dat";
        private string caminhoSaida = @"C:\Users\taylor.oliveira\Desktop\parkforms\SaidaVeiculos.dat";

        private List<Veiculo> lista;
        private int vagas = 50;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Veiculo>();
            exibeVagas();

            timer1.Start();
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
                    MessageBox.Show("Hor�rio de entrada inv�lido. \n Os carros s� podem ser cadastrados de 07:00 �s 20:00. ", "Aten��o");
                }
            }
            else
            {
                MessageBox.Show("Formato de hora inv�lido. Use o formato HH:mm.", "Aten��o");
            }

            return false;
        }

        // Registrar Entrada ou Sa�da
        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculo;
            bool remove = false;
            string placaVeiculo = lblPlaca.Text.ToUpper();
            string horaEntrada = lblEntrada.Text;
            string horaSaida = lblSaida.Text;

            if (vagas == 0)
            {
                MessageBox.Show("N�o temos vagas no momento!", "Aten��o");
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
                            Persistencia.gravarArquivoVeiculosEntrada(lista, caminhoEntrada);
                            lstEntrada.Items.Add($"Placa: {veiculo.PlacaVeiculo} | Data: {veiculo.DataEntrada} | Entrada: {veiculo.HoraEntrada}");
                        }
                        else
                        {
                            MessageBox.Show("Esse ve�culo j� est� na garagem!", "Aten��o");
                        }
                    }
                }
                else if (!String.IsNullOrEmpty(horaSaida))
                {
                    veiculo = lista.Find(v => v.PlacaVeiculo.Equals(placaVeiculo, StringComparison.OrdinalIgnoreCase));

                    if (veiculo != null)
                    {
                        // Removendo o ve�culo da lista

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

                            Persistencia.atualizarSaidaArquivo(veiculo, caminhoSaida);
                            lstSaida.Items.Add($"{veiculo.PlacaVeiculo} | {veiculo.DataEntrada} | {veiculo.HoraEntrada} | {veiculo.TempoPermanencia} minutos | R$ {veiculo.ValorCobrado},00");
                            MessageBox.Show($"O ve�culo ficou: {veiculo.TempoPermanencia} minutos no estacionamento \n O valor a ser cobrado �: R$ {veiculo.ValorCobrado},00 reais", "Aviso de Cobran�a");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ve�culo n�o encontrado na garagem!", "Aten��o");
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor para registrar!", "Aten��o");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
