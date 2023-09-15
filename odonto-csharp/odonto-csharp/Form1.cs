using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odonto_csharp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Configure o Timer para atualizar a cada segundo (1000 ms)
            timerAtualizacao.Interval = 1000;
            timerAtualizacao.Start();

            // Chame a função de atualização imediatamente para definir a data e hora inicial
            AtualizarDataHora();
        }

        private void timerAtualizacao_Tick(object sender, EventArgs e) {
            // Ocorre a cada intervalo definido no Timer
            AtualizarDataHora();
        }

        private void AtualizarDataHora() {
            // Obtém a data e hora atuais do sistema
            DateTime dataHoraAtual = DateTime.Now;

            // Define o texto do rótulo para exibir a data e hora
            txtDataHora.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");
        }

        private void timer1_Tick(object sender, EventArgs e) {
            AtualizarDataHora();
        }

        private void Form1_Load_1(object sender, EventArgs e) {
            AtualizarDataHora();
        }
    }
}
