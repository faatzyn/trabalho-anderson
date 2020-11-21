using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            tela.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente tela = new frmCliente();
            tela.Show();
        }

        private void novoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem tela = new frmItem();
            tela.Show();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            tela.Show();
        }

        private void procurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            if (login.ShowDialog() == DialogResult.OK && login.Usuario == "admin")
            {
                frmPermitirLogin tela = new frmPermitirLogin();
                tela.Show();
            }
            else
            {
                MessageBox.Show("Acesso não permitido.");
            }

        }
    }
}
