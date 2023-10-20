using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LayoutPrincipal.View;

namespace LayoutPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            MenuVertical.Width = 68;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbreMenuVertical();
        }

        private void AbreMenuVertical()
        {
            if (MenuVertical.Width == 68)
            {
                MenuVertical.Width = 236;
            }
            else
            {
                MenuVertical.Width = 68;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconMaximizar.Visible = false;
            IconRestaurar.Visible = true;


        }

        private void IconFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja abandonar a aplicação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PainelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarradeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPessoas());
        }

        private void AbrirFormulario(object form)
        {
            if(MenuVertical.Width == 68)
            {
              return;
            }
            if (this.PainelConteudo.Controls.Count > 0)
                this.PainelConteudo.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PainelConteudo.Controls.Add(fh);
            this.PainelConteudo.Tag = fh;
            fh.Show();
        }
    }
}