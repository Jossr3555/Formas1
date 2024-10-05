using System;
using System.Windows.Forms;

namespace TDSN2024
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool isTimerRunning = false;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 200; 
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirRaio(false);
            ExibirLado(false);
            ExibirAltura(false);
            ExibirBase(false);
            cmbTriangulo.Visible = false;
            cmbTriangulo.Enabled = false;

            switch (cmbForma.Text)
            {
                case "Circunferência":
                    ExibirRaio(true);
                    break;
                case "Quadrado":
                    ExibirLado(true);
                    break;
                case "Triângulo":
                    cmbTriangulo.Visible = true;
                    cmbTriangulo.Enabled = true;
                    cmbTriangulo_SelectedIndexChanged(cmbTriangulo, EventArgs.Empty);
                    break;
                case "Retângulo":
                    ExibirLado(true);
                    ExibirAltura(true);
                    break;
            }
            if (cmbForma.Text == "Triângulo" && !isTimerRunning)
            {
                timer.Start();
                isTimerRunning = true;
            }
            else
            {
                timer.Stop();
                isTimerRunning = false;
            }
        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirAltura(false);
            ExibirBase(false);
            ExibirLado(false);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (cmbForma.Text == "Triângulo")
            {
                switch (cmbTriangulo.Text)
                {
                    case "Equilátero":
                        ExibirLado(true);
                        ExibirBase(false);
                        ExibirAltura(false);
                        break;
                    case "Isósceles":
                        ExibirBase(true);
                        ExibirLado(true);
                        ExibirAltura(false);
                        break;
                    case "Reto":
                        ExibirBase(true);
                        ExibirAltura(true);
                        ExibirLado(false);
                        break;
                    default:
                        ExibirAltura(false);
                        ExibirBase(false);
                        ExibirLado(false);
                        break;
                }
            }
            else
            {
                timer.Stop();
                isTimerRunning = false;
                ExibirAltura(false);
                ExibirBase(false);
                ExibirLado(false);
            }
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }
        private void ExibirLado(bool visivel)
        {
            lblLado.Visible = txtLado.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FormaGeometrica objeto = null;

            switch (cmbForma.Text)
            {
                case "Quadrado":
                    if (ValidarEntrada(txtLado, "lado"))
                    {
                        objeto = new Quadrado { Lado = Convert.ToDouble(txtLado.Text) };
                    }
                    break;
                case "Triângulo":
                    objeto = CriarTriangulo();
                    break;
                case "Retângulo":
                    if (ValidarEntrada(txtLado, "largura") && ValidarEntrada(txtAltura, "altura"))
                    {
                        objeto = new Retangulo
                        {
                            Largura = Convert.ToDouble(txtLado.Text),
                            Altura = Convert.ToDouble(txtAltura.Text)
                        };
                    }
                    break;
                case "Circunferência":
                    if (ValidarEntrada(txtRaio, "raio"))
                    {
                        objeto = new Circunferencia { Raio = Convert.ToDouble(txtRaio.Text) };
                    }
                    break;
            }

            if (objeto != null)
            {
                cmbObjetos.Items.Add(objeto);
                LimparCampos();
            }
        }

        private FormaGeometrica CriarTriangulo()
        {
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    if (ValidarEntrada(txtLado, "lado"))
                    {
                        return new TrianguloEquilatero { Lado = Convert.ToDouble(txtLado.Text) };
                    }
                    break;
                case "Isósceles":
                    if (ValidarEntrada(txtBase, "base") && ValidarEntrada(txtLado, "lado"))
                    {
                        return new TrianguloIsosceles(
                            Convert.ToDouble(txtBase.Text),
                            Convert.ToDouble(txtLado.Text)
                        );
                    }
                    break;
                case "Reto":
                    if (ValidarEntrada(txtBase, "base") && ValidarEntrada(txtAltura, "altura"))
                    {
                        return new TrianguloReto
                        {
                            BaseTriangulo = Convert.ToDouble(txtBase.Text),
                            Altura = Convert.ToDouble(txtAltura.Text)
                        };
                    }
                    break;
            }
            return null;
        }

        private bool ValidarEntrada(TextBox textBox, string nomeCampo)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"Por favor, preencha o {nomeCampo}.");
                return false;
            }

            if (!double.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"Por favor, insira um valor numérico válido para o {nomeCampo}.");
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtLado.Clear();
            txtBase.Clear();
            txtAltura.Clear();
            txtRaio.Clear();
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbObjetos.SelectedItem is FormaGeometrica objeto)
            {
                txtArea.Text = objeto.CalcularArea().ToString();
                txtPerimetro.Text = objeto.CalcularPerimetro().ToString();
            }
        }

        private void lblTriangulo_Click(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}