using Microsoft.EntityFrameworkCore;
using System.DirectoryServices.ActiveDirectory;
using WinFormsApp.DBContext;
using WinFormsApp.Views;

namespace WinFormsApp
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   try
               {
                   var db = new BDContexto();
                   var contatos = db.Pessoa.Where(p => p.id > 0).ToList();

                   foreach (var item in contatos)
                   {
                       MessageBox.Show(item.nome);
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }*/


        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa form = new frmCadastroPessoa();
            form.ShowDialog();
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            frmCadastroCidade form = new frmCadastroCidade();
            form.ShowDialog();
        }
    }
}