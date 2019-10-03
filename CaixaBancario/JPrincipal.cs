using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CaixaBancario
{
    public partial class JPrincipal : Form
    {
        readonly Random vRandom = new Random();

        string[] aTitular = new string[100];
        string[] aSaldo = new string[100];
        string[] aNumero = new string[100];
        string[] aSaque = new string[100];
        string aData;
        string registro;
        bool controle = true;
        bool critica_matriz;
        string diretorio = Directory.GetCurrentDirectory();

        public JPrincipal()
        {
            InitializeComponent();
        }

        public void Carregar()
        {
            //Titular
            Stream stream1 = File.Open(diretorio + "\\Conta\\titular.txt", FileMode.OpenOrCreate);
            StreamReader vLeitor1 = new StreamReader(stream1);

            registro = vLeitor1.ReadToEnd();

            aTitular = registro.Split('\n');

            vLeitor1.Close();
            stream1.Close();

            //Saldo
            Stream stream2 = File.Open(diretorio + "\\Conta\\saldo.txt", FileMode.OpenOrCreate);
            StreamReader vLeitor2 = new StreamReader(stream2);

            registro = vLeitor2.ReadToEnd();

            aSaldo = registro.Split('\n');

            vLeitor2.Close();
            stream2.Close();

            //Número
            Stream stream3 = File.Open(diretorio + "\\Conta\\numero.txt", FileMode.OpenOrCreate);
            StreamReader vLeitor3 = new StreamReader(stream3);

            registro = vLeitor3.ReadToEnd();

            aNumero = registro.Split('\n');

            vLeitor3.Close();
            stream3.Close();

            //Saques
            Stream stream4 = File.Open(diretorio + "\\Conta\\saque.txt", FileMode.OpenOrCreate);
            StreamReader vLeitor4 = new StreamReader(stream4);

            registro = vLeitor4.ReadToEnd();

            aSaque = registro.Split('\n');

            vLeitor4.Close();
            stream4.Close();

            //Data
            Stream stream5 = File.Open(diretorio + "\\Conta\\data.txt", FileMode.OpenOrCreate);
            StreamReader vLeitor5 = new StreamReader(stream5);

            aData = vLeitor5.ReadLine();

            if(aData != null)
            {
                aData = aData.Substring(0, 10);
            }
            else
            {
                aData = "";
            }
            vLeitor5.Close();
            stream5.Close();
        }

        public void Grava(string url, string[] matriz)
        {
            // Deleta, cria e depois grava informações da matriz no arquivo.
            File.Delete(url);
            Stream stream = File.Open(url, FileMode.OpenOrCreate);
            StreamWriter vEscritor = new StreamWriter(stream);

            for (int a = 0; a < matriz.Length; a++)
            {
                if (matriz[a] != null && matriz[a] != "")
                {
                    vEscritor.WriteLine(matriz[a]);
                }
            }

            vEscritor.Close();
            stream.Close();
        }

        public void CarregaComboBox()
        {
            cbTitulares1.Items.Clear();
            cbTitulares2.Items.Clear();
            for (int i = 0; i < aTitular.Length; i++)
            {
                if (aTitular[i] != null && aTitular[i] != "")
                {
                    cbTitulares1.Items.Add(aTitular[i]);
                    cbTitulares2.Items.Add(aTitular[i]);
                }
            }
        }

        public void MensagemConta (string mensagem)
        {
            txtTitular1.BackColor = Color.Red;
            mtbSaldo1.BackColor = Color.Red;
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTitular1.BackColor = Color.White;
            mtbSaldo1.BackColor = Color.White;
        }

        public void MensagemCaixa (string mensagem)
        {
            mtbValor.BackColor = Color.Red;
            MessageBox.Show(mensagem, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            mtbValor.BackColor = Color.White;
            mtbValor.ResetText();
        }

        public void MaiMinConta()
        {
            string[] nome = new string[100];

            nome = txtTitular1.Text.Split(' ');

            for(int i = 0; i < nome.Length; i++)
            {
                if(nome[i] == "")
                {
                    nome[i] = null;
                }
            }

            int b = 0;
            for(int a = 0; a < nome.Length; a++)
            {
                if (nome[a] != null)
                {
                    if(nome[b] == null)
                    {
                        nome[b] = nome[a];
                        nome[a] = null;
                        b++;
                    }
                    else
                    {
                        b++;
                    }
                }
            }

            if(nome.Length > 2)
            {
                if (MessageBox.Show("Somente nome e sobrenome podem ser adicionados: " + nome[0] + " " + nome[1] + "\nDeseja prosseguir?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtTitular1.Text = nome[0];
                    txtTitular1.Text += " ";
                    txtTitular1.Text += nome[1];

                    int n = txtTitular1.Text.IndexOf(" ");

                    //Deixa em maiscula a primeira letra de cada nome.
                    string nome1 = txtTitular1.Text.Substring(0, 1);
                    nome1 = nome1.ToUpper();
                    string sobrenome1 = txtTitular1.Text.Substring(n + 1, 1);
                    sobrenome1 = sobrenome1.ToUpper();

                    //Deixa em minuscula o nome, exceto as primeiras letras.
                    string nome2 = txtTitular1.Text.Substring(1, n);
                    nome2 = nome2.ToLower();
                    string sobrenome2 = txtTitular1.Text.Substring(n + 2, txtTitular1.TextLength - (n + 2));
                    sobrenome2 = sobrenome2.ToLower();

                    txtTitular1.Text = nome1 + nome2 + sobrenome1 + sobrenome2;
                }
                else
                {
                    txtTitular1.Text = "";
                }
            }
            else
            {
                txtTitular1.Text = nome[0];
                txtTitular1.Text += " ";
                txtTitular1.Text += nome[1];

                int n = txtTitular1.Text.IndexOf(" ");

                //Deixa em maiscula a primeira letra de cada nome.
                string nome1 = txtTitular1.Text.Substring(0, 1);
                nome1 = nome1.ToUpper();
                string sobrenome1 = txtTitular1.Text.Substring(n + 1, 1);
                sobrenome1 = sobrenome1.ToUpper();

                //Deixa em minuscula o nome, exceto as primeiras letras.
                string nome2 = txtTitular1.Text.Substring(1, n);
                nome2 = nome2.ToLower();
                string sobrenome2 = txtTitular1.Text.Substring(n + 2, txtTitular1.TextLength - (n + 2));
                sobrenome2 = sobrenome2.ToLower();

                txtTitular1.Text = nome1 + nome2 + sobrenome1 + sobrenome2;
            }
        }

        private void JPrincipal_Load(object sender, EventArgs e)
        {
            // Remove da string do caminho do projeto a pasta bin.
            diretorio = diretorio.Remove(diretorio.IndexOf("\\bin"));

            // TODO: esta linha de código carrega dados na tabela 'contaDataSetDesi.Conta'. Você pode movê-la ou removê-la conforme necessário.
            Carregar();

            if (aData != null && (aData.Contains(DateTime.Today.Date.ToShortDateString()) == false || aData == ""))
            {
                aData = DateTime.Today.Date.ToShortDateString();

                File.Delete(diretorio + "\\Conta\\data.txt");
                Stream stream = File.Open(diretorio + "\\Conta\\data.txt", FileMode.OpenOrCreate);
                StreamWriter vEscritor = new StreamWriter(stream);

                vEscritor.WriteLine(aData);

                vEscritor.Close();
                stream.Close();

                for (int i = 0; i < aSaque.Length; i++)
                {
                    aSaque[i] = Convert.ToString(0);
                }
            }

            CarregaComboBox();

            //ComboBox 1
            cbTitulares1.Text = aTitular[0];
            txtTitular2.Text = aTitular[0];
            txtSaldo2.Text = aSaldo[0];
            //ComboBox 2
            cbTitulares2.Text = aTitular[0];
            txtTitular3.Text = aTitular[0];
            txtSaldo3.Text = aSaldo[0];
            txtNumero1.Text = aNumero[0];
            txtSaque1.Text = aSaque[0];
        }

        private void CbTitulares1_TextChanged(object sender, EventArgs e)
        {
            if (cbTitulares1.SelectedIndex <= 0)
            {
                cbTitulares1.SelectedIndex = 0;
            }

            if (cbTitulares1.Text != "")
            {
                mtbValor.Enabled = true;
                btnSacar.Enabled = true;
                btnDepositar.Enabled = true;
            }
            else
            {
                mtbValor.Enabled = false;
                mtbValor.Enabled = false;
                btnSacar.Enabled = false;
                btnDepositar.Enabled = false;
            }

            cbTitulares1.Text = cbTitulares1.Text;
        }

        private void CbTitulares1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTitulares1.SelectedIndex <= 0)
            {
                cbTitulares1.SelectedIndex = 0;
            }
            //ComboBox 1
            cbTitulares1.Text = aTitular[cbTitulares1.SelectedIndex];
            txtTitular2.Text = aTitular[cbTitulares1.SelectedIndex];
            txtSaldo2.Text = aSaldo[cbTitulares1.SelectedIndex];
            //ComboBox 2
            cbTitulares2.Text = aTitular[cbTitulares1.SelectedIndex];
            txtTitular3.Text = aTitular[cbTitulares1.SelectedIndex];
            txtSaldo3.Text = aSaldo[cbTitulares1.SelectedIndex];
            txtNumero1.Text = aNumero[cbTitulares1.SelectedIndex];
            txtSaque1.Text = aSaque[cbTitulares1.SelectedIndex];
        }

        private void CbTitulares2_TextChanged(object sender, EventArgs e)
        {
            if (cbTitulares2.Text != "")
            {
                btnDeletar.Enabled = true;
            }
            else
            {
                //ComboBox 2
                txtTitular3.Text = "";
                txtSaldo3.Text = "";
                txtNumero1.Text = "";
                txtSaque1.Text = "";
                //ComboBox 1
                cbTitulares1.Text = "";
                txtTitular2.Text = "";
                txtSaldo2.Text = "";

                btnDeletar.Enabled = false;
            }

            if (cbTitulares2.SelectedIndex <= 0)
            {
                cbTitulares2.SelectedIndex = 0;
            }

            cbTitulares2.Text = cbTitulares2.Text;
        }

        private void CbTitulares2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox 2
            cbTitulares2.Text = aTitular[cbTitulares2.SelectedIndex];
            txtTitular3.Text = aTitular[cbTitulares2.SelectedIndex];
            txtSaldo3.Text = aSaldo[cbTitulares2.SelectedIndex];
            txtNumero1.Text = aNumero[cbTitulares2.SelectedIndex];
            txtSaque1.Text = aSaque[cbTitulares2.SelectedIndex];
            //ComboBox 1
            cbTitulares1.Text = aTitular[cbTitulares2.SelectedIndex];
            txtTitular2.Text = aTitular[cbTitulares2.SelectedIndex];
            txtSaldo2.Text = aSaldo[cbTitulares2.SelectedIndex];
        }

        private void TxtTitular1_TextChanged(object sender, EventArgs e)
        {
            if (txtTitular1.TextLength > 0 || mtbValor.TextLength > 0)
            {
                lblAdicionado.Visible = false;
            }

            if (txtTitular1.TextLength > 0)
            {
                btnAdicionar.Enabled = true;
            }
            else
            {
                btnAdicionar.Enabled = false;
            }
        }

        private void MtbValor_TextChanged(object sender, EventArgs e)
        {
            mtbValor.Text = mtbValor.Text.Replace(" ", "");

            if (txtTitular2.Text != "")
            {
                mtbValor.Enabled = true;
                
            }
            else
            {
                mtbValor.Text = "";
                mtbValor.Enabled = false;
            }
        }

        private void MtbSaldo1_TextChanged(object sender, EventArgs e)
        {
            mtbSaldo1.Text = mtbSaldo1.Text.Replace(" ", "");
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            string campo = "";
            long campo2 = 0;

            campo = txtTitular1.Text = txtTitular1.Text.Trim();

            if (mtbSaldo1.Text != "")
            {
                mtbSaldo1.Text = mtbSaldo1.Text.Replace(" ", "");

                campo2 = Convert.ToInt64(mtbSaldo1.Text);
            }
            else
            {
                MensagemConta("Saldo não preenchido");

                return;
            }

            if (Convert.ToInt64(mtbSaldo1.Text) <= 0)
            {
                MensagemConta("Saldo zerado");

                return;
            }

            //Se o campo Titular contém numeros
            bool cTitular = campo.Contains('1') || campo.Contains('2') || campo.Contains('3') || campo.Contains('4') || campo.Contains('5')
                || campo.Contains('6') || campo.Contains('7') || campo.Contains('8') || campo.Contains('9') || campo.Contains('0');

            //Deixa maiuscula a primeira letra do nome e sobrenome, e o resto minuscula.
            if (txtTitular1.Text.Contains(" "))
            {
                MaiMinConta();
            }

            // Se o titular já contém na matriz
            for (int i = 0; i < aTitular.Length; i++)
            {
                campo = txtTitular1.Text;
                critica_matriz = aTitular[i].Contains(campo);

                if (critica_matriz)
                {
                    break;
                }
            }

            if (txtTitular1.TextLength > 6 && txtTitular1.Text.Contains(" ")
                && cTitular == false && critica_matriz == false)
            {
                for (int a = 0; a < aTitular.Length; a++)
                {
                    if (aTitular[a] == null || aTitular[a] == "")
                    {
                        aTitular[a] = txtTitular1.Text;
                        aSaldo[a] = Convert.ToString(campo2);
                        aNumero[a] = Convert.ToString(vRandom.Next(1000, 9000));
                        aSaque[a] = Convert.ToString(0);
                    }
                }

                Grava(diretorio + "\\Conta\\titular.txt", aTitular);
                Grava(diretorio + "\\Conta\\saldo.txt", aSaldo);
                Grava(diretorio + "\\Conta\\numero.txt", aNumero);
                Grava(diretorio + "\\Conta\\saque.txt", aSaque);

                Carregar();

                CarregaComboBox();

                txtTitular1.Text = "";
                mtbSaldo1.Text = "";

                if (controle == true)
                {
                    lblAdicionado.Visible = true;
                    lblAdicionado.BackColor = Color.Lime;
                    controle = false;
                }
                else
                {
                    lblAdicionado.Visible = true;
                    lblAdicionado.BackColor = Color.RoyalBlue;
                    controle = true;
                }

                cbTitulares1.SelectedIndex = 0;
                cbTitulares1.SelectedIndex = 0;

                return;
            }
            else
            {
                txtTitular1.BackColor = Color.Red;
                mtbSaldo1.BackColor = Color.Red;
                MessageBox.Show("Erro no campo Titular ou Saldo, verifique:\n\n- Titular (nome e sobrenome) incompleto.\n" +
                                 "- Você digitou números no campo titular?\n- Titular já possui conta? ", "Aviso", MessageBoxButtons.OK,
                                                                                        MessageBoxIcon.Error);
                txtTitular1.BackColor = Color.White;
                mtbSaldo1.BackColor = Color.White;
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (cbTitulares2.SelectedIndex >= 0)
            {
                aTitular[cbTitulares2.SelectedIndex] = null;
                aSaldo[cbTitulares2.SelectedIndex] = null;
                aNumero[cbTitulares2.SelectedIndex] = null;
                aSaque[cbTitulares2.SelectedIndex] = null;
                cbTitulares2.ResetText();

                Grava(diretorio + "\\Conta\\titular.txt", aTitular);
                Grava(diretorio + "\\Conta\\saldo.txt", aSaldo);
                Grava(diretorio + "\\Conta\\numero.txt", aNumero);
                Grava(diretorio + "\\Conta\\saque.txt", aSaque);

                Carregar();

                CarregaComboBox();

                if (cbTitulares2.Items.Count > 0)
                {
                    cbTitulares2.SelectedIndex = 0;
                }
            }
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {
            long valor = 0, saldo2 = 0;

            // Verifica se a data na variavel aData é igual a data de hoje, se não for, atualiza ela e zera os saques.
            if (aData.Contains(DateTime.Today.Date.ToShortDateString()) == false)
            {
                aData = DateTime.Today.Date.ToShortDateString();

                File.Delete(diretorio + "\\Conta\\data.txt");
                Stream stream = File.Open(diretorio + "\\Conta\\data.txt", FileMode.OpenOrCreate);
                StreamWriter vEscritor = new StreamWriter(stream);

                vEscritor.WriteLine(aData);

                vEscritor.Close();
                stream.Close();

                for (int i = 0; i < aSaque.Length; i++)
                {
                    aSaque[i] = Convert.ToString(0);
                }
            }

            // Verifica se o número de saques da conta escolhida chegou a três, se sim, então não segue adiante.
            if (aSaque[cbTitulares1.SelectedIndex].Contains("3"))
            {
                MessageBox.Show("Limite de saque alcançado, volte amanhã.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbValor.Text = "";
                return;
            }

            if (mtbValor.Text != "")
            {
                mtbValor.Text = mtbValor.Text.Replace(" ", "");

                valor = Convert.ToInt64(mtbValor.Text);
                saldo2 = Convert.ToInt64(txtSaldo2.Text);
            }
            else
            {
                MessageBox.Show("Digite um valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (valor > 3000)
            {
                MessageBox.Show("Valor não pode ser maior que 3000.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                mtbValor.ResetText();

                return;
            }

            if (valor <= saldo2 && valor > 0)
            {
                aSaldo[cbTitulares1.SelectedIndex] =
                    Convert.ToString(Convert.ToInt64(aSaldo[cbTitulares1.SelectedIndex]) - valor);

                aSaque[cbTitulares1.SelectedIndex] = Convert.ToString(Convert.ToInt16(aSaque[cbTitulares1.SelectedIndex]) + 1);

                Grava(diretorio + "\\Conta\\saldo.txt", aSaldo);
                Grava(diretorio + "\\Conta\\saque.txt", aSaque);

                Carregar();

                mtbValor.ResetText();

                txtSaque1.Text = aSaque[cbTitulares1.SelectedIndex];
                txtSaldo2.Text = aSaldo[cbTitulares1.SelectedIndex];
                txtSaldo3.Text = aSaldo[cbTitulares1.SelectedIndex];
            }
            else
            {
                MensagemCaixa("Valor não pode ser zero ou maior que saldo.");
            }
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            long valor = 0;

            if (mtbValor.Text == "")
            {
                MessageBox.Show("Digite um valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                mtbValor.Text = mtbValor.Text.Replace(" ", "");

                valor = Convert.ToInt64(mtbValor.Text);
            }

            if (valor > 0)
            {
                aSaldo[cbTitulares1.SelectedIndex] =
                    Convert.ToString(Convert.ToInt64(aSaldo[cbTitulares1.SelectedIndex]) + valor);

                Grava(diretorio + "\\Conta\\saldo.txt", aSaldo);

                Carregar();

                txtSaldo2.Text = aSaldo[cbTitulares1.SelectedIndex];
                txtSaldo3.Text = aSaldo[cbTitulares1.SelectedIndex];

                mtbValor.ResetText();
            }
            else
            {
                MensagemCaixa("Valor zero ou negativo.");
            }
        }
    }
}