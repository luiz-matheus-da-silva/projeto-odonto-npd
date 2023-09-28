using Class1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odonto_csharp
{
    public partial class frmConsultaPacientes : Form
    {
        string idSelecionado;
        DataTable tabela = new DataTable();
        public frmConsultaPacientes()
        {
            InitializeComponent();
        }



        private void frmConsultaPacientes_Shown(object sender, EventArgs e)
        {

        }
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=D:\\Users\\luizm\\Documents\\odonto\\banco_odonto");
            conexao.Open();
            return conexao;
        }



        private void frmConsultaPacientes_Load(object sender, EventArgs e)
        {
            //string consulta = "SELECT * FROM tb_pacientes";
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexao);
            //DataTable dt = new DataTable();
            //adaptador.Fill(dt);
            //dataGridView1.DataSource = dt;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            DataTable tabelaPacientes = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pacientes";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

 
    private void gridTabelaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
            
          }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            DataTable tabelaPacientes = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pacientes WHERE T_NOMECOMPLETO LIKE '%" + textBox1.Text + "%'" ;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            DataTable tabelaPacientes = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pacientes WHERE N_PRONTUARIO = " + textBox2.Text ;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            DataTable tabelaPacientes = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pacientes WHERE T_OBSERVACAO LIKE '%" + textBox3.Text + "%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }
       
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            FrmNovoCadastro frm = new FrmNovoCadastro(id);
            frm.ShowDialog();

            
        }
        private void AtualizarPlanilhaDados()
        {
            // Limpa os dados existentes no DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pacientes";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);

                    // Define a fonte de dados do DataGridView como a nova tabela
                    dataGridView1.DataSource = dt;

                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarPlanilhaDados();
        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e) {
            // Renomeie as colunas diretamente no DataGridView
            dataGridView1.Columns["T_NOMECOMPLETO"].HeaderText = "Nome Completo";
            dataGridView1.Columns["N_PRONTUARIO"].HeaderText = "Número do Prontuário";
            dataGridView1.Columns["T_OBSERVACAO"].HeaderText = "Observação";
            dataGridView1.Columns["N_IDADE"].HeaderText = "Idade";
            dataGridView1.Columns["T_TELEFONE"].HeaderText = "Telefone";
            dataGridView1.Columns["T_TELEFONERECADO"].HeaderText = "Telefone p/ recado";
            dataGridView1.Columns["T_TRATAMENTO"].HeaderText = "Tratamento";
            dataGridView1.Columns["N_EXTRACAO"].HeaderText = "Extração";
            dataGridView1.Columns["T_STATUS"].HeaderText = "Status";
            dataGridView1.Columns["T_Data"].HeaderText = "Data de Cadastro";

            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
