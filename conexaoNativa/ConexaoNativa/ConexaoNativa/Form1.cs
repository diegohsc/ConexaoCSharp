using ConexaoNativa.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoNativa
{
    public partial class Form1 : Form
    {
          //  persist security info=True; 
        string stringConnection = "Server=ds-01;Database=banco_teste_diego;User Id=sa;Password=dg@etd45H;";
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
        }

        private void PreecheFormulario(Estabelecimento estabelecimento)
        {
            txtNome.Text = estabelecimento.nome;
            txtLogradouro.Text = estabelecimento.logradouro;
            txtBairro.Text = estabelecimento.bairro;
            txtCidade.Text = estabelecimento.cidade;
        }

        private void CarregaDados()
        {
            try
            {
                string connectionString = stringConnection;
                SqlConnection sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM Estabelecimento ORDER BY  id", sqlConn);
                SqlDataReader dados = comando.ExecuteReader();

                listBox1.Items.Clear();
                while (dados.Read())
                {
                    listBox1.Items.Add($"Código: {dados[0]} -  Nome: {dados[1]}");
                }

                sqlConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao conectar no banco de dados. Erro: {ex.Message} ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaDados();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estabelecimento estabelecimento = new Estabelecimento();
            estabelecimento.Id = 0;
            estabelecimento.nome = txtNome.Text;
            estabelecimento.logradouro = txtLogradouro.Text;
            estabelecimento.bairro = txtBairro.Text;
            estabelecimento.cidade = txtCidade.Text;


            using(SqlConnection sqlConn = new SqlConnection(stringConnection)) { 
                
                sqlConn.Open(); 
                string sql = "INSERT INTO Estabelecimento (nome, logradouro , bairro, cidade)  "
                                                + "VALUES (@nome, @logradouro, @bairro, @cidade)";


                using (SqlCommand command = new SqlCommand(sql, sqlConn))
                {
                    // Adicione os parâmetros com seus valores
                    command.Parameters.AddWithValue("@nome", estabelecimento.nome );
                    command.Parameters.AddWithValue("@logradouro", estabelecimento.logradouro);
                    command.Parameters.AddWithValue("@bairro", estabelecimento.bairro );
                    command.Parameters.AddWithValue("@cidade", estabelecimento.cidade);

                    // Execute o comando
                    command.ExecuteNonQuery();
                }
                sqlConn.Close();
                MessageBox.Show("Registro Inserido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void tabControl1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                CarregaDados();
            }
        }

        private void tabControl1_ImeModeChanged(object sender, EventArgs e)
        {
 
        }
    }
}
