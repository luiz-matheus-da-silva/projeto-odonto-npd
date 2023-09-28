using System;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace odonto_csharp
{
    public partial class FrmNovoCadastro : Form
    {
        int id = 0;

        public FrmNovoCadastro(int id)
        {
            InitializeComponent();
            this.id = id;
            if (this.id > 0)
            {
                GetPaciente(id);
            }
        }
        private static SQLiteConnection conexao;
        private SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=F:\\projeto-odonto-npd-main\\odonto-csharp\\odonto-csharp\\banco\\banco_odonto");
            conexao.Open();
            return conexao;
        }

        private void GetPaciente(int id)
        {
            try
            {
                using (var connection = ConexaoBanco())
                {
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM tb_pacientes WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtNomeCompleto.Text = dr["T_NOMECOMPLETO"].ToString();

                                if (!dr.IsDBNull(dr.GetOrdinal("N_IDADE")))
                                {
                                    numIdade.Value = Convert.ToInt32(dr["N_IDADE"]);
                                }

                                mtbTelefone.Text = dr["T_TELEFONE"].ToString();
                                mtbTelefoneRecado.Text = dr["T_TELEFONERECADO"].ToString();

                                if (!dr.IsDBNull(dr.GetOrdinal("T_TRATAMENTO")))
                                {
                                    cbxTratamento.SelectedIndex = Convert.ToInt32(dr["T_TRATAMENTO"]);
                                }

                                if (!dr.IsDBNull(dr.GetOrdinal("N_PRONTUARIO")))
                                {
                                    numProntuario.Value = Convert.ToInt32(dr["N_PRONTUARIO"]);
                                }

                                if (!dr.IsDBNull(dr.GetOrdinal("N_EXTRACAO")))
                                {
                                    numDenteExtracao.Value = Convert.ToInt32(dr["N_EXTRACAO"]);
                                }

                                txtObservacoes.Text = dr["T_OBSERVACAO"].ToString();

                                // Converter a data e hora para DateTime, assumindo que o formato seja "dd/MM/yyyy HH:mm:ss"
                                if (!dr.IsDBNull(dr.GetOrdinal("T_DATA")))
                                {
                                               
                                    dateCadastro.Text = dr["T_DATA"].ToString();
                                    
                                }

                                string status = dr["T_STATUS"].ToString();
                                if (status == "Comunidade")
                                {
                                    radioComunidade.Checked = true;
                                }
                                else if (status == "Funcionário")
                                {
                                    radioFuncionario.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados do paciente: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Lógica para idade e tratamento
            if (cbxTratamento.Text == "PEDIATRIA (5 A 13 ANOS)" && (numIdade.Value > 13 || numIdade.Value < 5))
            {
                MessageBox.Show("O tratamento selecionado só está disponível para pacientes de 5 a 13 anos!", "TRATAMENTO INVÁLIDO");
                return;
            }

            if (cbxTratamento.Text == "ORTODONTIA (APARELHO P/ CRIANÇAS DE 5 A 10 ANOS)" && (numIdade.Value > 10 || numIdade.Value < 5))
            {
                MessageBox.Show("O tratamento selecionado só está disponível para pacientes de 5 a 10 anos!", "TRATAMENTO INVÁLIDO");
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            InserirOuAtualizarPaciente();

            // Lógica relacionada ao banco de dados
            // ...

            // Feche a janela (se necessário)
            Close();
        }

        private void InserirOuAtualizarPaciente()
        {
            using (var connection = ConexaoBanco())
            {
                string sql = "";

                if (id == 0)
                {
                    sql = "INSERT INTO tb_pacientes (N_PRONTUARIO, T_NOMECOMPLETO, N_IDADE, T_TELEFONE, T_TELEFONERECADO, T_TRATAMENTO, N_EXTRACAO, T_OBSERVACAO, T_STATUS, T_DATA) VALUES (@prontuario, @nomecompleto, @idade, @telefone, @telefonerecado, @tratamento, @extracao, @observacao, @status, @data)";
                }
                else
                {
                    sql = "UPDATE tb_pacientes SET N_PRONTUARIO = @prontuario, T_NOMECOMPLETO = @nomecompleto, N_IDADE = @idade, T_TELEFONE = @telefone, " +
                          "T_TELEFONERECADO = @telefonerecado, T_TRATAMENTO = @tratamento, N_EXTRACAO = @extracao, T_OBSERVACAO = @observacao, T_STATUS = @status, T_DATA = @data " +
                          "WHERE id = @id";
                }

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@prontuario", numProntuario.Value);
                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@idade", numIdade.Value);
                    cmd.Parameters.AddWithValue("@telefone", mtbTelefone.Text);
                    cmd.Parameters.AddWithValue("@telefonerecado", mtbTelefoneRecado.Text);
                    cmd.Parameters.AddWithValue("@tratamento", cbxTratamento.SelectedIndex);
                    cmd.Parameters.AddWithValue("@extracao", numDenteExtracao.Value);
                    cmd.Parameters.AddWithValue("@observacao", txtObservacoes.Text);

                    string status = radioComunidade.Checked ? "Comunidade" : "Funcionário";
                    cmd.Parameters.AddWithValue("@status", status);

                    // Certifique-se de converter a data para o formato correto antes de adicioná-la como parâmetro
                    cmd.Parameters.AddWithValue("@data", dateCadastro.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                    // Execute a consulta SQL para inserir ou atualizar o paciente
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private bool ValidarCampos()
        {
            // Verificação se os campos estão preenchidos
            // radioButton
            if (!radioComunidade.Checked && !radioFuncionario.Checked)
            {
                MessageBox.Show("Selecione o status do paciente!", "Dados Incompletos");
                return false;
            }

            // inputNomeCompleto
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Preencha o campo Nome Completo!", "Dados Incompletos");
                return false;
            }

            // inputTelefone
            if (string.IsNullOrWhiteSpace(mtbTelefone.Text))
            {
                MessageBox.Show("Preencha o campo Telefone!", "Dados Incompletos");
                return false;
            }

            // inputTelefoneRecado
            if (string.IsNullOrWhiteSpace(mtbTelefoneRecado.Text))
            {
                MessageBox.Show("Preencha o campo Telefone Recado!", "Dados Incompletos");
                return false;
            }

            // inputIdade
            if (numIdade.Value == 0)
            {
                MessageBox.Show("Preencha o campo Idade!", "Dados Incompletos");
                return false;
            }

            // Se todas as verificações passaram, os campos estão preenchidos corretamente
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você deseja cancelar o cadastro atual?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Código a ser executado se o usuário escolher "Sim"
                Close();
            }
        }

        private void cbxTratamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTratamento.Text == "EXTRAÇÃO")
            {
                lblRetirarDente.Visible = true;
                numDenteExtracao.Visible = true;
            }
            else
            {
                lblRetirarDente.Visible = false;
                numDenteExtracao.Visible = false;
            }
        }

        private void FrmNovoCadastro_Load(object sender, EventArgs e)
        {
            // Configurações iniciais
            radioComunidade.Checked = true;
            dateCadastro.Value = DateTime.Now;
        }
    }
}