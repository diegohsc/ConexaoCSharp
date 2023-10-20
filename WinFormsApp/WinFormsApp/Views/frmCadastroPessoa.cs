using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DBContext;
using WinFormsApp.Entidades;

namespace WinFormsApp.Views
{
    public partial class frmCadastroPessoa : Form
    {
        private string tipoAcao = "None";
        private int codigoPessoa = 0;

        public frmCadastroPessoa()
        {
            InitializeComponent();
            //this.KeyPreview = true;
        }
        private void LimparEdits()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNascimento1.Text = string.Empty;
            txtCidade.Text = string.Empty;
            dataNascimento.Text = string.Empty;
        }
        private void frmCadastroPessoa_Load(object sender, EventArgs e)
        {
            CarregaGridPessoas();
            gridPessoas.Columns[0].HeaderText = "Código";
            gridPessoas.Columns[1].HeaderText = "Nome";
            gridPessoas.Columns[2].HeaderText = "Cidade";
            gridPessoas.Columns[3].HeaderText = "Data de Nascimento";

            string hoje = DateTime.Now.ToString("dd/MM/yyyy");
            dataNascimento.Text = hoje;
        }

        private int RetornaProximoId()
        {
            try
            {
                BDContexto bd = new BDContexto();
                int proximoRegistro = bd.Pessoa.OrderBy(p => p.id).Select(p => p.id).LastOrDefault();

                return proximoRegistro + 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao Retornar o Ultimo Registro Selecionado. Falha: {ex.Message}");
            }

            return 0;
        }

        private void CarregaGridPessoas()
        {
            try
            {
                var db = new BDContexto();
                var contatos = db.Pessoa.ToList();

                gridPessoas.DataSource = contatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoAcao = "Insert";
            tabPrincipal.SelectedTab = tabCadastro;
            txtCodigo.Text = Convert.ToString(RetornaProximoId());
            txtNome.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            // p.id = Convert.ToInt32(txtCodigo.Text); // a chave é autoincremento, não pode enviar no objeto.
            p.nome = txtNome.Text;
            p.cidade = txtCidade.Text;
            //   p.nascimento = Convert.ToDateTime(txtNascimento1.Text);
            p.nascimento = dataNascimento.Value;

            var db = new BDContexto();

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

        }

        private void tabPrincipal_CursorChanged(object sender, EventArgs e)
        {

        }

        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPrincipal.SelectedTab == tabConsulta)
            {
                CarregaGridPessoas();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoAcao = "Edit";
            if (BuscaPessoaPorId(codigoPessoa))
            {
                tabPrincipal.SelectedTab = tabCadastro;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private bool BuscaPessoaPorId(int codigoPessoa)
        {
            BDContexto bd = new BDContexto();
            var pessoaSelecionada = bd.Pessoa.Where(p => p.id == codigoPessoa).ToList();

            if (pessoaSelecionada.Count() > 0)
            {
                foreach (var item in pessoaSelecionada)
                {
                    txtCodigo.Text = item.id.ToString();
                    txtNome.Text = item.nome;
                    txtCidade.Text = item.cidade;
                    //   txtNascimento1.Text = Convert.ToString(item.nascimento);
                    dataNascimento.Text = Convert.ToString(item.nascimento);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void gridPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigoPessoa = Convert.ToInt32(gridPessoas.Rows[e.RowIndex].Cells[0].Value);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimparEdits();
            tabPrincipal.SelectedTab = tabConsulta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BDContexto bd = new BDContexto();
            var codigoExcluir = bd.Pessoa.Find(codigoPessoa);

            if (codigoExcluir != null)
            {
                if (MessageBox.Show($"Deseja Excluir o Registro {codigoExcluir.nome}",
                                    "Atenção",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bd.Pessoa.Remove(codigoExcluir);
                    bd.SaveChanges();

                    MessageBox.Show("Registro removido com sucesso.");
                    CarregaGridPessoas();

                }
            }
        }

        private void frmCadastroPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 13))
            {
                //  this.SelectNextControl((Control)sender, true, true, true, true);
                SendKeys.Send("{TAB}");
            }
        }
    }
}
