using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace Sistec
{
    public class FornecedorDAO
    {
        string Conexao01 = @"Server=DESKTOP-N7R6D6T\SQLEXPRESS;Database=dbsistec;User Id=ceub;Password=123456;MultipleActiveResultSets=True";
        //string Conexao01 = @"Server=DESKTOP-N7R6D6T\SQLEXPRESS;Database=dbsistec;Trusted_Connection=True;MultipleActiveResultSets=True";
        string ConexaoMyql = "Server=localhost;Database=test;Uid=usuario;Pwd=senha";

        public FornecedorDAO()
        {

        }

        ///CRUD
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            /*using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConexaoMyql))
            {
                conn.Open();
                conn.Insert<Usuario>(usuario);
            }*/
            
            //Conectar ao Banco de Dados e dar um insert
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                conn.Insert<Fornecedor>(fornecedor);
            }
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            //Conectar ao Banco de Dados e dar um insert
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                conn.Update<Fornecedor>(fornecedor);
            }
        }

        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
          using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                conn.Delete<Fornecedor>(fornecedor);
            }  
        }

        public Fornecedor BuscarFornecedor(int FornecedorId)
        {
            //string sql = "Select * from TB_Usuario Where USUID=@USUID";
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                return conn.Get<Fornecedor>(FornecedorId);
                //return conn.Query<Usuario>(sql,new{USUID=UsuarioId}).FirstOrDefault();
            } 
        }

        public IList<Fornecedor> BuscarFornecedor()
        {
            //string sql = "Select * from TB_Usuario";
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                return conn.GetAll<Fornecedor>().ToList();
                //return conn.Query<Usuario>(sql).ToList();
            } 
        }

    }
}
