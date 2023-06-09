using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_ADONET
{
    class Produto
    {
        public int IdProduto;
        public string NomeProduto;
        public decimal Preco;
        public int IdFornecedor;

        public bool gravar()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into produtos (nome, preco, fk_fornecedor)" +
                " values (@nome, @preco, @fk_fornecedor);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@preco", System.Data.SqlDbType.Decimal);
            command.Parameters.Add("@fk_fornecedor", SqlDbType.Int);
            command.Parameters[0].Value = NomeProduto;
            command.Parameters[1].Value = Preco;
            command.Parameters[2].Value = IdFornecedor;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
        public bool excluir()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from produtos where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = IdProduto;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
        public bool atualizar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update produtos set nome = @nome, " +
                " preco = @preco where id = @id";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = NomeProduto;
            cmd.Parameters[1].Value = Preco;
            cmd.Parameters[2].Value = IdProduto;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
        public Produto consulta(int idProduto)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from produtos", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == idProduto)
                    {
                        this.IdProduto = reader.GetInt32(0);
                        this.NomeProduto = reader.GetString(1);
                        this.Preco = reader.GetDecimal(2);
                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
