using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_ADONET
{
    class Banco
    {
        private string stringConexao = @"Server=.\SQLExpress;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MiniERP.mdf;Database=MiniERP;Trusted_Connection=Yes;";
      
        private SqlConnection cn;
        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }
        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
