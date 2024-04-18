namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,

        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
        }

        private void btnMultiplicaçao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textResultado.Text);
                    break;
            }
            textResultado.Text = Convert.ToString(Resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(","))
                textResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }
    }
}