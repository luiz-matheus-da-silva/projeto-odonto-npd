namespace odonto_csharp
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.txtDataHora = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.imgLogoNpd = new System.Windows.Forms.PictureBox();
            this.timerAtualizacao = new System.Windows.Forms.Timer(this.components);
            this.imgLogoUnicesumar = new System.Windows.Forms.PictureBox();
            this.pnlNavbar.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoNpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoUnicesumar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            this.pnlNavbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNavbar.Controls.Add(this.pnlDateTime);
            this.pnlNavbar.Controls.Add(this.btnPacientes);
            this.pnlNavbar.Controls.Add(this.btnNovoCadastro);
            this.pnlNavbar.Controls.Add(this.imgLogoNpd);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(200, 729);
            this.pnlNavbar.TabIndex = 0;
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BackColor = System.Drawing.Color.Transparent;
            this.pnlDateTime.Controls.Add(this.txtDataHora);
            this.pnlDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDateTime.Location = new System.Drawing.Point(0, 629);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(200, 100);
            this.pnlDateTime.TabIndex = 1;
            // 
            // txtDataHora
            // 
            this.txtDataHora.AutoSize = true;
            this.txtDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHora.ForeColor = System.Drawing.Color.White;
            this.txtDataHora.Location = new System.Drawing.Point(35, 71);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(57, 20);
            this.txtDataHora.TabIndex = 3;
            this.txtDataHora.Text = "label1";
            this.txtDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.Location = new System.Drawing.Point(-116, 203);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(313, 36);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "                               Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.ForeColor = System.Drawing.Color.White;
            this.btnNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCadastro.Image")));
            this.btnNovoCadastro.Location = new System.Drawing.Point(-116, 143);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(316, 36);
            this.btnNovoCadastro.TabIndex = 1;
            this.btnNovoCadastro.Text = "                                 Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // imgLogoNpd
            // 
            this.imgLogoNpd.BackColor = System.Drawing.Color.Transparent;
            this.imgLogoNpd.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoNpd.Image")));
            this.imgLogoNpd.Location = new System.Drawing.Point(15, 0);
            this.imgLogoNpd.Margin = new System.Windows.Forms.Padding(6);
            this.imgLogoNpd.Name = "imgLogoNpd";
            this.imgLogoNpd.Padding = new System.Windows.Forms.Padding(3);
            this.imgLogoNpd.Size = new System.Drawing.Size(169, 165);
            this.imgLogoNpd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoNpd.TabIndex = 0;
            this.imgLogoNpd.TabStop = false;
            // 
            // timerAtualizacao
            // 
            this.timerAtualizacao.Enabled = true;
            this.timerAtualizacao.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgLogoUnicesumar
            // 
            this.imgLogoUnicesumar.BackColor = System.Drawing.Color.White;
            this.imgLogoUnicesumar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogoUnicesumar.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoUnicesumar.Image")));
            this.imgLogoUnicesumar.Location = new System.Drawing.Point(200, 0);
            this.imgLogoUnicesumar.Name = "imgLogoUnicesumar";
            this.imgLogoUnicesumar.Padding = new System.Windows.Forms.Padding(3);
            this.imgLogoUnicesumar.Size = new System.Drawing.Size(1150, 729);
            this.imgLogoUnicesumar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoUnicesumar.TabIndex = 1;
            this.imgLogoUnicesumar.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.imgLogoUnicesumar);
            this.Controls.Add(this.pnlNavbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Início - Sistema Odonto Unicesumar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoNpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoUnicesumar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.PictureBox imgLogoNpd;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label txtDataHora;
        private System.Windows.Forms.Timer timerAtualizacao;
        private System.Windows.Forms.PictureBox imgLogoUnicesumar;
    }
}

