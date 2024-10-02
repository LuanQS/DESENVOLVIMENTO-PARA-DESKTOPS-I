namespace GuessTheWord
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpa todos os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método exigido para o suporte do Designer - não pode ser
        /// manipulado com o código do editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Word = new System.Windows.Forms.Label();
            this.label_MissedLetters = new System.Windows.Forms.Label();
            this.label_MissedLtrCnt = new System.Windows.Forms.Label();
            this.label_Turn = new System.Windows.Forms.Label();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_E = new System.Windows.Forms.Button();
            this.button_F = new System.Windows.Forms.Button();
            this.button_G = new System.Windows.Forms.Button();
            this.button_H = new System.Windows.Forms.Button();
            this.button_I = new System.Windows.Forms.Button();
            this.button_J = new System.Windows.Forms.Button();
            this.button_K = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.button_M = new System.Windows.Forms.Button();
            this.button_N = new System.Windows.Forms.Button();
            this.button_O = new System.Windows.Forms.Button();
            this.button_P = new System.Windows.Forms.Button();
            this.button_Q = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.button_T = new System.Windows.Forms.Button();
            this.button_U = new System.Windows.Forms.Button();
            this.button_V = new System.Windows.Forms.Button();
            this.button_W = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.Button();
            this.button_Y = new System.Windows.Forms.Button();
            this.button_Z = new System.Windows.Forms.Button();
            this.button_LoadNewWord = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Word
            // 
            this.label_Word.AutoSize = true;
            this.label_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_Word.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Word.Location = new System.Drawing.Point(1, 5);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(125, 37);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "Palavra";
            this.label_Word.Click += new System.EventHandler(this.label_Word_Click);
            // 
            // label_MissedLetters
            // 
            this.label_MissedLetters.AutoSize = true;
            this.label_MissedLetters.BackColor = System.Drawing.Color.SteelBlue;
            this.label_MissedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_MissedLetters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_MissedLetters.Location = new System.Drawing.Point(324, 22);
            this.label_MissedLetters.Name = "label_MissedLetters";
            this.label_MissedLetters.Size = new System.Drawing.Size(148, 20);
            this.label_MissedLetters.TabIndex = 1;
            this.label_MissedLetters.Text = "Letras Erradas: N/A";
            this.label_MissedLetters.Click += new System.EventHandler(this.label_MissedLetters_Click);
            // 
            // label_MissedLtrCnt
            // 
            this.label_MissedLtrCnt.AutoSize = true;
            this.label_MissedLtrCnt.BackColor = System.Drawing.Color.SteelBlue;
            this.label_MissedLtrCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_MissedLtrCnt.Location = new System.Drawing.Point(369, 0);
            this.label_MissedLtrCnt.Name = "label_MissedLtrCnt";
            this.label_MissedLtrCnt.Size = new System.Drawing.Size(102, 20);
            this.label_MissedLtrCnt.TabIndex = 2;
            this.label_MissedLtrCnt.Text = "Chances: 5/5";
            this.label_MissedLtrCnt.Click += new System.EventHandler(this.label_MissedLtrCnt_Click);
            // 
            // label_Turn
            // 
            this.label_Turn.AutoSize = true;
            this.label_Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Turn.Location = new System.Drawing.Point(3, 0);
            this.label_Turn.Name = "label_Turn";
            this.label_Turn.Size = new System.Drawing.Size(67, 20);
            this.label_Turn.TabIndex = 3;
            this.label_Turn.Text = "Vez de: ";
            this.label_Turn.Click += new System.EventHandler(this.label_Turn_Click);
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(64, 39);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(39, 35);
            this.button_A.TabIndex = 4;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click);
            // 
            // button_B
            // 
            this.button_B.Location = new System.Drawing.Point(104, 39);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(39, 35);
            this.button_B.TabIndex = 5;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(144, 39);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(39, 35);
            this.button_C.TabIndex = 6;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_D
            // 
            this.button_D.Location = new System.Drawing.Point(184, 39);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(39, 35);
            this.button_D.TabIndex = 7;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // button_E
            // 
            this.button_E.Location = new System.Drawing.Point(224, 39);
            this.button_E.Name = "button_E";
            this.button_E.Size = new System.Drawing.Size(39, 35);
            this.button_E.TabIndex = 8;
            this.button_E.Text = "E";
            this.button_E.UseVisualStyleBackColor = true;
            this.button_E.Click += new System.EventHandler(this.button_E_Click);
            // 
            // button_F
            // 
            this.button_F.Location = new System.Drawing.Point(264, 39);
            this.button_F.Name = "button_F";
            this.button_F.Size = new System.Drawing.Size(39, 35);
            this.button_F.TabIndex = 9;
            this.button_F.Text = "F";
            this.button_F.UseVisualStyleBackColor = true;
            this.button_F.Click += new System.EventHandler(this.button_F_Click);
            // 
            // button_G
            // 
            this.button_G.Location = new System.Drawing.Point(304, 39);
            this.button_G.Name = "button_G";
            this.button_G.Size = new System.Drawing.Size(39, 35);
            this.button_G.TabIndex = 10;
            this.button_G.Text = "G";
            this.button_G.UseVisualStyleBackColor = true;
            this.button_G.Click += new System.EventHandler(this.button_G_Click);
            // 
            // button_H
            // 
            this.button_H.Location = new System.Drawing.Point(344, 39);
            this.button_H.Name = "button_H";
            this.button_H.Size = new System.Drawing.Size(39, 35);
            this.button_H.TabIndex = 11;
            this.button_H.Text = "H";
            this.button_H.UseVisualStyleBackColor = true;
            this.button_H.Click += new System.EventHandler(this.button_H_Click);
            // 
            // button_I
            // 
            this.button_I.Location = new System.Drawing.Point(384, 39);
            this.button_I.Name = "button_I";
            this.button_I.Size = new System.Drawing.Size(39, 35);
            this.button_I.TabIndex = 12;
            this.button_I.Text = "I";
            this.button_I.UseVisualStyleBackColor = true;
            this.button_I.Click += new System.EventHandler(this.button_I_Click);
            // 
            // button_J
            // 
            this.button_J.Location = new System.Drawing.Point(64, 79);
            this.button_J.Name = "button_J";
            this.button_J.Size = new System.Drawing.Size(39, 35);
            this.button_J.TabIndex = 13;
            this.button_J.Text = "J";
            this.button_J.UseVisualStyleBackColor = true;
            this.button_J.Click += new System.EventHandler(this.button_J_Click);
            // 
            // button_K
            // 
            this.button_K.Location = new System.Drawing.Point(104, 79);
            this.button_K.Name = "button_K";
            this.button_K.Size = new System.Drawing.Size(39, 35);
            this.button_K.TabIndex = 14;
            this.button_K.Text = "K";
            this.button_K.UseVisualStyleBackColor = true;
            this.button_K.Click += new System.EventHandler(this.button_K_Click);
            // 
            // button_L
            // 
            this.button_L.Location = new System.Drawing.Point(144, 79);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(39, 35);
            this.button_L.TabIndex = 15;
            this.button_L.Text = "L";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click);
            // 
            // button_M
            // 
            this.button_M.Location = new System.Drawing.Point(184, 79);
            this.button_M.Name = "button_M";
            this.button_M.Size = new System.Drawing.Size(39, 35);
            this.button_M.TabIndex = 16;
            this.button_M.Text = "M";
            this.button_M.UseVisualStyleBackColor = true;
            this.button_M.Click += new System.EventHandler(this.button_M_Click);
            // 
            // button_N
            // 
            this.button_N.Location = new System.Drawing.Point(224, 79);
            this.button_N.Name = "button_N";
            this.button_N.Size = new System.Drawing.Size(39, 35);
            this.button_N.TabIndex = 17;
            this.button_N.Text = "N";
            this.button_N.UseVisualStyleBackColor = true;
            this.button_N.Click += new System.EventHandler(this.button_N_Click);
            // 
            // button_O
            // 
            this.button_O.Location = new System.Drawing.Point(264, 79);
            this.button_O.Name = "button_O";
            this.button_O.Size = new System.Drawing.Size(39, 35);
            this.button_O.TabIndex = 18;
            this.button_O.Text = "O";
            this.button_O.UseVisualStyleBackColor = true;
            this.button_O.Click += new System.EventHandler(this.button_O_Click);
            // 
            // button_P
            // 
            this.button_P.Location = new System.Drawing.Point(304, 79);
            this.button_P.Name = "button_P";
            this.button_P.Size = new System.Drawing.Size(39, 35);
            this.button_P.TabIndex = 19;
            this.button_P.Text = "P";
            this.button_P.UseVisualStyleBackColor = true;
            this.button_P.Click += new System.EventHandler(this.button_P_Click);
            // 
            // button_Q
            // 
            this.button_Q.Location = new System.Drawing.Point(344, 79);
            this.button_Q.Name = "button_Q";
            this.button_Q.Size = new System.Drawing.Size(39, 35);
            this.button_Q.TabIndex = 20;
            this.button_Q.Text = "Q";
            this.button_Q.UseVisualStyleBackColor = true;
            this.button_Q.Click += new System.EventHandler(this.button_Q_Click);
            // 
            // button_R
            // 
            this.button_R.Location = new System.Drawing.Point(384, 79);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(39, 35);
            this.button_R.TabIndex = 21;
            this.button_R.Text = "R";
            this.button_R.UseVisualStyleBackColor = true;
            this.button_R.Click += new System.EventHandler(this.button_R_Click);
            // 
            // button_S
            // 
            this.button_S.Location = new System.Drawing.Point(64, 119);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(39, 35);
            this.button_S.TabIndex = 22;
            this.button_S.Text = "S";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // button_T
            // 
            this.button_T.Location = new System.Drawing.Point(104, 119);
            this.button_T.Name = "button_T";
            this.button_T.Size = new System.Drawing.Size(39, 35);
            this.button_T.TabIndex = 23;
            this.button_T.Text = "T";
            this.button_T.UseVisualStyleBackColor = true;
            this.button_T.Click += new System.EventHandler(this.button_T_Click);
            // 
            // button_U
            // 
            this.button_U.Location = new System.Drawing.Point(144, 119);
            this.button_U.Name = "button_U";
            this.button_U.Size = new System.Drawing.Size(39, 35);
            this.button_U.TabIndex = 24;
            this.button_U.Text = "U";
            this.button_U.UseVisualStyleBackColor = true;
            this.button_U.Click += new System.EventHandler(this.button_U_Click);
            // 
            // button_V
            // 
            this.button_V.Location = new System.Drawing.Point(184, 119);
            this.button_V.Name = "button_V";
            this.button_V.Size = new System.Drawing.Size(39, 35);
            this.button_V.TabIndex = 25;
            this.button_V.Text = "V";
            this.button_V.UseVisualStyleBackColor = true;
            this.button_V.Click += new System.EventHandler(this.button_V_Click);
            // 
            // button_W
            // 
            this.button_W.Location = new System.Drawing.Point(224, 119);
            this.button_W.Name = "button_W";
            this.button_W.Size = new System.Drawing.Size(39, 35);
            this.button_W.TabIndex = 26;
            this.button_W.Text = "W";
            this.button_W.UseVisualStyleBackColor = true;
            this.button_W.Click += new System.EventHandler(this.button_W_Click);
            // 
            // button_X
            // 
            this.button_X.Location = new System.Drawing.Point(264, 119);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(39, 35);
            this.button_X.TabIndex = 27;
            this.button_X.Text = "X";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            // 
            // button_Y
            // 
            this.button_Y.Location = new System.Drawing.Point(304, 119);
            this.button_Y.Name = "button_Y";
            this.button_Y.Size = new System.Drawing.Size(39, 35);
            this.button_Y.TabIndex = 28;
            this.button_Y.Text = "Y";
            this.button_Y.UseVisualStyleBackColor = true;
            this.button_Y.Click += new System.EventHandler(this.button_Y_Click);
            // 
            // button_Z
            // 
            this.button_Z.Location = new System.Drawing.Point(344, 119);
            this.button_Z.Name = "button_Z";
            this.button_Z.Size = new System.Drawing.Size(39, 35);
            this.button_Z.TabIndex = 29;
            this.button_Z.Text = "Z";
            this.button_Z.UseVisualStyleBackColor = true;
            this.button_Z.Click += new System.EventHandler(this.button_Z_Click);
            // 
            // button_LoadNewWord
            // 
            this.button_LoadNewWord.Location = new System.Drawing.Point(147, 183);
            this.button_LoadNewWord.Name = "button_LoadNewWord";
            this.button_LoadNewWord.Size = new System.Drawing.Size(120, 30);
            this.button_LoadNewWord.TabIndex = 30;
            this.button_LoadNewWord.Text = "Nova Palavra";
            this.button_LoadNewWord.UseVisualStyleBackColor = true;
            this.button_LoadNewWord.Click += new System.EventHandler(this.button_LoadNewWord_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(21, 183);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 30);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_A);
            this.panel1.Controls.Add(this.label_MissedLtrCnt);
            this.panel1.Controls.Add(this.label_Turn);
            this.panel1.Controls.Add(this.button_LoadNewWord);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.button_B);
            this.panel1.Controls.Add(this.button_C);
            this.panel1.Controls.Add(this.button_Z);
            this.panel1.Controls.Add(this.button_D);
            this.panel1.Controls.Add(this.button_Y);
            this.panel1.Controls.Add(this.button_E);
            this.panel1.Controls.Add(this.button_X);
            this.panel1.Controls.Add(this.button_F);
            this.panel1.Controls.Add(this.button_W);
            this.panel1.Controls.Add(this.button_G);
            this.panel1.Controls.Add(this.button_V);
            this.panel1.Controls.Add(this.button_H);
            this.panel1.Controls.Add(this.button_U);
            this.panel1.Controls.Add(this.button_I);
            this.panel1.Controls.Add(this.button_T);
            this.panel1.Controls.Add(this.button_J);
            this.panel1.Controls.Add(this.button_S);
            this.panel1.Controls.Add(this.button_K);
            this.panel1.Controls.Add(this.button_R);
            this.panel1.Controls.Add(this.button_L);
            this.panel1.Controls.Add(this.button_Q);
            this.panel1.Controls.Add(this.button_M);
            this.panel1.Controls.Add(this.button_P);
            this.panel1.Controls.Add(this.button_N);
            this.panel1.Controls.Add(this.button_O);
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 301);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Luan Qualhareli Segura RA: 04723-303";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "João Miguel Basile Machado RA: 04723-014";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(484, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_MissedLetters);
            this.Controls.Add(this.label_Word);
            this.Name = "Form1";
            this.Text = "Adivinhe a Palavra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.Label label_MissedLetters;
        private System.Windows.Forms.Label label_MissedLtrCnt;
        private System.Windows.Forms.Label label_Turn;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_E;
        private System.Windows.Forms.Button button_F;
        private System.Windows.Forms.Button button_G;
        private System.Windows.Forms.Button button_H;
        private System.Windows.Forms.Button button_I;
        private System.Windows.Forms.Button button_J;
        private System.Windows.Forms.Button button_K;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Button button_M;
        private System.Windows.Forms.Button button_N;
        private System.Windows.Forms.Button button_O;
        private System.Windows.Forms.Button button_P;
        private System.Windows.Forms.Button button_Q;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Button button_T;
        private System.Windows.Forms.Button button_U;
        private System.Windows.Forms.Button button_V;
        private System.Windows.Forms.Button button_W;
        private System.Windows.Forms.Button button_X;
        private System.Windows.Forms.Button button_Y;
        private System.Windows.Forms.Button button_Z;
        private System.Windows.Forms.Button button_LoadNewWord;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
