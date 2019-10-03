namespace CaixaBancario
{
    partial class JPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTitulares1 = new System.Windows.Forms.ComboBox();
            this.txtTitular1 = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitular2 = new System.Windows.Forms.TextBox();
            this.txtSaldo2 = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpConta = new System.Windows.Forms.TabPage();
            this.mtbSaldo1 = new System.Windows.Forms.MaskedTextBox();
            this.lblAdicionado = new System.Windows.Forms.Label();
            this.tpCaixa = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pTitularSaldo = new System.Windows.Forms.Panel();
            this.pSacaDeposita = new System.Windows.Forms.Panel();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.tpDetalhes = new System.Windows.Forms.TabPage();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.cbTitulares2 = new System.Windows.Forms.ComboBox();
            this.txtSaldo3 = new System.Windows.Forms.TextBox();
            this.txtTitular3 = new System.Windows.Forms.TextBox();
            this.pTitularSaldoNum = new System.Windows.Forms.Panel();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSaque1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcPrincipal.SuspendLayout();
            this.tpConta.SuspendLayout();
            this.tpCaixa.SuspendLayout();
            this.pSacaDeposita.SuspendLayout();
            this.tpDetalhes.SuspendLayout();
            this.pTitularSaldoNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTitulares1
            // 
            this.cbTitulares1.Cursor = System.Windows.Forms.Cursors.No;
            this.cbTitulares1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbTitulares1.ItemHeight = 13;
            this.cbTitulares1.Location = new System.Drawing.Point(8, 6);
            this.cbTitulares1.Name = "cbTitulares1";
            this.cbTitulares1.Size = new System.Drawing.Size(197, 21);
            this.cbTitulares1.TabIndex = 1;
            this.cbTitulares1.SelectedIndexChanged += new System.EventHandler(this.CbTitulares1_SelectedIndexChanged);
            this.cbTitulares1.TextChanged += new System.EventHandler(this.CbTitulares1_TextChanged);
            // 
            // txtTitular1
            // 
            this.txtTitular1.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitular1.Location = new System.Drawing.Point(72, 19);
            this.txtTitular1.MaxLength = 30;
            this.txtTitular1.Name = "txtTitular1";
            this.txtTitular1.Size = new System.Drawing.Size(100, 20);
            this.txtTitular1.TabIndex = 1;
            this.txtTitular1.TextChanged += new System.EventHandler(this.TxtTitular1_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(97, 71);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo";
            // 
            // txtTitular2
            // 
            this.txtTitular2.Enabled = false;
            this.txtTitular2.Location = new System.Drawing.Point(78, 39);
            this.txtTitular2.Name = "txtTitular2";
            this.txtTitular2.Size = new System.Drawing.Size(100, 20);
            this.txtTitular2.TabIndex = 6;
            // 
            // txtSaldo2
            // 
            this.txtSaldo2.Enabled = false;
            this.txtSaldo2.Location = new System.Drawing.Point(78, 65);
            this.txtSaldo2.Name = "txtSaldo2";
            this.txtSaldo2.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo2.TabIndex = 7;
            // 
            // btnSacar
            // 
            this.btnSacar.Enabled = false;
            this.btnSacar.Location = new System.Drawing.Point(42, 53);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(47, 23);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.BtnSacar_Click);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpConta);
            this.tcPrincipal.Controls.Add(this.tpCaixa);
            this.tcPrincipal.Controls.Add(this.tpDetalhes);
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(223, 226);
            this.tcPrincipal.TabIndex = 9;
            // 
            // tpConta
            // 
            this.tpConta.Controls.Add(this.mtbSaldo1);
            this.tpConta.Controls.Add(this.lblAdicionado);
            this.tpConta.Controls.Add(this.label1);
            this.tpConta.Controls.Add(this.txtTitular1);
            this.tpConta.Controls.Add(this.btnAdicionar);
            this.tpConta.Controls.Add(this.label2);
            this.tpConta.Location = new System.Drawing.Point(4, 22);
            this.tpConta.Name = "tpConta";
            this.tpConta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConta.Size = new System.Drawing.Size(215, 200);
            this.tpConta.TabIndex = 0;
            this.tpConta.Text = "Conta";
            this.tpConta.UseVisualStyleBackColor = true;
            // 
            // mtbSaldo1
            // 
            this.mtbSaldo1.Location = new System.Drawing.Point(72, 45);
            this.mtbSaldo1.Mask = "0000000000000000";
            this.mtbSaldo1.Name = "mtbSaldo1";
            this.mtbSaldo1.Size = new System.Drawing.Size(100, 20);
            this.mtbSaldo1.TabIndex = 2;
            this.mtbSaldo1.TextChanged += new System.EventHandler(this.MtbSaldo1_TextChanged);
            // 
            // lblAdicionado
            // 
            this.lblAdicionado.AutoSize = true;
            this.lblAdicionado.BackColor = System.Drawing.Color.Lime;
            this.lblAdicionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionado.Location = new System.Drawing.Point(22, 123);
            this.lblAdicionado.Name = "lblAdicionado";
            this.lblAdicionado.Size = new System.Drawing.Size(170, 50);
            this.lblAdicionado.TabIndex = 6;
            this.lblAdicionado.Text = "Conta adicionada \r\n   com sucesso!";
            this.lblAdicionado.Visible = false;
            // 
            // tpCaixa
            // 
            this.tpCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpCaixa.Controls.Add(this.label6);
            this.tpCaixa.Controls.Add(this.label7);
            this.tpCaixa.Controls.Add(this.cbTitulares1);
            this.tpCaixa.Controls.Add(this.txtTitular2);
            this.tpCaixa.Controls.Add(this.txtSaldo2);
            this.tpCaixa.Controls.Add(this.pTitularSaldo);
            this.tpCaixa.Controls.Add(this.pSacaDeposita);
            this.tpCaixa.Location = new System.Drawing.Point(4, 22);
            this.tpCaixa.Name = "tpCaixa";
            this.tpCaixa.Padding = new System.Windows.Forms.Padding(3);
            this.tpCaixa.Size = new System.Drawing.Size(215, 200);
            this.tpCaixa.TabIndex = 1;
            this.tpCaixa.Text = "Caixa";
            this.tpCaixa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Titular";
            // 
            // pTitularSaldo
            // 
            this.pTitularSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTitularSaldo.Location = new System.Drawing.Point(8, 33);
            this.pTitularSaldo.Name = "pTitularSaldo";
            this.pTitularSaldo.Size = new System.Drawing.Size(197, 60);
            this.pTitularSaldo.TabIndex = 13;
            // 
            // pSacaDeposita
            // 
            this.pSacaDeposita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSacaDeposita.Controls.Add(this.mtbValor);
            this.pSacaDeposita.Controls.Add(this.label8);
            this.pSacaDeposita.Controls.Add(this.btnDepositar);
            this.pSacaDeposita.Controls.Add(this.btnSacar);
            this.pSacaDeposita.Location = new System.Drawing.Point(8, 99);
            this.pSacaDeposita.Name = "pSacaDeposita";
            this.pSacaDeposita.Size = new System.Drawing.Size(197, 92);
            this.pSacaDeposita.TabIndex = 15;
            // 
            // mtbValor
            // 
            this.mtbValor.Enabled = false;
            this.mtbValor.Location = new System.Drawing.Point(69, 11);
            this.mtbValor.Mask = "0000000000000000";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 20);
            this.mtbValor.TabIndex = 2;
            this.mtbValor.TextChanged += new System.EventHandler(this.MtbValor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Valor";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Enabled = false;
            this.btnDepositar.Location = new System.Drawing.Point(93, 53);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(61, 23);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // tpDetalhes
            // 
            this.tpDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDetalhes.Controls.Add(this.btnDeletar);
            this.tpDetalhes.Controls.Add(this.cbTitulares2);
            this.tpDetalhes.Controls.Add(this.txtSaldo3);
            this.tpDetalhes.Controls.Add(this.txtTitular3);
            this.tpDetalhes.Controls.Add(this.pTitularSaldoNum);
            this.tpDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tpDetalhes.Name = "tpDetalhes";
            this.tpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalhes.Size = new System.Drawing.Size(215, 200);
            this.tpDetalhes.TabIndex = 2;
            this.tpDetalhes.Text = "Detalhes";
            this.tpDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(73, 166);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(80, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar conta";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // cbTitulares2
            // 
            this.cbTitulares2.FormattingEnabled = true;
            this.cbTitulares2.ItemHeight = 13;
            this.cbTitulares2.Location = new System.Drawing.Point(8, 6);
            this.cbTitulares2.Name = "cbTitulares2";
            this.cbTitulares2.Size = new System.Drawing.Size(197, 21);
            this.cbTitulares2.TabIndex = 8;
            this.cbTitulares2.SelectedIndexChanged += new System.EventHandler(this.CbTitulares2_SelectedIndexChanged);
            this.cbTitulares2.TextChanged += new System.EventHandler(this.CbTitulares2_TextChanged);
            // 
            // txtSaldo3
            // 
            this.txtSaldo3.Enabled = false;
            this.txtSaldo3.Location = new System.Drawing.Point(73, 71);
            this.txtSaldo3.Name = "txtSaldo3";
            this.txtSaldo3.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo3.TabIndex = 1;
            // 
            // txtTitular3
            // 
            this.txtTitular3.Enabled = false;
            this.txtTitular3.Location = new System.Drawing.Point(73, 45);
            this.txtTitular3.Name = "txtTitular3";
            this.txtTitular3.Size = new System.Drawing.Size(100, 20);
            this.txtTitular3.TabIndex = 0;
            // 
            // pTitularSaldoNum
            // 
            this.pTitularSaldoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTitularSaldoNum.Controls.Add(this.txtNumero1);
            this.pTitularSaldoNum.Controls.Add(this.label9);
            this.pTitularSaldoNum.Controls.Add(this.txtSaque1);
            this.pTitularSaldoNum.Controls.Add(this.label5);
            this.pTitularSaldoNum.Controls.Add(this.label4);
            this.pTitularSaldoNum.Controls.Add(this.label3);
            this.pTitularSaldoNum.Location = new System.Drawing.Point(8, 33);
            this.pTitularSaldoNum.Name = "pTitularSaldoNum";
            this.pTitularSaldoNum.Size = new System.Drawing.Size(197, 127);
            this.pTitularSaldoNum.TabIndex = 7;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Enabled = false;
            this.txtNumero1.Location = new System.Drawing.Point(64, 63);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Saques";
            // 
            // txtSaque1
            // 
            this.txtSaque1.Enabled = false;
            this.txtSaque1.Location = new System.Drawing.Point(64, 90);
            this.txtSaque1.Name = "txtSaque1";
            this.txtSaque1.Size = new System.Drawing.Size(100, 20);
            this.txtSaque1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titular";
            // 
            // JPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 223);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "JPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.JPrincipal_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpConta.ResumeLayout(false);
            this.tpConta.PerformLayout();
            this.tpCaixa.ResumeLayout(false);
            this.tpCaixa.PerformLayout();
            this.pSacaDeposita.ResumeLayout(false);
            this.pSacaDeposita.PerformLayout();
            this.tpDetalhes.ResumeLayout(false);
            this.tpDetalhes.PerformLayout();
            this.pTitularSaldoNum.ResumeLayout(false);
            this.pTitularSaldoNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTitulares1;
        private System.Windows.Forms.TextBox txtTitular1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitular2;
        private System.Windows.Forms.TextBox txtSaldo2;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpConta;
        private System.Windows.Forms.TabPage tpCaixa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pTitularSaldo;
        private System.Windows.Forms.Panel pSacaDeposita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TabPage tpDetalhes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTitulares2;
        private System.Windows.Forms.TextBox txtSaque1;
        private System.Windows.Forms.TextBox txtSaldo3;
        private System.Windows.Forms.TextBox txtTitular3;
        private System.Windows.Forms.Panel pTitularSaldoNum;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblAdicionado;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbSaldo1;
        private System.Windows.Forms.MaskedTextBox mtbValor;
    }
}

