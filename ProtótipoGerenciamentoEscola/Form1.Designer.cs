namespace ProtótipoGerenciamentoEscola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            pbFechar = new PictureBox();
            txtNome = new TextBox();
            txtNacionalidade = new TextBox();
            checkDeficiencia = new CheckBox();
            mtxtNascimento = new MaskedTextBox();
            mtxtCPF = new MaskedTextBox();
            mtxtSUS = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMatricula = new TextBox();
            txtDTMatricula = new TextBox();
            txtValMatricula = new TextBox();
            cbTurmas = new ComboBox();
            label6 = new Label();
            pbFotoAluno = new PictureBox();
            btnCadastro = new Button();
            btnTelaAluno = new Button();
            btnTelaResponsaveis = new Button();
            btnTelaEndContato = new Button();
            btnTurmas = new Button();
            button3 = new Button();
            btnFichaCadastral = new Button();
            dgvAlunos = new DataGridView();
            BtnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoAluno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // pbFechar
            // 
            pbFechar.BackColor = Color.Transparent;
            pbFechar.BackgroundImageLayout = ImageLayout.None;
            pbFechar.Image = (Image)resources.GetObject("pbFechar.Image");
            pbFechar.Location = new Point(890, 0);
            pbFechar.Name = "pbFechar";
            pbFechar.Size = new Size(70, 39);
            pbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbFechar.TabIndex = 1;
            pbFechar.TabStop = false;
            pbFechar.Click += pbFechar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(180, 118);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(298, 30);
            txtNome.TabIndex = 2;
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNacionalidade.ForeColor = Color.Black;
            txtNacionalidade.Location = new Point(180, 190);
            txtNacionalidade.Multiline = true;
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(189, 30);
            txtNacionalidade.TabIndex = 4;
            // 
            // checkDeficiencia
            // 
            checkDeficiencia.AutoSize = true;
            checkDeficiencia.Location = new Point(208, 308);
            checkDeficiencia.Name = "checkDeficiencia";
            checkDeficiencia.Size = new Size(46, 19);
            checkDeficiencia.TabIndex = 7;
            checkDeficiencia.Text = "Sim";
            checkDeficiencia.UseVisualStyleBackColor = true;
            // 
            // mtxtNascimento
            // 
            mtxtNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtNascimento.ForeColor = SystemColors.WindowText;
            mtxtNascimento.Location = new Point(180, 158);
            mtxtNascimento.Mask = "00/00/0000";
            mtxtNascimento.Name = "mtxtNascimento";
            mtxtNascimento.Size = new Size(129, 29);
            mtxtNascimento.TabIndex = 8;
            mtxtNascimento.ValidatingType = typeof(DateTime);
            // 
            // mtxtCPF
            // 
            mtxtCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtCPF.Location = new Point(179, 224);
            mtxtCPF.Mask = "000.000.000-00";
            mtxtCPF.Name = "mtxtCPF";
            mtxtCPF.Size = new Size(180, 29);
            mtxtCPF.TabIndex = 9;
            // 
            // mtxtSUS
            // 
            mtxtSUS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtSUS.Location = new Point(179, 263);
            mtxtSUS.Mask = "0000.0000.0000.000";
            mtxtSUS.Name = "mtxtSUS";
            mtxtSUS.Size = new Size(180, 29);
            mtxtSUS.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(372, 190);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 11;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(360, 226);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 12;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(360, 266);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 13;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(310, 158);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 14;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(478, 118);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 15;
            label5.Text = "*";
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.ForeColor = Color.Black;
            txtMatricula.Location = new Point(502, 128);
            txtMatricula.Multiline = true;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(182, 30);
            txtMatricula.TabIndex = 16;
            // 
            // txtDTMatricula
            // 
            txtDTMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDTMatricula.ForeColor = Color.Black;
            txtDTMatricula.Location = new Point(502, 248);
            txtDTMatricula.Multiline = true;
            txtDTMatricula.Name = "txtDTMatricula";
            txtDTMatricula.ReadOnly = true;
            txtDTMatricula.Size = new Size(182, 30);
            txtDTMatricula.TabIndex = 18;
            // 
            // txtValMatricula
            // 
            txtValMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValMatricula.ForeColor = Color.Black;
            txtValMatricula.Location = new Point(502, 312);
            txtValMatricula.Multiline = true;
            txtValMatricula.Name = "txtValMatricula";
            txtValMatricula.ReadOnly = true;
            txtValMatricula.Size = new Size(182, 30);
            txtValMatricula.TabIndex = 19;
            // 
            // cbTurmas
            // 
            cbTurmas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTurmas.FormattingEnabled = true;
            cbTurmas.Location = new Point(502, 181);
            cbTurmas.Name = "cbTurmas";
            cbTurmas.Size = new Size(182, 29);
            cbTurmas.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(687, 181);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 21;
            label6.Text = "*";
            // 
            // pbFotoAluno
            // 
            pbFotoAluno.Image = (Image)resources.GetObject("pbFotoAluno.Image");
            pbFotoAluno.Location = new Point(722, 160);
            pbFotoAluno.Name = "pbFotoAluno";
            pbFotoAluno.Size = new Size(172, 163);
            pbFotoAluno.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoAluno.TabIndex = 22;
            pbFotoAluno.TabStop = false;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Transparent;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCadastro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.ForeColor = Color.Transparent;
            btnCadastro.Location = new Point(27, 343);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(189, 32);
            btnCadastro.TabIndex = 25;
            btnCadastro.TabStop = false;
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnTelaAluno
            // 
            btnTelaAluno.BackColor = Color.Transparent;
            btnTelaAluno.FlatAppearance.BorderSize = 0;
            btnTelaAluno.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTelaAluno.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTelaAluno.FlatStyle = FlatStyle.Flat;
            btnTelaAluno.ForeColor = Color.Transparent;
            btnTelaAluno.Location = new Point(283, 72);
            btnTelaAluno.Name = "btnTelaAluno";
            btnTelaAluno.Size = new Size(69, 24);
            btnTelaAluno.TabIndex = 26;
            btnTelaAluno.TabStop = false;
            btnTelaAluno.UseVisualStyleBackColor = false;
            btnTelaAluno.Click += btnTelaAluno_Click;
            // 
            // btnTelaResponsaveis
            // 
            btnTelaResponsaveis.BackColor = Color.Transparent;
            btnTelaResponsaveis.FlatAppearance.BorderSize = 0;
            btnTelaResponsaveis.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTelaResponsaveis.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTelaResponsaveis.FlatStyle = FlatStyle.Flat;
            btnTelaResponsaveis.ForeColor = Color.Transparent;
            btnTelaResponsaveis.Location = new Point(356, 72);
            btnTelaResponsaveis.Name = "btnTelaResponsaveis";
            btnTelaResponsaveis.Size = new Size(128, 24);
            btnTelaResponsaveis.TabIndex = 27;
            btnTelaResponsaveis.TabStop = false;
            btnTelaResponsaveis.UseVisualStyleBackColor = false;
            btnTelaResponsaveis.Click += btnTelaResponsaveis_Click;
            // 
            // btnTelaEndContato
            // 
            btnTelaEndContato.BackColor = Color.Transparent;
            btnTelaEndContato.FlatAppearance.BorderSize = 0;
            btnTelaEndContato.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTelaEndContato.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTelaEndContato.FlatStyle = FlatStyle.Flat;
            btnTelaEndContato.ForeColor = Color.Transparent;
            btnTelaEndContato.Location = new Point(490, 72);
            btnTelaEndContato.Name = "btnTelaEndContato";
            btnTelaEndContato.Size = new Size(181, 24);
            btnTelaEndContato.TabIndex = 28;
            btnTelaEndContato.TabStop = false;
            btnTelaEndContato.UseVisualStyleBackColor = false;
            btnTelaEndContato.Click += btnTelaEndContato_Click;
            // 
            // btnTurmas
            // 
            btnTurmas.BackColor = Color.Transparent;
            btnTurmas.FlatAppearance.BorderSize = 0;
            btnTurmas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTurmas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTurmas.FlatStyle = FlatStyle.Flat;
            btnTurmas.ForeColor = Color.Transparent;
            btnTurmas.Location = new Point(12, 41);
            btnTurmas.Name = "btnTurmas";
            btnTurmas.Size = new Size(125, 24);
            btnTurmas.TabIndex = 29;
            btnTurmas.TabStop = false;
            btnTurmas.UseVisualStyleBackColor = false;
            btnTurmas.Click += btnTurmas_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(372, 41);
            button3.Name = "button3";
            button3.Size = new Size(142, 24);
            button3.TabIndex = 30;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnFichaCadastral
            // 
            btnFichaCadastral.BackColor = Color.Transparent;
            btnFichaCadastral.FlatAppearance.BorderSize = 0;
            btnFichaCadastral.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFichaCadastral.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFichaCadastral.FlatStyle = FlatStyle.Flat;
            btnFichaCadastral.ForeColor = Color.Transparent;
            btnFichaCadastral.Location = new Point(356, 41);
            btnFichaCadastral.Name = "btnFichaCadastral";
            btnFichaCadastral.Size = new Size(169, 24);
            btnFichaCadastral.TabIndex = 31;
            btnFichaCadastral.TabStop = false;
            btnFichaCadastral.UseVisualStyleBackColor = false;
            btnFichaCadastral.Click += btnFichaCadastral_Click;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(14, 398);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(913, 139);
            dgvAlunos.TabIndex = 32;
            // 
            // BtnListar
            // 
            BtnListar.BackColor = Color.Transparent;
            BtnListar.FlatAppearance.BorderSize = 0;
            BtnListar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnListar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnListar.FlatStyle = FlatStyle.Flat;
            BtnListar.ForeColor = Color.Transparent;
            BtnListar.Location = new Point(241, 343);
            BtnListar.Name = "BtnListar";
            BtnListar.Size = new Size(189, 32);
            BtnListar.TabIndex = 33;
            BtnListar.TabStop = false;
            BtnListar.UseVisualStyleBackColor = false;
            BtnListar.Click += button1_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(BtnListar);
            Controls.Add(dgvAlunos);
            Controls.Add(btnFichaCadastral);
            Controls.Add(button3);
            Controls.Add(btnTurmas);
            Controls.Add(btnTelaEndContato);
            Controls.Add(btnTelaResponsaveis);
            Controls.Add(btnTelaAluno);
            Controls.Add(btnCadastro);
            Controls.Add(pbFotoAluno);
            Controls.Add(label6);
            Controls.Add(cbTurmas);
            Controls.Add(txtValMatricula);
            Controls.Add(txtDTMatricula);
            Controls.Add(txtMatricula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtxtSUS);
            Controls.Add(mtxtCPF);
            Controls.Add(mtxtNascimento);
            Controls.Add(checkDeficiencia);
            Controls.Add(txtNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(pbFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoAluno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbFechar;
        private TextBox txtNome;
        private TextBox txtNacionalidade;
        private CheckBox checkDeficiencia;
        private MaskedTextBox mtxtNascimento;
        private MaskedTextBox mtxtCPF;
        private MaskedTextBox mtxtSUS;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMatricula;
        private TextBox txtDTMatricula;
        private TextBox txtValMatricula;
        private ComboBox cbTurmas;
        private Label label6;
        private PictureBox pbFotoAluno;
        private Button btnCadastro;
        private Button btnTelaAluno;
        private Button btnTelaResponsaveis;
        private Button btnTelaEndContato;
        private Button btnTurmas;
        private Button button3;
        private Button btnFichaCadastral;
        private DataGridView dgvAlunos;
        private Button BtnListar;
    }
}
