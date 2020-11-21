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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtTitulo.Clear();
            dtAdquirido.Value = DateTime.Now;
            dtAno.Value = DateTime.Now;
            txtDiretor.Clear();
            txtAtores.Clear();
            txtGenero.Text = string.Empty;
            cbTipo.Text = string.Empty;
            txtCusto.Clear();
            txtCod.Clear();
        }

        private void CarregarItem()
        {
            ItemDAL itemDAL = new ItemDAL();
            dgvFilmes.DataSource = itemDAL.Carregar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Titulo = txtTitulo.Text;
            item.Diretor = txtDiretor.Text;
            item.Genero = txtGenero.Text;
            item.Ano = dtAno.Value;
            item.Atores = txtAtores.Text;
            item.Tipo = cbTipo.Text;
            item.DataCompra = dtAdquirido.Value;
            item.ValorCusto = txtCusto.Text;
            item.Preco = txtVAluguel.Text;
            item.CdCod = txtCod.Text;
            item.Situacao = "Disponível";

            ItemDAL itemDAL = new ItemDAL();
            itemDAL.InserirItem(item);
            MessageBox.Show("Item criado com sucesso.");
            LimparCampos();
            CarregarItem();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            CarregarItem();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdItem = Convert.ToInt32(txtBuscar.Text);
            ItemDAL itemDAL = new ItemDAL();
            Item item = itemDAL.BuscarItem(cdItem);

            if (item == null)
            {
                MessageBox.Show("Item não encontrada");
            }
            else
            {
                txtTitulo.Text = item.Titulo;
                txtGenero.Text = item.Genero;
                cbTipo.Text = item.Tipo;
                txtAtores.Text = item.Atores;
                txtDiretor.Text = item.Diretor;
                dtAno.Value = item.Ano;
                dtAdquirido.Value = item.DataCompra;
                txtVAluguel.Text = item.Preco;
                txtCusto.Text = item.ValorCusto;
                txtVAluguel.Text = item.Preco;
                txtCod.Text = item.CdCod;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdItem = Convert.ToInt32(txtBuscar.Text);
            ItemDAL itemDAL = new ItemDAL();
            MessageBox.Show(itemDAL.ExcluirItem(cdItem));
            CarregarItem();
            LimparCampos();

        }
    }
}
