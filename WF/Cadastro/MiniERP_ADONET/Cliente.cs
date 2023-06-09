using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_ADONET
{
    class Cliente
    {
        public int IdCliente;
        public string NomeCliente;

        public bool gravar()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into clientes " +
                " values (@nome);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = NomeCliente;
 
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
        public bool excluir()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from clientes where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = IdCliente;

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
            cmd.CommandText = "update clientes set nome = @nome where id = @id";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = NomeCliente;
            cmd.Parameters[1].Value = IdCliente;

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
        public Cliente consulta(int idCliente)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from clientes", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == idCliente)
                    {
                        this.IdCliente = reader.GetInt32(0);
                        this.NomeCliente = reader.GetString(1);
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
