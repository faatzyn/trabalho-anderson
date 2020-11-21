using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class ItemDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString;

        public List<Item> Carregar()
        {
            List<Item> carregar = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Item";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Item item;

                while (dr.Read())
                {
                    item = new Item();

                    item.CdItem = Convert.ToInt32(dr["CdItem"]);
                    item.CdCod = dr["CdBarra"].ToString();
                    item.Titulo = dr["NmTitulo"].ToString();
                    item.Genero = dr["NmGenero"].ToString();
                    item.Ano = Convert.ToDateTime(dr["Ano"]);
                    item.Tipo = dr["Tipo"].ToString();
                    item.Preco = dr["Preco"].ToString();
                    item.DataCompra = Convert.ToDateTime(dr["DtAdquirida"]);
                    item.ValorCusto = dr["ValorCusto"].ToString();
                    item.Situacao = dr["Situacao"].ToString();
                    item.Atores = dr["AtoresParticipantes"].ToString();
                    item.Diretor = dr["Diretor"].ToString();

                    carregar.Add(item);
                }
            }

            conn.Close();

            return carregar;
        }

        public void InserirItem(Item item)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Item VALUES (@cdBarra, @nmTitulo, @nmGenero, @ano, @tipo, @preco, @dtAdquirida, @valorCusto, @situacao, @atoresParticipantes, @diretor)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nmTitulo", item.Titulo);
            cmd.Parameters.AddWithValue("@diretor", item.Diretor);
            cmd.Parameters.AddWithValue("@atoresParticipantes", item.Atores);
            cmd.Parameters.AddWithValue("@nmGenero", item.Genero);
            cmd.Parameters.AddWithValue("@ano", item.Ano);
            cmd.Parameters.AddWithValue("@tipo", item.Tipo);
            cmd.Parameters.AddWithValue("@dtAdquirida", item.DataCompra);
            cmd.Parameters.AddWithValue("@valorCusto", item.ValorCusto);
            cmd.Parameters.AddWithValue("@preco", item.Preco);
            cmd.Parameters.AddWithValue("@cdBarra", item.CdCod);
            cmd.Parameters.AddWithValue("@situacao", item.Situacao);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Item BuscarItem(int cdItem)
        {
            Item item = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string buscarItem = "SELECT * FROM Item WHERE CdItem = @cod";
            SqlCommand cmd = new SqlCommand(buscarItem, conn);
            cmd.Parameters.AddWithValue("@cod", cdItem);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                item = new Item();
                item.CdItem = cdItem;
                item.CdCod = dr["CdBarra"].ToString();
                item.Titulo = dr["NmTitulo"].ToString();
                item.Genero = dr["NmGenero"].ToString();
                item.Ano = Convert.ToDateTime(dr["Ano"]);
                item.Tipo = dr["Tipo"].ToString();
                item.Preco = dr["Preco"].ToString();
                item.DataCompra = Convert.ToDateTime(dr["DtAdquirida"]);
                item.ValorCusto = dr["ValorCusto"].ToString();
                item.Situacao = dr["Situacao"].ToString();
                item.Atores = dr["AtoresParticipantes"].ToString();
                item.Diretor = dr["Diretor"].ToString();
            }
            conn.Close();
            return item;
        }

        public string ExcluirItem(int cdItem)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string excluir = "DELETE FROM Item WHERE CdItem = @cod";

            SqlCommand cmd = new SqlCommand(excluir, conn);

            cmd.Parameters.AddWithValue("@cod", cdItem);

            cmd.ExecuteNonQuery();

            conn.Close();

            return "Ação efetuada com sucesso";
        }
    }    
}
