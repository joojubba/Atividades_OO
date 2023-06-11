using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_ADONET
{
    class Nota
    {
        public int IdNota;
        public int IdCliente;
        public List<NotaItem> NotaItens;
        public Nota()
        {
            NotaItens = new List<NotaItem>();
        }


        public bool gravar()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into notas (fk_cliente) values (@fk_cliente); SELECT SCOPE_IDENTITY();";
            command.Parameters.Add("@fk_cliente", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = IdCliente;

            

            try
            {
                IdNota = Convert.ToInt32(command.ExecuteScalar());
                foreach (var notaItem in NotaItens)
                {
                    notaItem.IdNota = IdNota;
                    notaItem.gravar(tran);
                }

                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            command.CommandText = "delete from notaItens where fk_notas = @id; delete from notas where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = IdNota;

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
            cmd.CommandText = "update notas set fk_cliente = @fk_cliente where id = @id";
            cmd.Parameters.Add("@fk_cliente", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = IdCliente;
            cmd.Parameters[1].Value = IdNota;

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
        public Nota consulta(int idNota)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from notas", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == idNota)
                    {
                        this.IdNota = reader.GetInt32(0);
                        this.IdCliente = reader.GetInt32(1);

                        NotaItens = new List<NotaItem>();
                        NotaItem notaItem = new NotaItem();
                        NotaItens.AddRange(notaItem.consulta(IdNota));

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
