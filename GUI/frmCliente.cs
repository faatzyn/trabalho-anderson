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
    public partial class frmCliente : Form
    {
        public frmCliente()
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
            cbEstado.Text = string.Empty;
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
        }
        private void CarregarCliente()
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            dgvCliente.DataSource = clienteDAL.Carregar();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.NmCliente = txtNome.Text;
            cliente.DtNasc = dtNascimento.Value;
            switch (cbSexo.Text)
            {
                case "Masculino":
                    cliente.DsSexo = 'M';
                    break;
                case "Feminino":
                    cliente.DsSexo = 'F';
                    break;
                default:
                    cliente.DsSexo = 'O';
                    break;
            }
            switch (cbEstadoCivil.Text)
            {
                case "Solteiro(a)":
                    cliente.DsEstadoCivil = 'S';
                    break;
                case "Casado(a)":
                    cliente.DsEstadoCivil = 'C';
                    break;
                default:
                    cliente.DsEstadoCivil = 'V';
                    break;
            }
            cliente.RG = txtRG.Text;
            cliente.CPF = txtCPF.Text;
            cliente.Endereco = txtEndereço.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Estado = cbEstado.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtEmail.Text;
            cliente.Status = true;

            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.InserirCliente(cliente);
            MessageBox.Show("Cliente criado com sucesso.");
            LimparCampos();
            CarregarCliente();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int cdCliente = Convert.ToInt32(txtBuscar.Text);
            Cliente cliente = new Cliente();
            cliente.CdCliente = cdCliente;
            cliente.NmCliente = txtNome.Text;
            cliente.DtNasc = dtNascimento.Value;
            switch (cbSexo.Text)
            {
                case "Masculino":
                    cliente.DsSexo = 'M';
                    break;
                case "Feminino":
                    cliente.DsSexo = 'F';
                    break;
                default:
                    cliente.DsSexo = 'O';
                    break;
            }
            switch (cbEstadoCivil.Text)
            {
                case "Solteiro(a)":
                    cliente.DsEstadoCivil = 'S';
                    break;
                case "Casado(a)":
                    cliente.DsEstadoCivil = 'C';
                    break;
                default:
                    cliente.DsEstadoCivil = 'V';
                    break;
            }
            cliente.RG = txtRG.Text;
            cliente.CPF = txtCPF.Text;
            cliente.Endereco = txtEndereço.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Email = txtEmail.Text;
            cliente.Estado = cbEstado.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Celular = txtCelular.Text;

            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.Atualizar(cdCliente, cliente);
            MessageBox.Show("Atualizado com sucesso.");
            LimparCampos();
            CarregarCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdCliente = Convert.ToInt32(txtBuscar.Text);
            ClienteDAL clienteDAL = new ClienteDAL();
            Cliente cliente = clienteDAL.Buscar(cdCliente);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrada");
            }
            else
            {
                txtNome.Text = cliente.NmCliente;
                txtEmail.Text = cliente.Email;
                switch (cliente.DsEstadoCivil)
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
                txtRG.Text = cliente.RG;
                txtCPF.Text = cliente.CPF;
                txtEndereço.Text = cliente.Endereco;
                cbEstado.Text = cliente.Estado;
                txtCidade.Text = cliente.Cidade;
                txtCEP.Text = cliente.CEP;
                switch (cliente.DsSexo)
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
                txtCelular.Text = cliente.Celular;
                txtTelefone.Text = cliente.Telefone;
                dtNascimento.Value = cliente.DtNasc;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdCodigo = Convert.ToInt32(txtBuscar.Text);
            ClienteDAL clienteDAL = new ClienteDAL();
            MessageBox.Show(clienteDAL.ExcluirCadastro(cdCodigo));
            CarregarCliente();
            LimparCampos();
        }
    }
}
