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
    public class FuncionarioDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString;

        public bool AutenticarFuncionario(string usuario, string senha)
        {
            bool autenticado = false;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT COUNT(*) FROM Funcionario WHERE DsLogin = @login AND DsSenha = @senha AND Status = 1";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@login", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            autenticado = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

            conn.Close();
            return autenticado;
        }

        public void InserirFuncionario(Funcionario objfuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Funcionario VALUES (@nmFuncionario, @dtNascimento, @sexo, @dsEstadoCivil, @nrRG, @nrCPF, @endereco, @cidade, @cep, @estado, @nrTelefone, @nrCelular, @email, @usuario, @senha, @status)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nmFuncionario", objfuncionario.NmFuncionario);
            cmd.Parameters.AddWithValue("@dtNascimento", objfuncionario.DtNasc);
            cmd.Parameters.AddWithValue("@sexo", objfuncionario.DsSexo);
            cmd.Parameters.AddWithValue("@dsEstadoCivil", objfuncionario.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@nrRG", objfuncionario.RG);
            cmd.Parameters.AddWithValue("@nrCPF", objfuncionario.CPF);
            cmd.Parameters.AddWithValue("@endereco", objfuncionario.Endereco);
            cmd.Parameters.AddWithValue("@cidade", objfuncionario.Cidade);
            cmd.Parameters.AddWithValue("@cep", objfuncionario.CEP);
            cmd.Parameters.AddWithValue("@estado", objfuncionario.Estado);
            cmd.Parameters.AddWithValue("@nrTelefone", objfuncionario.Telefone);
            cmd.Parameters.AddWithValue("@nrCelular", objfuncionario.Celular);
            cmd.Parameters.AddWithValue("@email", objfuncionario.Email);
            cmd.Parameters.AddWithValue("@usuario", objfuncionario.DsLogin);
            cmd.Parameters.AddWithValue("@senha", objfuncionario.DsSenha);
            cmd.Parameters.AddWithValue("@status", objfuncionario.Status);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Funcionario> Carregar()
        {
            List<Funcionario> carregar = new List<Funcionario>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Funcionario";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Funcionario funcionario;

                while (dr.Read())
                {
                    funcionario = new Funcionario();

                    funcionario.CdFuncionario = Convert.ToInt32(dr["CdFuncionario"]);
                    funcionario.NmFuncionario = dr["NmFuncionario"].ToString();
                    funcionario.DtNasc = Convert.ToDateTime(dr["DtNascimento"]);
                    funcionario.DsSexo = Convert.ToChar(dr["Sexo"]);
                    funcionario.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                    funcionario.RG = dr["NrRG"].ToString();
                    funcionario.CPF = dr["NrCPF"].ToString();
                    funcionario.Endereco = dr["Endereco"].ToString();
                    funcionario.Cidade = dr["Cidade"].ToString();
                    funcionario.CEP = dr["CEP"].ToString();
                    funcionario.Estado = dr["Estado"].ToString();
                    funcionario.Telefone = dr["NrTelefone"].ToString();
                    funcionario.Celular = dr["NrCelular"].ToString();
                    funcionario.Email = dr["Email"].ToString();
                    funcionario.DsLogin = dr["DsLogin"].ToString();
                    funcionario.DsSenha = dr["DsSenha"].ToString();
                    funcionario.Status = Convert.ToBoolean(dr["Status"]);

                    carregar.Add(funcionario);
                }
            }

            conn.Close();

            return carregar;
        }

        public Funcionario Buscar(int cdFuncionario)
        {
            Funcionario funcionario = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string buscarFuncionario = "SELECT * FROM Funcionario WHERE CdFuncionario = @cod";
            SqlCommand cmd = new SqlCommand(buscarFuncionario, conn);
            cmd.Parameters.AddWithValue("@cod", cdFuncionario);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                funcionario = new Funcionario();
                funcionario.CdFuncionario = cdFuncionario;
                funcionario.NmFuncionario = dr["NmFuncionario"].ToString();
                funcionario.DtNasc = Convert.ToDateTime(dr["DtNascimento"]);
                funcionario.DsSexo = Convert.ToChar(dr["Sexo"].ToString());
                funcionario.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"].ToString());
                funcionario.RG = dr["NrRG"].ToString();
                funcionario.CPF = dr["NrCPF"].ToString();
                funcionario.Endereco = dr["Endereco"].ToString();
                funcionario.Cidade = dr["Cidade"].ToString();
                funcionario.CEP = dr["CEP"].ToString();
                funcionario.Estado = dr["Estado"].ToString();
                funcionario.Telefone = dr["NrTelefone"].ToString();
                funcionario.Celular = dr["NrCelular"].ToString();
                funcionario.Email = dr["Email"].ToString();
                funcionario.DsLogin = dr["DsLogin"].ToString();
                funcionario.DsSenha = dr["DsSenha"].ToString();
                funcionario.Status = Convert.ToBoolean(dr["Status"].ToString());
            }
            conn.Close();
            return funcionario;
        }

        public string ExcluirCadastro(int cdFuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            if (cdFuncionario == 1)
            {
                return "Ação não permitida";
            }
            else
            {
                conn.Open();

                string excluir = "DELETE FROM Funcionario WHERE CdFuncionario = @cod";

                SqlCommand cmd = new SqlCommand(excluir, conn);

                cmd.Parameters.AddWithValue("@cod", cdFuncionario);

                cmd.ExecuteNonQuery();

                conn.Close();

                return "Ação efetuada com sucesso";
            }
        }

        public void Atualizar(int cdFuncionario, Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string atualizar = "UPDATE Funcionario SET NmFuncionario = @nmFuncionario,DtNascimento = @dtNascimento, Sexo = @sexo, DsEstadoCivil = @dsEstadoCivil, NrRG = @nrRG," +
                "NrCPF = @nrCPF, Endereco = @endereco, Cidade = @cidade, CEP = @cep, Estado = @estado, NrTelefone = @nrTelefone,NrCelular = @nrCelular, Email = @email," +
                "DsLogin = @usuario WHERE CdFuncionario = @cod";

            SqlCommand cmd = new SqlCommand(atualizar, conn);
            cmd.Parameters.AddWithValue("@cod", cdFuncionario);
            cmd.Parameters.AddWithValue("@nmFuncionario", funcionario.NmFuncionario);
            cmd.Parameters.AddWithValue("@dtNascimento", funcionario.DtNasc);
            cmd.Parameters.AddWithValue("@sexo", funcionario.DsSexo);
            cmd.Parameters.AddWithValue("@dsEstadoCivil", funcionario.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@nrRG", funcionario.RG);
            cmd.Parameters.AddWithValue("@nrCPF", funcionario.CPF);
            cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
            cmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@cep", funcionario.CEP);
            cmd.Parameters.AddWithValue("@estado", funcionario.Estado);
            cmd.Parameters.AddWithValue("@nrTelefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@nrCelular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@usuario", funcionario.DsLogin);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void PermitirLogin(int cdFuncionario, Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string permissao = "UPDATE Funcionario SET Status = @status WHERE CdFuncionario = @cod";

            SqlCommand cmd = new SqlCommand(permissao,conn);
            cmd.Parameters.AddWithValue("@cod", cdFuncionario);
            cmd.Parameters.AddWithValue("@status", funcionario.Status);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
