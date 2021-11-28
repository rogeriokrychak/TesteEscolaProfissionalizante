
namespace TesteEscolaProfissionalizante
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelaCadastraAluno = new System.Windows.Forms.LinkLabel();
            this.TelaCadastraCursos = new System.Windows.Forms.LinkLabel();
            this.TelaPesquisaAlunos = new System.Windows.Forms.LinkLabel();
            this.TelaPesquisaCursos = new System.Windows.Forms.LinkLabel();
            this.TelaRelatorioAlunos = new System.Windows.Forms.LinkLabel();
            this.TelaRelatorioCursos = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSAIR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TesteEscolaProfissionalizante.Properties.Resources.graduation_4474213_640;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLA PROFISSIONALIZANTE";
            // 
            // TelaCadastraAluno
            // 
            this.TelaCadastraAluno.AutoSize = true;
            this.TelaCadastraAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelaCadastraAluno.LinkColor = System.Drawing.Color.Black;
            this.TelaCadastraAluno.Location = new System.Drawing.Point(59, 109);
            this.TelaCadastraAluno.Name = "TelaCadastraAluno";
            this.TelaCadastraAluno.Size = new System.Drawing.Size(89, 28);
            this.TelaCadastraAluno.TabIndex = 1;
            this.TelaCadastraAluno.TabStop = true;
            this.TelaCadastraAluno.Text = "ALUNOS";
            this.TelaCadastraAluno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelaCadastraAluno_LinkClicked);
            // 
            // TelaCadastraCursos
            // 
            this.TelaCadastraCursos.AutoSize = true;
            this.TelaCadastraCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelaCadastraCursos.LinkColor = System.Drawing.Color.Black;
            this.TelaCadastraCursos.Location = new System.Drawing.Point(61, 149);
            this.TelaCadastraCursos.Name = "TelaCadastraCursos";
            this.TelaCadastraCursos.Size = new System.Drawing.Size(87, 28);
            this.TelaCadastraCursos.TabIndex = 2;
            this.TelaCadastraCursos.TabStop = true;
            this.TelaCadastraCursos.Text = "CURSOS";
            this.TelaCadastraCursos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelaCadastraCursos_LinkClicked);
            // 
            // TelaPesquisaAlunos
            // 
            this.TelaPesquisaAlunos.AutoSize = true;
            this.TelaPesquisaAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelaPesquisaAlunos.LinkColor = System.Drawing.Color.Black;
            this.TelaPesquisaAlunos.Location = new System.Drawing.Point(8, 188);
            this.TelaPesquisaAlunos.Name = "TelaPesquisaAlunos";
            this.TelaPesquisaAlunos.Size = new System.Drawing.Size(196, 28);
            this.TelaPesquisaAlunos.TabIndex = 3;
            this.TelaPesquisaAlunos.TabStop = true;
            this.TelaPesquisaAlunos.Text = "PESQUISAR ALUNOS";
            this.TelaPesquisaAlunos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelaPesquisaAlunos_LinkClicked);
            // 
            // TelaPesquisaCursos
            // 
            this.TelaPesquisaCursos.AutoSize = true;
            this.TelaPesquisaCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelaPesquisaCursos.LinkColor = System.Drawing.Color.Black;
            this.TelaPesquisaCursos.Location = new System.Drawing.Point(8, 225);
            this.TelaPesquisaCursos.Name = "TelaPesquisaCursos";
            this.TelaPesquisaCursos.Size = new System.Drawing.Size(194, 28);
            this.TelaPesquisaCursos.TabIndex = 4;
            this.TelaPesquisaCursos.TabStop = true;
            this.TelaPesquisaCursos.Text = "PESQUISAR CURSOS";
            this.TelaPesquisaCursos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelaPesquisaCursos_LinkClicked);
            // 
            // TelaRelatorioAlunos
            // 
            this.TelaRelatorioAlunos.AutoSize = true;
            this.TelaRelatorioAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelaRelatorioAlunos.LinkColor = System.Drawing.Color.Black;
            this.TelaRelatorioAlunos.Location = new System.Drawing.Point(10, 264);
            this.TelaRelatorioAlunos.Name = "TelaRelatorioAlunos";
            this.TelaRelatorioAlunos.Size = new System.Drawing.Size(194, 28);
            this.TelaRelatorioAlunos.TabIndex = 5;
            this.TelaRelatorioAlunos.TabStop = true;
            this.TelaRelatorioAlunos.Text = "RELATÓRIO ALUNOS";
            this.TelaRelatorioAlunos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelaRelatorioAlunos_LinkClicked);
            // 
            // TelaRelatorioCursos
            // 
            this.TelaRelatorioCursos.AutoSize = true;
            this.TelaRelatorioCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelaRelatorioCursos.LinkColor = System.Drawing.Color.Black;
            this.TelaRelatorioCursos.Location = new System.Drawing.Point(12, 301);
            this.TelaRelatorioCursos.Name = "TelaRelatorioCursos";
            this.TelaRelatorioCursos.Size = new System.Drawing.Size(192, 28);
            this.TelaRelatorioCursos.TabIndex = 6;
            this.TelaRelatorioCursos.TabStop = true;
            this.TelaRelatorioCursos.Text = "RELATÓRIO CURSOS";
            this.TelaRelatorioCursos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelaRelatorioCursos_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnSAIR);
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 76);
            this.panel2.TabIndex = 7;
            // 
            // btnSAIR
            // 
            this.btnSAIR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSAIR.Location = new System.Drawing.Point(694, 22);
            this.btnSAIR.Name = "btnSAIR";
            this.btnSAIR.Size = new System.Drawing.Size(94, 29);
            this.btnSAIR.TabIndex = 0;
            this.btnSAIR.Text = "SAIR";
            this.btnSAIR.UseVisualStyleBackColor = false;
            this.btnSAIR.Click += new System.EventHandler(this.btnSAIR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TelaRelatorioCursos);
            this.Controls.Add(this.TelaRelatorioAlunos);
            this.Controls.Add(this.TelaPesquisaCursos);
            this.Controls.Add(this.TelaPesquisaAlunos);
            this.Controls.Add(this.TelaCadastraCursos);
            this.Controls.Add(this.TelaCadastraAluno);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ESCOLA PROFISSIONALIZANTE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel TelaCadastraAluno;
        private System.Windows.Forms.LinkLabel TelaCadastraCursos;
        private System.Windows.Forms.LinkLabel TelaPesquisaAlunos;
        private System.Windows.Forms.LinkLabel TelaPesquisaCursos;
        private System.Windows.Forms.LinkLabel TelaRelatorioAlunos;
        private System.Windows.Forms.LinkLabel TelaRelatorioCursos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSAIR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

