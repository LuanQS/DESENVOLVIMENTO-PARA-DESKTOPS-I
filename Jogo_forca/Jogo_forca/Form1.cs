using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuessTheWord
{
    public delegate void CheckLetter(string letter);

    public partial class Form1 : Form
    {
        const int NUMERO_MAXIMO_CHANCES = 5;
        event CheckLetter ChkLtr;

        string input;
        string letras_Informadas = "";
        string palavraAEcontrar = "";
        string palavraAExibir = "";
        char[] arrayPalavraAEncontrar;
        int[] palavraAEncontrarPosicaoLetras;
        bool isLetraEncontrada = false;
        Random rndm = new Random(0);
        List<string> listaPalavras = new List<string>();
        List<int> palavrasIndiceJaUsada = new List<int>();
        int contadorLetraUsada = 0;

        // Armazenar nomes dos jogadores
        string jogador1;
        string jogador2;
        bool jogadorAtual = true; // true = jogador1, false = jogador2
        int chancesJogador1 = 0;  // Contador de chances do Jogador 1
        int chancesJogador2 = 0;  // Contador de chances do Jogador 2

        public Form1()
        {
            InitializeComponent();
            this.ChkLtr += new CheckLetter(Form1_ChkLtr);
            CriaListaPalavras();

            // Chama o método para solicitar os nomes dos jogadores
            SolicitarNomes();
            IniciarJogo();
        }

        private void SolicitarNomes()
        {
            jogador1 = PromptForName("Digite o nome do Jogador 1:");
            jogador2 = PromptForName("Digite o nome do Jogador 2:");
            UpdateTurnLabel();
        }

        private string PromptForName(string message)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(message, "Nome do Jogador", "");
        }

        // Atualiza a interface para mostrar de quem é a vez
        private void UpdateTurnLabel()
        {
            label_Turn.Text = $"Vez de: {(jogadorAtual ? jogador1 : jogador2)}";
        }

        private void CriaListaPalavras()
        {
            listaPalavras.Add("Localizacao");
            listaPalavras.Add("Amadora");
            listaPalavras.Add("Educando");
            listaPalavras.Add("Veterano");
            listaPalavras.Add("Nacional");
            listaPalavras.Add("Computador");
            listaPalavras.Add("Calculadora");
            listaPalavras.Add("Transmissão");
            listaPalavras.Add("Continental");
            listaPalavras.Add("Razoavel");
            listaPalavras.Add("Operacao");
            listaPalavras.Add("Suspeito");
            listaPalavras.Add("Amanha");
            listaPalavras.Add("Ontem");
            listaPalavras.Add("Perfume");
        }

        private string GetNovaPalavraDoPool()
        {
            bool IsNovaPalavra = false;
            string temp = "HANGMAN";

            try
            {
                while (IsNovaPalavra == false)
                {
                    int index = rndm.Next() % listaPalavras.Count;

                    if (!palavrasIndiceJaUsada.Exists(e => e == index))
                    {
                        temp = listaPalavras[index];
                        palavrasIndiceJaUsada.Add(index);
                        IsNovaPalavra = true;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return temp.ToUpper();
        }

        private void IniciarJogo()
        {
            palavraAEcontrar = GetNovaPalavraDoPool();
            palavraAEcontrar = palavraAEcontrar.ToUpper();
            arrayPalavraAEncontrar = palavraAEcontrar.ToCharArray();
            palavraAEncontrarPosicaoLetras = new int[palavraAEcontrar.Length];

            input = "";
            palavraAExibir = new string('-', palavraAEcontrar.Length);
            letras_Informadas = "";
            contadorLetraUsada = 0;
            chancesJogador1 = 0;
            chancesJogador2 = 0;

            label_Word.Text = palavraAExibir.ToUpper();
            label_MissedLetters.Text = letras_Informadas;

            // Exibir "Chances:" ao inicializar o jogo
            label_MissedLtrCnt.Text = $"Chances: {NUMERO_MAXIMO_CHANCES}";

            Application.DoEvents();
        }


        private void Form1_ChkLtr(string currentInputletter)
        {
            try
            {
                if ((jogadorAtual && chancesJogador1 < NUMERO_MAXIMO_CHANCES) ||
                    (!jogadorAtual && chancesJogador2 < NUMERO_MAXIMO_CHANCES))
                {
                    isLetraEncontrada = false;
                    for (int i = 0; i < arrayPalavraAEncontrar.Length; i++)
                    {
                        if (currentInputletter[0] == arrayPalavraAEncontrar[i])
                        {
                            palavraAEncontrarPosicaoLetras[i] = 1;
                            isLetraEncontrada = true;
                        }
                    }

                    if (!isLetraEncontrada)
                    {
                        letras_Informadas += currentInputletter + ", ";
                        if (jogadorAtual)
                        {
                            chancesJogador1++;
                            label_MissedLtrCnt.Text = $"Chances: {NUMERO_MAXIMO_CHANCES - chancesJogador1}";
                        }
                        else
                        {
                            chancesJogador2++;
                            label_MissedLtrCnt.Text = $"Chances: {NUMERO_MAXIMO_CHANCES - chancesJogador2}";
                        }
                    }

                    palavraAExibir = new string(arrayPalavraAEncontrar.Select((c, i) => palavraAEncontrarPosicaoLetras[i] == 1 ? c : '-').ToArray());
                    label_Word.Text = palavraAExibir.ToUpper();
                    label_MissedLetters.Text = letras_Informadas;

                    if (palavraAEncontrarPosicaoLetras.All(e => e == 1))
                    {
                        string vencedor = jogadorAtual ? jogador1 : jogador2;
                        MessageBox.Show($"PARABÉNS {vencedor}! VOCÊ ACERTOU A PALAVRA.", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IniciarJogo();
                    }
                }
                else
                {
                    string vencedor = (chancesJogador1 < NUMERO_MAXIMO_CHANCES) ? jogador1 : jogador2;
                    MessageBox.Show($"Infelizmente, nenhum jogador acertou a palavra.\nA palavra correta é: {palavraAEcontrar}", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IniciarJogo();
                }

                // Alterna o jogador somente se o atual errar
                if (!isLetraEncontrada)
                {
                    jogadorAtual = !jogadorAtual;
                    UpdateTurnLabel();
                }

                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        #region Getting Alphabets

        private void button_A_Click(object sender, EventArgs e) { input = "A"; ChkLtr(input); }
        private void button_B_Click(object sender, EventArgs e) { input = "B"; ChkLtr(input); }
        private void button_C_Click(object sender, EventArgs e) { input = "C"; ChkLtr(input); }
        private void button_D_Click(object sender, EventArgs e) { input = "D"; ChkLtr(input); }
        private void button_E_Click(object sender, EventArgs e) { input = "E"; ChkLtr(input); }
        private void button_F_Click(object sender, EventArgs e) { input = "F"; ChkLtr(input); }
        private void button_G_Click(object sender, EventArgs e) { input = "G"; ChkLtr(input); }
        private void button_H_Click(object sender, EventArgs e) { input = "H"; ChkLtr(input); }
        private void button_I_Click(object sender, EventArgs e) { input = "I"; ChkLtr(input); }
        private void button_J_Click(object sender, EventArgs e) { input = "J"; ChkLtr(input); }
        private void button_K_Click(object sender, EventArgs e) { input = "K"; ChkLtr(input); }
        private void button_L_Click(object sender, EventArgs e) { input = "L"; ChkLtr(input); }
        private void button_M_Click(object sender, EventArgs e) { input = "M"; ChkLtr(input); }
        private void button_N_Click(object sender, EventArgs e) { input = "N"; ChkLtr(input); }
        private void button_O_Click(object sender, EventArgs e) { input = "O"; ChkLtr(input); }
        private void button_P_Click(object sender, EventArgs e) { input = "P"; ChkLtr(input); }
        private void button_Q_Click(object sender, EventArgs e) { input = "Q"; ChkLtr(input); }
        private void button_R_Click(object sender, EventArgs e) { input = "R"; ChkLtr(input); }
        private void button_S_Click(object sender, EventArgs e) { input = "S"; ChkLtr(input); }
        private void button_T_Click(object sender, EventArgs e) { input = "T"; ChkLtr(input); }
        private void button_U_Click(object sender, EventArgs e) { input = "U"; ChkLtr(input); }
        private void button_V_Click(object sender, EventArgs e) { input = "V"; ChkLtr(input); }
        private void button_W_Click(object sender, EventArgs e) { input = "W"; ChkLtr(input); }
        private void button_X_Click(object sender, EventArgs e) { input = "X"; ChkLtr(input); }
        private void button_Y_Click(object sender, EventArgs e) { input = "Y"; ChkLtr(input); }
        private void button_Z_Click(object sender, EventArgs e) { input = "Z"; ChkLtr(input); }

        #endregion

        private void button_LoadNewWord_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_MissedLtrCnt_Click(object sender, EventArgs e)
        {

        }

        private void label_Turn_Click(object sender, EventArgs e)
        {

        }

        private void label_MissedLetters_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Word_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
