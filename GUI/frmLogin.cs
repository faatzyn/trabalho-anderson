using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public string Usuario { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = Criptografia.GetMD5Hash(txtSenha.Text);
            FuncionarioDAL fDal = new FuncionarioDAL();
            

            if (fDal.AutenticarFuncionario(usuario, senha))
            {
                Usuario = usuario;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos.");
            }
        }
    }
}
