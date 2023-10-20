using WinFormsApp.Controllers;
using WinFormsApp.Entidades;

namespace WinFormsApp.Views
{
    public partial class frmCadastroCidade : Form
    {
        public frmCadastroCidade()
        {
            InitializeComponent();
        }

        CidadeController controllerCidade = new CidadeController();
        string tipoAcao = "Nome";
        int codigoCidade = 0;

        private void frmCadastroCidade_Load(object sender, EventArgs e)
        {
            CarregaGridCidades();
        }

        private void CarregaGridCidades()
        {
            try
            {
                gridCidades.DataSource = controllerCidade.CarregaGridCidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao carregar os dados do Formulário  {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncluirCidade();
        }

        private void IncluirCidade()
        {
            tipoAcao = "Insert";
            tabPrincipal.SelectedTab = tabCadastro;
            txtCodigo.Text = Convert.ToString(controllerCidade.RetornaProximoId());
            txtDescricao.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cidades c = new Cidades();
       //     c.id = Convert.ToInt32(txtCodigo.Text); //não enviar campos identity
            c.nome = txtDescricao.Text.Trim();

            bool inseridoComSucesso;

            if (tipoAcao == "Insert")
            {
                inseridoComSucesso = controllerCidade.AddCidade(c);
            }
            else
            {
                inseridoComSucesso = controllerCidade.EditCidade(c);
            }

            if (inseridoComSucesso)
            {
                MessageBox.Show($"Registro inserido com sucesso");
                gridCidades.DataSource = controllerCidade.CarregaGridCidades();
                tabPrincipal.SelectedTab = tabConsulta;
                LimparEdits();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparEdits();
            tabPrincipal.SelectedTab = tabConsulta;
        }

        private void LimparEdits()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarCidade();
        }

        private void EditarCidade()
        {
            var cidade = controllerCidade.buscaCidade(codigoCidade);
            tipoAcao = "Edit";

            if (cidade != null)
            {
                foreach (var c2 in cidade)
                {
                    txtCodigo.Text = Convert.ToString(c2.id);
                    txtDescricao.Text = c2.nome;
                }

                tabPrincipal.SelectedTab = tabCadastro;

            }
            else
            {
                MessageBox.Show($"Cidade não encontrada.");
            }
        }
        private void gridCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigoCidade = Convert.ToInt32(gridCidades.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja Excluir o Registro ",
                                   "Atenção",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool registroFoiExcluido = controllerCidade.DeleteCidade(codigoCidade);

                if (registroFoiExcluido)
                {
                    MessageBox.Show("Registro foi alterado com sucesso.");
                    gridCidades.DataSource =  controllerCidade.CarregaGridCidades();
                }
                else
                {
                    MessageBox.Show("Falha ao Excluir o registro.");
                }
            }

        }
    }
}
