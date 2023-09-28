namespace odonto_csharp {
    partial class FrmNovoCadastro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoCadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTratamento = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.dateCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblRetirarDente = new System.Windows.Forms.Label();
            this.numDenteExtracao = new System.Windows.Forms.NumericUpDown();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numProntuario = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadastroDePaciente = new System.Windows.Forms.Label();
            this.cbxTratamento = new System.Windows.Forms.ComboBox();
            this.mtbTelefoneRecado = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblTelefoneRecado = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.radioFuncionario = new System.Windows.Forms.RadioButton();
            this.radioComunidade = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDenteExtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProntuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTratamento);
            this.panel1.Controls.Add(this.lblObservacoes);
            this.panel1.Controls.Add(this.txtObservacoes);
            this.panel1.Controls.Add(this.dateCadastro);
            this.panel1.Controls.Add(this.lblDataCadastro);
            this.panel1.Controls.Add(this.lblRetirarDente);
            this.panel1.Controls.Add(this.numDenteExtracao);
            this.panel1.Controls.Add(this.numIdade);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbxTratamento);
            this.panel1.Controls.Add(this.mtbTelefoneRecado);
            this.panel1.Controls.Add(this.mtbTelefone);
            this.panel1.Controls.Add(this.txtNomeCompleto);
            this.panel1.Controls.Add(this.lblTelefoneRecado);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.lblNomeCompleto);
            this.panel1.Controls.Add(this.radioFuncionario);
            this.panel1.Controls.Add(this.radioComunidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 678);
            this.panel1.TabIndex = 0;
            
            // 
            // lblTratamento
            // 
            this.lblTratamento.AutoSize = true;
            this.lblTratamento.Location = new System.Drawing.Point(141, 332);
            this.lblTratamento.Name = "lblTratamento";
            this.lblTratamento.Size = new System.Drawing.Size(122, 22);
            this.lblTratamento.TabIndex = 22;
            this.lblTratamento.Text = "Tratamento:";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(124, 413);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(139, 22);
            this.lblObservacoes.TabIndex = 21;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(269, 413);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(690, 152);
            this.txtObservacoes.TabIndex = 20;
            this.txtObservacoes.Text = "\n";
            // 
            // dateCadastro
            // 
            this.dateCadastro.CustomFormat = "dd/MM/yyyy";
            this.dateCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCadastro.Location = new System.Drawing.Point(269, 278);
            this.dateCadastro.Name = "dateCadastro";
            this.dateCadastro.Size = new System.Drawing.Size(157, 31);
            this.dateCadastro.TabIndex = 19;
            
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(80, 284);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(183, 22);
            this.lblDataCadastro.TabIndex = 18;
            this.lblDataCadastro.Text = "Data do Cadastro:";
            // 
            // lblRetirarDente
            // 
            this.lblRetirarDente.AutoSize = true;
            this.lblRetirarDente.Location = new System.Drawing.Point(265, 367);
            this.lblRetirarDente.Name = "lblRetirarDente";
            this.lblRetirarDente.Size = new System.Drawing.Size(136, 22);
            this.lblRetirarDente.TabIndex = 17;
            this.lblRetirarDente.Text = "Retirar Dente:";
            this.lblRetirarDente.Visible = false;
            // 
            // numDenteExtracao
            // 
            this.numDenteExtracao.Location = new System.Drawing.Point(407, 365);
            this.numDenteExtracao.Name = "numDenteExtracao";
            this.numDenteExtracao.Size = new System.Drawing.Size(120, 31);
            this.numDenteExtracao.TabIndex = 16;
            this.numDenteExtracao.Visible = false;
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(871, 231);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(88, 31);
            this.numIdade.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(194)))), ((int)(((byte)(37)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCadastrar.FlatAppearance.BorderSize = 3;
            this.btnCadastrar.Location = new System.Drawing.Point(796, 595);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(165, 59);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(616, 595);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 59);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.numProntuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCadastroDePaciente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 100);
            this.panel2.TabIndex = 12;
            // 
            // numProntuario
            // 
            this.numProntuario.Location = new System.Drawing.Point(910, 37);
            this.numProntuario.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numProntuario.Name = "numProntuario";
            this.numProntuario.Size = new System.Drawing.Size(85, 31);
            this.numProntuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(867, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "N°:";
            // 
            // lblCadastroDePaciente
            // 
            this.lblCadastroDePaciente.AutoSize = true;
            this.lblCadastroDePaciente.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroDePaciente.ForeColor = System.Drawing.Color.White;
            this.lblCadastroDePaciente.Location = new System.Drawing.Point(348, 30);
            this.lblCadastroDePaciente.Name = "lblCadastroDePaciente";
            this.lblCadastroDePaciente.Size = new System.Drawing.Size(392, 38);
            this.lblCadastroDePaciente.TabIndex = 0;
            this.lblCadastroDePaciente.Text = "CADASTRO DE PACIENTE";
            // 
            // cbxTratamento
            // 
            this.cbxTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTratamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTratamento.FormattingEnabled = true;
            this.cbxTratamento.Items.AddRange(new object[] {
            "ENDODONTIA (CANAL)",
            "DENTÍSTICA (RESTAURAÇÃO E ESTÉTICA)",
            "PERIODONTIA (GENGIVA, LIMPEZA)",
            "PRÓTESE TOTAL (DENTADURA)",
            "PRÓTESE REMOVÍVEL (PONTE)",
            "PRÓTESE FIXA (PIVO, JAQUETA, COROA)",
            "PEDIATRIA (5 A 13 ANOS)",
            "EXTRAÇÃO",
            "EMDORF (DOR NA MANDÍBULA)",
            "ORTODONTIA (APARELHO P/ CRIANÇAS DE 5 A 10 ANOS)",
            "INTEGRADA"});
            this.cbxTratamento.Location = new System.Drawing.Point(269, 329);
            this.cbxTratamento.Name = "cbxTratamento";
            this.cbxTratamento.Size = new System.Drawing.Size(690, 30);
            this.cbxTratamento.TabIndex = 11;
           
            // 
            // mtbTelefoneRecado
            // 
            this.mtbTelefoneRecado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTelefoneRecado.Location = new System.Drawing.Point(614, 233);
            this.mtbTelefoneRecado.Mask = "(00) 0 0000-0000";
            this.mtbTelefoneRecado.Name = "mtbTelefoneRecado";
            this.mtbTelefoneRecado.Size = new System.Drawing.Size(165, 24);
            this.mtbTelefoneRecado.TabIndex = 8;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTelefone.Location = new System.Drawing.Point(269, 233);
            this.mtbTelefone.Mask = "(00) 0 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(157, 24);
            this.mtbTelefone.TabIndex = 7;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCompleto.Location = new System.Drawing.Point(269, 185);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(690, 24);
            this.txtNomeCompleto.TabIndex = 6;
            // 
            // lblTelefoneRecado
            // 
            this.lblTelefoneRecado.AutoSize = true;
            this.lblTelefoneRecado.Location = new System.Drawing.Point(449, 233);
            this.lblTelefoneRecado.Name = "lblTelefoneRecado";
            this.lblTelefoneRecado.Size = new System.Drawing.Size(159, 22);
            this.lblTelefoneRecado.TabIndex = 5;
            this.lblTelefoneRecado.Text = "Fone p/ recado:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(171, 235);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(92, 22);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(794, 235);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(71, 22);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(98, 185);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(166, 22);
            this.lblNomeCompleto.TabIndex = 2;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // radioFuncionario
            // 
            this.radioFuncionario.AutoSize = true;
            this.radioFuncionario.Location = new System.Drawing.Point(502, 127);
            this.radioFuncionario.Name = "radioFuncionario";
            this.radioFuncionario.Size = new System.Drawing.Size(279, 26);
            this.radioFuncionario.TabIndex = 1;
            this.radioFuncionario.TabStop = true;
            this.radioFuncionario.Text = "Funcionário da UniCesumar";
            this.radioFuncionario.UseVisualStyleBackColor = true;
           
            // radioComunidade
            // 
            this.radioComunidade.AutoSize = true;
            this.radioComunidade.Location = new System.Drawing.Point(326, 127);
            this.radioComunidade.Name = "radioComunidade";
            this.radioComunidade.Size = new System.Drawing.Size(150, 26);
            this.radioComunidade.TabIndex = 0;
            this.radioComunidade.TabStop = true;
            this.radioComunidade.Text = "Comunidade";
            this.radioComunidade.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            
            // 
            // FrmNovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 678);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cadastro - Sistema Odonto UniCesumar";
            this.Load += new System.EventHandler(this.FrmNovoCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDenteExtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProntuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTelefoneRecado;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.RadioButton radioFuncionario;
        private System.Windows.Forms.RadioButton radioComunidade;
        private System.Windows.Forms.ComboBox cbxTratamento;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneRecado;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadastroDePaciente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.Label lblRetirarDente;
        private System.Windows.Forms.NumericUpDown numDenteExtracao;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.DateTimePicker dateCadastro;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblTratamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numProntuario;
    }
}