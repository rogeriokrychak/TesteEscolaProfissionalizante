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
    public partial class TelaRelatorioAlunos : Form
    {
        SQLiteConnection connect = new SQLiteConnection("Data Source = C:\\bancos\\escola.db; Version=3;");

        public TelaRelatorioAlunos()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            connect.Open();//abre a conexão com o banco de dados
            SQLiteCommand command = connect.CreateCommand();//cria o comando para manipular os dados
            command.CommandText = "select * from alunos where id like id order by id ";//faz um select
            //ou consulta e mostra um relatório dentro do gridview pelo id em ordem decrescente
            SQLiteDataReader result = command.ExecuteReader();
            dataGridView1.Rows.Clear();//limpa as linhas de consulta dentro do gridview
            while (result.Read())
            {
                dataGridView1.Rows.Add(new string[] {
                    result.GetInt32("id").ToString(),
                    result.GetString("nome"),
                    result.GetString("endereco"),
                    result.GetString("telefone"),
                    result.GetString("email"),
                    result.GetString("curso"),
                    result.GetString("observacao")

                });
            }
            connect.Close();//fecha a conexão com o banco de dados
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela01 = new TelaPrincipal();
            tela01.Show();
        }
    }
}
