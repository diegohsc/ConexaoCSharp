using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayoutPrincipal.BDContexto;
using LayoutPrincipal.Entidades;

namespace LayoutPrincipal.View
{
    public partial class frmPessoas : Form
    {
        string tipoAcao = "";
        int codigoPessoa;
        public frmPessoas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            var contexto = new DBContexto();
            var contatos = contexto.Pessoa.ToList();

            gridPessoas.DataSource = contatos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoAcao = "Insert";
            tabPrincipal.SelectedTab = tabCadastro;
            txtCodigo.Text = Convert.ToString(RetornaProximoId());
            txtNome.Focus();

        }

        private int RetornaProximoId()
        {
            try
            {
                DBContexto bd = new DBContexto();
                int proximoRegistro = bd.Pessoa.OrderBy(p => p.id).Select(p => p.id).LastOrDefault();

                return proximoRegistro + 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao Retornar o Ultimo Registro Selecionado. Falha: {ex.Message}");
            }

            return 0;
        }

        private void LimparEdits()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            // txtNascimento1.Text = string.Empty;
            txtCidade.Text = string.Empty;
            dataNascimento.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            // p.id = Convert.ToInt32(txtCodigo.Text); // a chave é autoincremento, não pode enviar no objeto.
            p.nome = txtNome.Text;
            p.cidade = txtCidade.Text;
            p.nascimento = dataNascimento.Value;

            var db = new DBContexto();

            if (tipoAcao == "Insert")
            {
                db.Pessoa.Add(p);
                db.SaveChanges();
                LimparEdits();
                tabPrincipal.SelectedTab = tabConsulta;
                MessageBox.Show("Registro salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAcao == "Edit")
            {
                var registro = db.Pessoa.Find(codigoPessoa);
                if (registro != null)
                {
                    registro.nome = p.nome;
                    registro.cidade = p.cidade;
                    registro.nascimento = p.nascimento;

                    db.SaveChanges();
                    MessageBox.Show("Registro salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparEdits();
                    tabPrincipal.SelectedTab = tabConsulta;

                }
            }

            CarregaGridPessoas();

        }

        private void gridPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigoPessoa = Convert.ToInt32(gridPessoas.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void CarregaGridPessoas()
        {
            try
            {
                var db = new DBContexto();
                var contatos = db.Pessoa.ToList();

                gridPessoas.DataSource = contatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
