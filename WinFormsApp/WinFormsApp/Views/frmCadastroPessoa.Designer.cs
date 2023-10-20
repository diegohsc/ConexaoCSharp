namespace WinFormsApp.Views
{
    partial class frmCadastroPessoa
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
            tabPrincipal = new TabControl();
            tabConsulta = new TabPage();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            gridPessoas = new DataGridView();
            tabCadastro = new TabPage();
            dataNascimento = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            txtNascimento1 = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            tabPrincipal.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPessoas).BeginInit();
            tabCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPrincipal
            // 
            tabPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPrincipal.Controls.Add(tabConsulta);
            tabPrincipal.Controls.Add(tabCadastro);
            tabPrincipal.Location = new Point(4, 2);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(579, 286);
            tabPrincipal.TabIndex = 0;
            tabPrincipal.SelectedIndexChanged += tabPrincipal_SelectedIndexChanged;
            tabPrincipal.CursorChanged += tabPrincipal_CursorChanged;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(button5);
            tabConsulta.Controls.Add(button2);
            tabConsulta.Controls.Add(button1);
            tabConsulta.Controls.Add(gridPessoas);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(571, 258);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "tabPage1";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(453, 212);
            button5.Name = "button5";
            button5.Size = new Size(110, 34);
            button5.TabIndex = 3;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(221, 212);
            button2.Name = "button2";
            button2.Size = new Size(110, 34);
            button2.TabIndex = 2;
            button2.Text = "Incluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(337, 212);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gridPessoas
            // 
            gridPessoas.AllowUserToAddRows = false;
            gridPessoas.AllowUserToDeleteRows = false;
            gridPessoas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPessoas.Location = new Point(3, 3);
            gridPessoas.Name = "gridPessoas";
            gridPessoas.ReadOnly = true;
            gridPessoas.RowTemplate.Height = 25;
            gridPessoas.Size = new Size(560, 203);
            gridPessoas.TabIndex = 0;
            gridPessoas.CellClick += gridPessoas_CellClick;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(dataNascimento);
            tabCadastro.Controls.Add(button3);
            tabCadastro.Controls.Add(button4);
            tabCadastro.Controls.Add(txtNascimento1);
            tabCadastro.Controls.Add(label4);
            tabCadastro.Controls.Add(txtCidade);
            tabCadastro.Controls.Add(label3);
            tabCadastro.Controls.Add(txtNome);
            tabCadastro.Controls.Add(label2);
            tabCadastro.Controls.Add(txtCodigo);
            tabCadastro.Controls.Add(label1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(571, 258);
            tabCadastro.TabIndex = 1;
            tabCadastro.Text = "tabPage2";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // dataNascimento
            // 
            dataNascimento.Format = DateTimePickerFormat.Short;
            dataNascimento.Location = new Point(84, 102);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(116, 23);
            dataNascimento.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(336, 218);
            button3.Name = "button3";
            button3.Size = new Size(110, 34);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(452, 218);
            button4.Name = "button4";
            button4.Size = new Size(110, 34);
            button4.TabIndex = 8;
            button4.Text = "Salvar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtNascimento1
            // 
            txtNascimento1.Location = new Point(7, 225);
            txtNascimento1.Name = "txtNascimento1";
            txtNascimento1.Size = new Size(102, 23);
            txtNascimento1.TabIndex = 7;
            txtNascimento1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 110);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Nascimento";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(84, 73);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(172, 23);
            txtCidade.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 81);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Cidade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 53);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(84, 15);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(57, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // frmCadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 291);
            Controls.Add(tabPrincipal);
            KeyPreview = true;
            Name = "frmCadastroPessoa";
            Text = "frmCadastroPessoa";
            Load += frmCadastroPessoa_Load;
            KeyPress += frmCadastroPessoa_KeyPress;
            tabPrincipal.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPessoas).EndInit();
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabConsulta;
        private TabPage tabCadastro;
        private DataGridView gridPessoas;
        private TextBox txtNascimento1;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private DateTimePicker dataNascimento;
        private Button button5;
    }
}