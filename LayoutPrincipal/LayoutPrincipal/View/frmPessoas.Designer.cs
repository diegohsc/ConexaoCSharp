namespace LayoutPrincipal.View
{
    partial class frmPessoas
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
            panel1 = new Panel();
            textBoxThega1 = new Components.TextBoxThega();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            gridPessoas = new DataGridView();
            tabCadastro = new TabPage();
            panel3 = new Panel();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            dataNascimento = new DateTimePicker();
            label4 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            tabPrincipal.SuspendLayout();
            tabConsulta.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPessoas).BeginInit();
            tabCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabConsulta);
            tabPrincipal.Controls.Add(tabCadastro);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(599, 269);
            tabPrincipal.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(panel1);
            tabConsulta.Controls.Add(gridPessoas);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(591, 241);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxThega1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 57);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // textBoxThega1
            // 
            textBoxThega1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxThega1.BackColor = Color.DeepPink;
            textBoxThega1.BackgroundColor = Color.DeepPink;
            textBoxThega1.BorderColor = Color.GreenYellow;
            textBoxThega1.BorderRadius = 10;
            textBoxThega1.BorderSize = 0;
            textBoxThega1.FlatAppearance.BorderSize = 0;
            textBoxThega1.FlatStyle = FlatStyle.Flat;
            textBoxThega1.ForeColor = Color.White;
            textBoxThega1.Location = new Point(69, 9);
            textBoxThega1.Name = "textBoxThega1";
            textBoxThega1.Size = new Size(150, 40);
            textBoxThega1.TabIndex = 7;
            textBoxThega1.Text = "textBoxThega1";
            textBoxThega1.TextColor = Color.White;
            textBoxThega1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Location = new Point(471, 12);
            button5.Name = "button5";
            button5.Size = new Size(110, 34);
            button5.TabIndex = 6;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(239, 12);
            button2.Name = "button2";
            button2.Size = new Size(110, 34);
            button2.TabIndex = 5;
            button2.Text = "Incluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(355, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 4;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // gridPessoas
            // 
            gridPessoas.AllowUserToAddRows = false;
            gridPessoas.AllowUserToDeleteRows = false;
            gridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPessoas.Dock = DockStyle.Fill;
            gridPessoas.Location = new Point(3, 3);
            gridPessoas.Name = "gridPessoas";
            gridPessoas.ReadOnly = true;
            gridPessoas.RowTemplate.Height = 25;
            gridPessoas.Size = new Size(585, 235);
            gridPessoas.TabIndex = 1;
            gridPessoas.CellClick += gridPessoas_CellClick;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(panel3);
            tabCadastro.Controls.Add(panel2);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(591, 241);
            tabCadastro.TabIndex = 1;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(585, 54);
            panel3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(368, 11);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 11;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(473, 11);
            button4.Name = "button4";
            button4.Size = new Size(107, 34);
            button4.TabIndex = 10;
            button4.Text = "Salvar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataNascimento);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtCidade);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 235);
            panel2.TabIndex = 0;
            // 
            // dataNascimento
            // 
            dataNascimento.Format = DateTimePickerFormat.Short;
            dataNascimento.Location = new Point(87, 99);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(116, 23);
            dataNascimento.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 107);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "Nascimento";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(87, 70);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(172, 23);
            txtCidade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 78);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Cidade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 50);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(87, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(57, 23);
            txtCodigo.TabIndex = 9;
            txtCodigo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // frmPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 269);
            Controls.Add(tabPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPessoas";
            Text = "frmPessoas";
            Load += frmPessoas_Load;
            tabPrincipal.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPessoas).EndInit();
            tabCadastro.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabConsulta;
        private TabPage tabCadastro;
        private Panel panel1;
        private Button button5;
        private Button button2;
        private Button button1;
        private DataGridView gridPessoas;
        private Panel panel3;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private DateTimePicker dataNascimento;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Components.TextBoxThega textBoxThega1;
    }
}