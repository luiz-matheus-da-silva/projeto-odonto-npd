using MySql.Data.MySqlClient;
using odonto_csharp;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Class1 {
    class Banco {
        private static SQLiteConnection conexao;
        private static object gridTabelaPacientes;

        private static SQLiteConnection ConexaoBanco() {
            conexao = new SQLiteConnection("Data Source=E:\\odonto-csharp\\odonto-csharp\\banco\\banco_odonto");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosPacientes() {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            DataTable tabelaPacientes = new DataTable();

            try {
                using (var cmd = ConexaoBanco().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM tb_pacientes";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            } catch (Exception ex) 
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable consulta(string sql) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try 
            {
                using (var cmd = ConexaoBanco().CreateCommand()) 
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            } catch (Exception ex) 
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        /////INSERÇÃO FORM CADASTRO PACIENTES NO BD

            public static void NovoPaciente(Pacientes p) {
                try {
                    using (var cmd = ConexaoBanco().CreateCommand()) {
                        cmd.CommandText = "INSERT INTO tb_pacientes (N_PRONTUARIO,T_NOMECOMPLETO,N_IDADE,T_TELEFONE,T_TELEFONERECADO,T_TRATAMENTO,N_EXTRACAO, T_OBSERVACAO, T_STATUS) " +
                                          "VALUES (@prontuario,@nomecompleto,@idade,@telefone,@telefonerecado,@tratamento,@extracao,@observacao,@status)";
                        cmd.Parameters.AddWithValue("@prontuario", p.N_PRONTUARIO);
                        cmd.Parameters.AddWithValue("@nomecompleto", p.T_NOMECOMPLETO);
                        cmd.Parameters.AddWithValue("@idade", p.N_IDADE);
                        cmd.Parameters.AddWithValue("@telefone", p.T_TELEFONE);
                        cmd.Parameters.AddWithValue("@telefonerecado", p.T_TELEFONERECADO);
                        cmd.Parameters.AddWithValue("@tratamento", p.T_TRATAMENTO);
                        cmd.Parameters.AddWithValue("@extracao", p.N_EXTRACAO);
                        cmd.Parameters.AddWithValue("@observacao", p.T_OBSERVACAO);
                        cmd.Parameters.AddWithValue("@status", p.T_STATUS);
                        cmd.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Erro ao cadastrar: O NÚMERO DO PRONTUÁRIO JA CONSTA EM OUTRO CADASTRO \n" + ex.Message);
                } finally {
                    MessageBox.Show("Cadastro feito com sucesso!");
                    ConexaoBanco().Close();
                }
            }
            ///FIM
        }
}

