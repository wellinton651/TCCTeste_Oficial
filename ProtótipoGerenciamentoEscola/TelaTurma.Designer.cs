namespace ProtótipoGerenciamentoEscola
{
    partial class TelaTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTurma));
            pbFechar = new PictureBox();
            btnCadastro = new Button();
            btnLimpar = new Button();
            btnFichaCadastral = new Button();
            btnTurmas = new Button();
            btnTelaProfessor = new Button();
            dgvProfessores = new DataGridView();
            cbTurno = new ComboBox();
            txtTurma = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).BeginInit();
            SuspendLayout();
            // 
            // pbFechar
            // 
            pbFechar.Image = (Image)resources.GetObject("pbFechar.Image");
            pbFechar.Location = new Point(892, 0);
            pbFechar.Name = "pbFechar";
            pbFechar.Size = new Size(68, 38);
            pbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbFechar.TabIndex = 1;
            pbFechar.TabStop = false;
            pbFechar.Click += pbFechar_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Transparent;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCadastro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.ForeColor = Color.Transparent;
            btnCadastro.Location = new Point(297, 471);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(174, 32);
            btnCadastro.TabIndex = 26;
            btnCadastro.TabStop = false;
            btnCadastro.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.Transparent;
            btnLimpar.Location = new Point(493, 471);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(171, 32);
            btnLimpar.TabIndex = 27;
            btnLimpar.TabStop = false;
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnFichaCadastral
            // 
            btnFichaCadastral.BackColor = Color.Transparent;
            btnFichaCadastral.FlatAppearance.BorderSize = 0;
            btnFichaCadastral.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFichaCadastral.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFichaCadastral.FlatStyle = FlatStyle.Flat;
            btnFichaCadastral.ForeColor = Color.Transparent;
            btnFichaCadastral.Location = new Point(355, 41);
            btnFichaCadastral.Name = "btnFichaCadastral";
            btnFichaCadastral.Size = new Size(169, 24);
            btnFichaCadastral.TabIndex = 33;
            btnFichaCadastral.TabStop = false;
            btnFichaCadastral.UseVisualStyleBackColor = false;
            btnFichaCadastral.Click += btnFichaCadastral_Click;
            // 
            // btnTurmas
            // 
            btnTurmas.BackColor = Color.Transparent;
            btnTurmas.FlatAppearance.BorderSize = 0;
            btnTurmas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTurmas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTurmas.FlatStyle = FlatStyle.Flat;
            btnTurmas.ForeColor = Color.Transparent;
            btnTurmas.Location = new Point(11, 41);
            btnTurmas.Name = "btnTurmas";
            btnTurmas.Size = new Size(125, 24);
            btnTurmas.TabIndex = 32;
            btnTurmas.TabStop = false;
            btnTurmas.UseVisualStyleBackColor = false;
            // 
            // btnTelaProfessor
            // 
            btnTelaProfessor.BackColor = Color.Transparent;
            btnTelaProfessor.FlatAppearance.BorderSize = 0;
            btnTelaProfessor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTelaProfessor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTelaProfessor.FlatStyle = FlatStyle.Flat;
            btnTelaProfessor.ForeColor = Color.Transparent;
            btnTelaProfessor.Location = new Point(691, 471);
            btnTelaProfessor.Name = "btnTelaProfessor";
            btnTelaProfessor.Size = new Size(171, 32);
            btnTelaProfessor.TabIndex = 34;
            btnTelaProfessor.TabStop = false;
            btnTelaProfessor.UseVisualStyleBackColor = false;
            btnTelaProfessor.Click += btnTelaProfessor_Click;
            // 
            // dgvProfessores
            // 
            dgvProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessores.Location = new Point(355, 133);
            dgvProfessores.Name = "dgvProfessores";
            dgvProfessores.Size = new Size(507, 274);
            dgvProfessores.TabIndex = 36;
            // 
            // cbTurno
            // 
            cbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTurno.FormattingEnabled = true;
            cbTurno.Location = new Point(101, 143);
            cbTurno.Name = "cbTurno";
            cbTurno.Size = new Size(120, 29);
            cbTurno.TabIndex = 38;
            // 
            // txtTurma
            // 
            txtTurma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTurma.ForeColor = Color.Black;
            txtTurma.Location = new Point(101, 103);
            txtTurma.Multiline = true;
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(120, 30);
            txtTurma.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 218);
            label1.Name = "label1";
            label1.Size = new Size(90, 285);
            label1.TabIndex = 40;
            label1.Text = "Português\n\nMatemática\n\nFísica\n\nQuímica\n\nBiologia\n\nHistória\n\nGeografia\n\nInglês\n\nEducação Física\n\nArtes ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(218, 143);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 41;
            label2.Text = "*";
            // 
            // TelaTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTurma);
            Controls.Add(cbTurno);
            Controls.Add(dgvProfessores);
            Controls.Add(btnTelaProfessor);
            Controls.Add(btnFichaCadastral);
            Controls.Add(btnTurmas);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastro);
            Controls.Add(pbFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaTurma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaTurma";
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbFechar;
        private Button btnCadastro;
        private Button btnLimpar;
        private Button btnFichaCadastral;
        private Button btnTurmas;
        private Button btnTelaProfessor;
        private DataGridView dgvProfessores;
        private ComboBox cbTurno;
        private TextBox txtTurma;
        private Label label1;
        private Label label2;
    }
}