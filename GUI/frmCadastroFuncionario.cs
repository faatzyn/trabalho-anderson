using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace GUI
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            dtNascimento.Value = DateTime.Now;
            cbSexo.Text = string.Empty;
            cbEstadoCivil.Text = string.Empty;
            txtRG.Clear();
            txtCPF.Clear();
            txtEndereço.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            cbEstados.Text = string.Empty;
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtDsLogin.Clear();
            txtDsSenha.Clear();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            objFuncionario.NmFuncionario = txtNome.Text;
            objFuncionario.DtNasc = dtNascimento.Value;
            switch (cbSexo.Text)
            {
                case "Masculino":
                    objFuncionario.DsSexo = 'M';
                    break;
                case "Feminino":
                    objFuncionario.DsSexo = 'F';
                    break;
                default:
                    objFuncionario.DsSexo = 'O';
                    break;
            }
            switch (cbEstadoCivil.Text)
            {
                case "Solteiro(a)":
                    objFuncionario.DsEstadoCivil = 'S';
                    break;
                case "Casado(a)":
                    objFuncionario.DsEstadoCivil = 'C';
                    break;
                default:
                    objFuncionario.DsEstadoCivil = 'V';
                    break;
            }
            objFuncionario.RG = txtRG.Text;
            objFuncionario.CPF = txtCPF.Text;
            objFuncionario.Endereco = txtEndereço.Text;
            objFuncionario.Cidade = txtCidade.Text;
            objFuncionario.CEP = txtCEP.Text;
            objFuncionario.Estado = cbEstados.Text;
            objFuncionario.Telefone = txtTelefone.Text;
            objFuncionario.Celular = txtCelular.Text;
            objFuncionario.Email = txtEmail.Text;
            objFuncionario.DsLogin = txtDsLogin.Text;
            objFuncionario.DsSenha = Criptografia.GetMD5Hash(txtDsSenha.Text);
            objFuncionario.Status = false;

            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            funcionarioDAL.InserirFuncionario(objFuncionario);
            MessageBox.Show("Funcionário criado com sucesso.");
            LimparCampos();
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            dgvFuncionarios.DataSource = funcionarioDAL.Carregar();
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdFuncionario = Convert.ToInt32(txtBuscar.Text);
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            Funcionario funcionario = funcionarioDAL.Buscar(cdFuncionario);

            if (funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrada");
            }
            else
            {
                txtNome.Text = funcionario.NmFuncionario;
                txtEmail.Text = funcionario.Email;
                switch (funcionario.DsEstadoCivil)
                {
                    case 'S':
                        cbEstadoCivil.Text = "Solteiro(a)";
                        break;
                    case 'C':
                        cbEstadoCivil.Text = "Casado(a)";
                        break;
                    default:
                        cbEstadoCivil.Text = "Divorciado(a)";
                        break;
                }
                txtRG.Text = funcionario.RG;
                txtCPF.Text = funcionario.CPF;
                txtEndereço.Text = funcionario.Endereco;
                cbEstados.Text = funcionario.Estado;
                txtCidade.Text = funcionario.Cidade;
                txtCEP.Text = funcionario.CEP;
                txtDsLogin.Text = funcionario.DsLogin;
                switch (funcionario.DsSexo)
                {
                    case 'M':
                        cbSexo.Text = "Masculino";
                        break;
                    case 'F':
                        cbSexo.Text = "Feminino";
                        break;
                    default:
                        cbSexo.Text = "Outro";
                        break;
                }
                txtCelular.Text = funcionario.Celular;
                txtTelefone.Text = funcionario.Telefone;
                dtNascimento.Value = funcionario.DtNasc;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdFuncionario = Convert.ToInt32(txtBuscar.Text);
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            MessageBox.Show(funcionarioDAL.ExcluirCadastro(cdFuncionario));
            CarregarFuncionarios();
            LimparCampos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int cdFuncionario = Convert.ToInt32(txtBuscar.Text);
            Funcionario objFuncionario = new Funcionario();
            objFuncionario.CdFuncionario = cdFuncionario;
            objFuncionario.NmFuncionario = txtNome.Text;
            objFuncionario.DtNasc = dtNascimento.Value;
            switch (cbSexo.Text)
            {
                case "Masculino":
                    objFuncionario.DsSexo = 'M';
                    break;
                case "Feminino":
                    objFuncionario.DsSexo = 'F';
                    break;
                default:
                    objFuncionario.DsSexo = 'O';
                    break;
            }
            switch (cbEstadoCivil.Text)
            {
                case "Solteiro(a)":
                    objFuncionario.DsEstadoCivil = 'S';
                    break;
                case "Casado(a)":
                    objFuncionario.DsEstadoCivil = 'C';
                    break;
                default:
                    objFuncionario.DsEstadoCivil = 'V';
                    break;
            }
            objFuncionario.RG = txtRG.Text;
            objFuncionario.CPF = txtCPF.Text;
            objFuncionario.Endereco = txtEndereço.Text;
            objFuncionario.Cidade = txtCidade.Text;
            objFuncionario.CEP = txtCEP.Text;
            objFuncionario.Estado = cbEstados.Text;
            objFuncionario.Telefone = txtTelefone.Text;
            objFuncionario.Celular = txtCelular.Text;
            objFuncionario.Email = txtEmail.Text;
            objFuncionario.DsLogin = txtDsLogin.Text;

            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
            funcionarioDAL.Atualizar(cdFuncionario, objFuncionario);
            MessageBox.Show("Atualizado com sucesso.");
            LimparCampos();
            CarregarFuncionarios();
        }
    }
}
