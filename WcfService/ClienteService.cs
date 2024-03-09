using CadastroClientes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código e configuração ao mesmo tempo.
    public class ClienteService : IClienteService
    {
        private static string ConnectionString = "Data Source=THINKPAD;Initial Catalog=GTISoftware;Integrated Security=True";
        public Cliente GetClient(int idCliente)
        {
            var retorno = new List<Cliente>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"SELECT C.*,  
                                            EC.CEP, EC.Logradouro,
                                            EC.Numero,EC.Complemento,
                                            EC.Bairro,EC.Cidade, EC.UF
                                            FROM tbl_Cliente C
                                            Inner Join tbl_EnderecoCliente EC on EC.IdCliente = C.IdCliente
                                            Where C.IdCliente = @IdCliente";
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cliente = new Cliente()
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"].ToString()),
                                CPF = reader["CPF"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                RG = reader["RG"].ToString(),
                                DataExpedicao = Convert.ToDateTime(reader["DataExpedicao"].ToString()),
                                OrgaoExpedicao = reader["OrgaoExpedicao"].ToString(),
                                UFExpedicao = reader["UFExpedicao"].ToString(),
                                DataNascimento = Convert.ToDateTime(reader["DataNascimento"].ToString()),
                                Sexo = reader["Sexo"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString(),
                                EnderecoCliente = new EnderecoCliente()
                                {
                                    CEP = reader["CEP"].ToString(),
                                    Logradouro = reader["Logradouro"].ToString(),
                                    Numero = reader["Numero"].ToString(),
                                    Complemento = reader["Complemento"].ToString(),
                                    Bairro = reader["Bairro"].ToString(),
                                    Cidade = reader["Cidade"].ToString(),
                                    UF = reader["UF"].ToString(),
                                }
                            };

                            retorno.Add(cliente);
                        }
                    }
                }
            }
            return retorno.Count > 0 ? retorno.First() : null;
        }

        public List<Cliente> GetClients()
        {
            var retorno = new List<Cliente>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"SELECT C.*,  
                                            EC.CEP, EC.Logradouro,
                                            EC.Numero,EC.Complemento,
                                            EC.Bairro,EC.Cidade, EC.UF
                                            FROM tbl_Cliente C
                                            Inner Join tbl_EnderecoCliente EC on EC.IdCliente = C.IdCliente";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cliente = new Cliente()
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"].ToString()),
                                CPF = reader["CPF"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                RG = reader["RG"].ToString(),
                                DataExpedicao = Convert.ToDateTime(reader["DataExpedicao"].ToString()),
                                OrgaoExpedicao = reader["OrgaoExpedicao"].ToString(),
                                UFExpedicao = reader["UFExpedicao"].ToString(),
                                DataNascimento = Convert.ToDateTime(reader["DataNascimento"].ToString()),
                                Sexo = reader["Sexo"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString(),
                                EnderecoCliente = new EnderecoCliente()
                                {
                                    CEP = reader["CEP"].ToString(),
                                    Logradouro = reader["Logradouro"].ToString(),
                                    Numero = reader["Numero"].ToString(),
                                    Complemento = reader["Complemento"].ToString(),
                                    Bairro = reader["Bairro"].ToString(),
                                    Cidade = reader["Cidade"].ToString(),
                                    UF = reader["UF"].ToString(),
                                }
                            };

                            retorno.Add(cliente);
                        }
                    }
                }
            }
            return retorno;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void InsertClient(Cliente cliente)
        {
            try
            {
                cliente = InserirCliente(cliente);
                InserirEnderecoCliente(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteClient(int idCliente)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $@"delete dbo.tbl_EnderecoCliente where IdCliente = @IdCliente;
                                             delete dbo.tbl_Cliente where IdCliente = @IdClienteEndereco;";

                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@IdClienteEndereco", idCliente);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateClient(Cliente cliente)
        {
            try
            {
                UpdateCliente(cliente);
                UpdateEnderecoCliente(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private Cliente InserirCliente(Cliente cliente)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"INSERT INTO dbo.tbl_Cliente
                                                VALUES (
                                                         @CPF
                                                        ,@Nome
                                                        ,@RG
                                                        ,@DataExpedicao
                                                        ,@OrgaoExpedicao
                                                        ,@UFExpedicao
                                                        ,@DataNascimento
                                                        ,@Sexo
                                                        ,@EstadoCivil ) ;
                                            SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@RG", cliente.RG);
                    cmd.Parameters.AddWithValue("@DataExpedicao", cliente.DataExpedicao);
                    cmd.Parameters.AddWithValue("@OrgaoExpedicao", cliente.OrgaoExpedicao);
                    cmd.Parameters.AddWithValue("@UFExpedicao", cliente.UFExpedicao);
                    cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    cmd.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
                    // ExecuteScalar retorna o ID gerado pelo INSERT
                    cliente.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());

                    return cliente;
                }

            }

        }

        private void InserirEnderecoCliente(Cliente cliente)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"INSERT INTO dbo.tbl_EnderecoCliente
                                                VALUES (
                                                         @IdCliente
                                                        ,@IdEndereco
                                                        ,@CEP
                                                        ,@Logradouro
                                                        ,@Numero
                                                        ,@Complemento
                                                        ,@Bairro
                                                        ,@Cidade
                                                        ,@UF );";

                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@IdEndereco", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@CEP", cliente.EnderecoCliente.CEP);
                    cmd.Parameters.AddWithValue("@Logradouro", cliente.EnderecoCliente.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", cliente.EnderecoCliente.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", cliente.EnderecoCliente.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", cliente.EnderecoCliente.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", cliente.EnderecoCliente.Cidade);
                    cmd.Parameters.AddWithValue("@UF", cliente.EnderecoCliente.UF);
                    // ExecuteScalar retorna o ID gerado pelo INSERT
                    cmd.ExecuteNonQuery();

                }

            }

        }

        private void UpdateCliente(Cliente cliente)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"UPDATE dbo.tbl_Cliente
                                                SET CPF = @CPF
                                                   ,Nome = @Nome
                                                   ,RG = @RG
                                                   ,DataExpedicao = @DataExpedicao
                                                   ,OrgaoExpedicao = @OrgaoExpedicao
                                                   ,UFExpedicao = @UFExpedicao
                                                   ,DataNascimento = @DataNascimento
                                                   ,Sexo = @Sexo
                                                   ,EstadoCivil = @EstadoCivil
                                         Where IdCliente = @IdCliente";

                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@RG", cliente.RG);
                    cmd.Parameters.AddWithValue("@DataExpedicao", cliente.DataExpedicao);
                    cmd.Parameters.AddWithValue("@OrgaoExpedicao", cliente.OrgaoExpedicao);
                    cmd.Parameters.AddWithValue("@UFExpedicao", cliente.UFExpedicao);
                    cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    cmd.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);

                    cmd.ExecuteNonQuery();

                }

            }

        }

        private void UpdateEnderecoCliente(Cliente cliente)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"UPDATE dbo.tbl_EnderecoCliente
                                                SET
                                                     CEP = @CEP
                                                    ,Logradouro = @Logradouro
                                                    ,Numero = @Numero
                                                    ,Complemento = @Complemento
                                                    ,Bairro = @Bairro
                                                    ,Cidade = @Cidade
                                                    ,UF= @UF
                                            WHERE IdCliente = @IdCliente";

                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@CEP", cliente.EnderecoCliente.CEP);
                    cmd.Parameters.AddWithValue("@Logradouro", cliente.EnderecoCliente.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", cliente.EnderecoCliente.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", cliente.EnderecoCliente.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", cliente.EnderecoCliente.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", cliente.EnderecoCliente.Cidade);
                    cmd.Parameters.AddWithValue("@UF", cliente.EnderecoCliente.UF);

                    cmd.ExecuteNonQuery();

                }

            }

        }


    }
}
