using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteEscolaProfissionalizante
{
    public partial class TelaCadastraAluno : Form
    {
        SQLiteConnection connect = new SQLiteConnection("Data Source = C:\\bancos\\escola.db; Version=3;");

        public TelaCadastraAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();//abre a conexão com o banco de dados
                MessageBox.Show("Conexao OK");
                SQLiteCommand command = connect.CreateCommand();//cria o comando para criar o comando select
                                                                //criar o comando para inserir os dados no banco de dados
                command.CommandText = "insert into alunos(nome,endereco,telefone,email,curso,observacao) VALUES (@nome,@endereco,@telefone,@email,@curso,@observacao)";
                command.Parameters.AddWithValue("@nome", campoNome.Text);//essa chamada de comando ela chama a coluna e troca os parametros escritos aqui
                command.Parameters.AddWithValue("@endereco", campoEndereco.Text);
                command.Parameters.AddWithValue("@telefone", campoTelefone.Text);
                command.Parameters.AddWithValue("@email", campoEmail.Text);
                command.Parameters.AddWithValue("@curso", campoCurso.Text);
                command.Parameters.AddWithValue("@observacao", campoObservacao.Text);
                command.Prepare();
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Cadastro inserido!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Salvar!!!");
            }
        }

        private void btnVOLTAR_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela01 = new TelaPrincipal();
            tela01.Show();
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();//abre a conexão com o banco de dados
                //MessageBox.Show("Conexao OK");
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "update alunos set nome=@nome,endereco=@endereco,telefone=@telefone,email=@email,curso=@curso,observacao=@observacao where id=@id";
                command.Parameters.AddWithValue("id", campoID.Text);
                command.Parameters.AddWithValue("@nome", campoNome.Text);
                command.Parameters.AddWithValue("@endereco", campoEndereco.Text);
                command.Parameters.AddWithValue("@telefone", campoTelefone.Text);
                command.Parameters.AddWithValue("@email", campoEmail.Text);
                command.Parameters.AddWithValue("@curso", campoCurso.Text);
                command.Parameters.AddWithValue("@observacao", campoObservacao.Text);
                command.Prepare();
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Alterar!!!");
            }
            connect.Close();//fecha a conexão com o banco
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                //MessageBox.Show("Conexão Ok");
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "delete from alunos where id=@id";
                command.Parameters.AddWithValue("@id", campoID.Text);
                command.Parameters.AddWithValue("@nome", campoNome.Text);
                command.Parameters.AddWithValue("@endereco", campoEndereco.Text);
                command.Parameters.AddWithValue("@telefone", campoTelefone.Text);
                command.Parameters.AddWithValue("@email", campoEmail.Text);
                command.Parameters.AddWithValue("@curso", campoCurso.Text);
                command.Parameters.AddWithValue("@observacao", campoObservacao.Text);
                command.Prepare();
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao excluir!!!");
            }
            connect.Close();
        }

        private void btnTelaRelatorioAlunos_Click(object sender, EventArgs e)
        {
            TelaRelatorioAlunos tela06 = new TelaRelatorioAlunos();
            tela06.Show();
        }
    }
}
