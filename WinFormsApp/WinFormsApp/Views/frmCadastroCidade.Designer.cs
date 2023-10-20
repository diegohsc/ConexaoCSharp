namespace WinFormsApp.Views
{
    partial class frmCadastroCidade
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
            gridCidades = new DataGridView();
            tabCadastro = new TabPage();
            button4 = new Button();
            button6 = new Button();
            txtDescricao = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            tabPrincipal.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCidades).BeginInit();
            tabCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabConsulta);
            tabPrincipal.Controls.Add(tabCadastro);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Margin = new Padding(10);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(541, 273);
            tabPrincipal.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(button5);
            tabConsulta.Controls.Add(button2);
            tabConsulta.Controls.Add(button1);
            tabConsulta.Controls.Add(gridCidades);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(533, 245);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.Location = new Point(417, 203);
            button5.Name = "button5";
            button5.Size = new Size(110, 34);
            button5.TabIndex = 6;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(185, 203);
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
            button1.Location = new Point(301, 203);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 4;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gridCidades
            // 
            gridCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCidades.Dock = DockStyle.Top;
            gridCidades.Location = new Point(3, 3);
            gridCidades.Name = "gridCidades";
            gridCidades.RowTemplate.Height = 25;
            gridCidades.Size = new Size(527, 194);
            gridCidades.TabIndex = 0;
            gridCidades.CellClick += gridCidades_CellClick;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(button4);
            tabCadastro.Controls.Add(button6);
            tabCadastro.Controls.Add(txtDescricao);
            tabCadastro.Controls.Add(label2);
            tabCadastro.Controls.Add(label1);
            tabCadastro.Controls.Add(txtCodigo);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(533, 245);
            tabCadastro.TabIndex = 1;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(301, 203);
            button4.Name = "button4";
            button4.Size = new Size(110, 34);
            button4.TabIndex = 11;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Location = new Point(417, 203);
            button6.Name = "button6";
            button6.Size = new Size(110, 34);
            button6.TabIndex = 10;
            button6.Text = "Salvar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(76, 48);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(255, 23);
            txtDescricao.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(76, 18);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // frmCadastroCidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 273);
            Controls.Add(tabPrincipal);
            Name = "frmCadastroCidade";
            Text = "frmCadastroCidade";
            Load += frmCadastroCidade_Load;
            tabPrincipal.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCidades).EndInit();
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabConsulta;
        private TabPage tabCadastro;
        private DataGridView gridCidades;
        private Button button5;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private Button button4;
        private Button button6;
    }
}