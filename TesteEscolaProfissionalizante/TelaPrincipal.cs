using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteEscolaProfissionalizante
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaCadastraAluno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastraAluno tela02 = new TelaCadastraAluno();
            tela02.Show();
        }

        private void TelaCadastraCursos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastraCursos tela03 = new TelaCadastraCursos();
            tela03.Show();
        }

        private void TelaPesquisaAlunos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPesquisaAlunos tela04 = new TelaPesquisaAlunos();
            tela04.Show();
        }

        private void TelaPesquisaCursos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPesquisaCursos tela05 = new TelaPesquisaCursos();
            tela05.Show();
        }

        private void TelaRelatorioAlunos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaRelatorioAlunos tela06 = new TelaRelatorioAlunos();
            tela06.Show();
        }

        private void TelaRelatorioCursos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaRelatorioCursos tela07 = new TelaRelatorioCursos();
            tela07.Show();
        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            TelaLogin tela08 = new TelaLogin();
            tela08.Show();
        }
    }
}
