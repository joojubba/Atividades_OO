using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_ADONET
{
    class NotaItem
    {
        public int IdNotaItem;
        public int IdNota;
        public int IdProduto;
        public int QtdNotaItem;

        public bool gravar(SqlTransaction tran)
        {
            Banco bd = new Banco();

            SqlCommand command = new SqlCommand();

            command.Connection = tran.Connection;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into notaItens (qtd, fk_notas, fk_produto) values (@qtd, @fk_notas, @fk_produto);";
            command.Parameters.Add("@qtd", System.Data.SqlDbType.Int);
            command.Parameters.Add("@fk_notas", System.Data.SqlDbType.Int);
            command.Parameters.Add("@fk_produto", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = QtdNotaItem;
            command.Parameters[1].Value = IdNota;
            command.Parameters[2].Value = IdProduto;



            try
            {
               
                IdNotaItem = Convert.ToInt32(command.ExecuteScalar());
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
        public List<NotaItem> consulta(int idNota)
        {
            List<NotaItem> notaItens = new List<NotaItem>();
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from notaItens where fk_notas = @fk_notas", cn);
                command.Parameters.Add("@fk_notas", System.Data.SqlDbType.Int);
                command.Parameters[0].Value = idNota;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NotaItem notaItem = new NotaItem();
                    notaItem.IdNotaItem = reader.GetInt32(0);
                    notaItem.QtdNotaItem = reader.GetInt32(1);
                    notaItem.IdNota = reader.GetInt32(2);
                    notaItem.IdProduto = reader.GetInt32(3);
                    notaItens.Add(notaItem);
                }

                return notaItens;
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
