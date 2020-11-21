using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmPermitirLogin : Form
    {        
        public frmPermitirLogin()
        {
            InitializeComponent();
            dgvFuncionarios.AutoGenerateColumns = false;
        }

        public void LimparCampos()
        {
            txtCdFuncionario.Clear();
        }
        private void CarregarFuncionarios()
        {
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            dgvFuncionarios.DataSource = funcionarioDAL.Carregar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdFuncionario = Convert.ToInt32(txtCdFuncionario.Text);
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            bool status;
            Funcionario funcionario = funcionarioDAL.Buscar(cdFuncionario);

            if (funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrada");
            }
            else
            {
                switch (funcionario.Status)
                {
                    case false:
                        status = true;
                        break;
                    default:
                        status = false;
                        break;
                }
                funcionario.Status = status;
            }
            funcionarioDAL.PermitirLogin(cdFuncionario, funcionario);
            MessageBox.Show("Permissão concedida.");
            LimparCampos();
            CarregarFuncionarios();
        }

        private void frmPermitirLogin_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }
    }
}
