using Class1;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odonto_csharp {
    public partial class FrmNovoCadastro : Form {
        public FrmNovoCadastro() {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            //Lógica para idade e tratamento
            if (cbxTratamento.Text == "PEDIATRIA (5 A 13 ANOS)" && (numIdade.Value > 13 || numIdade.Value < 5)) {
                MessageBox.Show("O tratamento selecionado só está disponível para pacientes de 5 a 13 anos!", "TRATAMENTO INVÁLIDO");
                return;
            }

            if (cbxTratamento.Text == "ORTODONTIA (APARELHO P/ CRIANÇAS DE 5 A 10 ANOS)" && (numIdade.Value > 10 || numIdade.Value < 5)) {
                MessageBox.Show("O tratamento selecionado só está disponível para pacientes de 5 a 10 anos!", "TRATAMENTO INVÁLIDO");
                return;
            }

            if (!ValidarCampos()) {
                return;
            }

            // Lógica relacionada ao banco de dados
            // Adicionar no BD:
            Pacientes paciente = new Pacientes();
            paciente.N_PRONTUARIO = numProntuario.Value;
            paciente.T_NOMECOMPLETO = txtNomeCompleto.Text;
            paciente.N_IDADE = numIdade.Value;
            paciente.T_TELEFONE = mtbTelefone.Text;
            paciente.T_TELEFONERECADO = mtbTelefoneRecado.Text;
            paciente.T_TRATAMENTO = cbxTratamento.Text;
            paciente.N_EXTRACAO = numDenteExtracao.Value;
            paciente.T_OBSERVACAO = txtObservacoes.Text;
            paciente.T_STATUS = radioComunidade.Text;

            Banco.NovoPaciente(paciente);

            Close();
        }

        private bool ValidarCampos() {
            // Verificação se os campos estão preenchidos
            // radioButton
            if (radioComunidade.Checked == false && radioFuncionario.Checked == false) {
                MessageBox.Show("Preencha TODOS os campos!", "Dados Incompletos");
                return false;
            }

            // inputNomeCompleto
            if (txtNomeCompleto.Text == "") {
                MessageBox.Show("Preencha TODOS os campos!", "Dados Incompletos");
                return false;
            }

            // inputTelefone
            if (mtbTelefone.Text == "") {
                MessageBox.Show("Preencha TODOS os campos!", "Dados Incompletos");
                return false;
            }

            // inputTelefoneRecado
            if (mtbTelefoneRecado.Text == "") {
                MessageBox.Show("Preencha TODOS os campos!", "Dados Incompletos");
                return false;
            }

            // inputIdade
            if (numIdade.Value == 0) {
                MessageBox.Show("Preencha TODOS os campos!", "Dados Incompletos");
                return false;
            }

            // Se todas as verificações passaram, os campos estão preenchidos corretamente
            return true;

        }
        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show("Você deseja cancelar o cadastro atual?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) {
                // Código a ser executado se o usuário escolher "Sim"
                Close();
            }
        }

        private void cbxTratamento_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (cbxTratamento.Text == "EXTRAÇÃO") {
                lblRetirarDente.Visible = true;
                numDenteExtracao.Visible = true;
            } else {
                lblRetirarDente.Visible = false;
                numDenteExtracao.Visible = false;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {

        }

        private void FrmNovoCadastro_Load(object sender, EventArgs e) {

        }

        private void radioFuncionario_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
