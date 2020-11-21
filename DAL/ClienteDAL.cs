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
    public class ClienteDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString;

        public List<Cliente> Carregar()
        {
            List<Cliente> carregar = new List<Cliente>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Cliente";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Cliente cliente; ;

                while (dr.Read())
                {
                    cliente = new Cliente();

                    cliente.CdCliente = Convert.ToInt32(dr["CdCliente"]);
                    cliente.NmCliente = dr["NmCliente"].ToString();
                    cliente.DtNasc = Convert.ToDateTime(dr["DtNascimento"]);
                    cliente.DsSexo = Convert.ToChar(dr["Sexo"]);
                    cliente.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                    cliente.RG = dr["NrRG"].ToString();
                    cliente.CPF = dr["NrCPF"].ToString();
                    cliente.Endereco = dr["Endereco"].ToString();
                    cliente.Cidade = dr["Cidade"].ToString();
                    cliente.CEP = dr["CEP"].ToString();
                    cliente.Estado = dr["Estado"].ToString();
                    cliente.Telefone = dr["NrTelefone"].ToString();
                    cliente.Celular = dr["NrCelular"].ToString();
                    cliente.Email = dr["Email"].ToString();
                    cliente.Status = Convert.ToBoolean(dr["Status"]);

                    carregar.Add(cliente);
                }
            }

            conn.Close();

            return carregar;
        }

        public void InserirCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Cliente VALUES (@nmCliente, @dtNascimento, @sexo, @dsEstadoCivil, @nrRG, @nrCPF, @endereco, @cidade, @cep, @estado, @nrTelefone, @nrCelular, @email, @status)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nmCliente", cliente.NmCliente);
            cmd.Parameters.AddWithValue("@dtNascimento", cliente.DtNasc);
            cmd.Parameters.AddWithValue("@sexo", cliente.DsSexo);
            cmd.Parameters.AddWithValue("@dsEstadoCivil", cliente.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@nrRG", cliente.RG);
            cmd.Parameters.AddWithValue("@nrCPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@cep", cliente.CEP);
            cmd.Parameters.AddWithValue("@estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@nrTelefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@nrCelular", cliente.Celular);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@status", cliente.Status);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Atualizar(int cdCliente, Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string atualizar = "UPDATE Cliente SET NmCliente = @nmcliente, DtNascimento = @dtNascimento, Sexo = @sexo, DsEstadoCivil = @dsEstadoCivil, NrRG = @nrRG, NrCPF = @nrCPF, Endereco = @endereco, Cidade = @cidade, CEP = @cep, Estado = @estado, NrTelefone = @nrTelefone,NrCelular = @nrCelular, Email = @email WHERE CdCliente = @cod";

            SqlCommand cmd = new SqlCommand(atualizar, conn);
            cmd.Parameters.AddWithValue("@cod", cdCliente);
            cmd.Parameters.AddWithValue("@nmCliente", cliente.NmCliente);
            cmd.Parameters.AddWithValue("@dtNascimento", cliente.DtNasc);
            cmd.Parameters.AddWithValue("@sexo", cliente.DsSexo);
            cmd.Parameters.AddWithValue("@dsEstadoCivil", cliente.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@nrRG", cliente.RG);
            cmd.Parameters.AddWithValue("@nrCPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@cep", cliente.CEP);
            cmd.Parameters.AddWithValue("@estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@nrTelefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@nrCelular", cliente.Celular);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Cliente Buscar(int cdCliente)
        {
            Cliente cliente = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string buscarCliente = "SELECT * FROM Cliente WHERE CdCliente = @cod";
            SqlCommand cmd = new SqlCommand(buscarCliente, conn);
            cmd.Parameters.AddWithValue("@cod", cdCliente);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                cliente = new Cliente();
                cliente.CdCliente = cdCliente;
                cliente.NmCliente = dr["NmCliente"].ToString();
                cliente.DtNasc = Convert.ToDateTime(dr["DtNascimento"]);
                cliente.DsSexo = Convert.ToChar(dr["Sexo"].ToString());
                cliente.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"].ToString());
                cliente.RG = dr["NrRG"].ToString();
                cliente.CPF = dr["NrCPF"].ToString();
                cliente.Endereco = dr["Endereco"].ToString();
                cliente.Cidade = dr["Cidade"].ToString();
                cliente.CEP = dr["CEP"].ToString();
                cliente.Estado = dr["Estado"].ToString();
                cliente.Telefone = dr["NrTelefone"].ToString();
                cliente.Celular = dr["NrCelular"].ToString();
                cliente.Email = dr["Email"].ToString();
                cliente.Status = Convert.ToBoolean(dr["Status"].ToString());
            }
            conn.Close();
            return cliente;
        }

        public string ExcluirCadastro(int cdCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            
            conn.Open();

            string excluir = "DELETE FROM Cliente WHERE CdCliente = @cod";

            SqlCommand cmd = new SqlCommand(excluir, conn);

            cmd.Parameters.AddWithValue("@cod", cdCliente);

            cmd.ExecuteNonQuery();

            conn.Close();

            return "Ação efetuada com sucesso";
            
        }
    }
}
