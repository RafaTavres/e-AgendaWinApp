using e_Agenda.Dominio.Compartilhado;
using e_Agenda.Dominio.ModuloContato;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Infra.Dados.Sql.Compartilhado
{
    public abstract class RepositorioBaseEmSql<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        public List<TEntidade> listaEntidades = new List<TEntidade>();

        public const string ENDERECOBANCO = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
              "Initial Catalog=E_AgendaDb;" +
              "Integrated Security=True;" +
              "Pooling=False";

        public abstract string SqlInserir{ get; }
        public abstract string SqlBuscarTodos { get; }
        public abstract string SqlDeletar { get; }
        public abstract string SqlBuscaId { get; }
        public abstract string SqlEditar { get; }


        public void Atualizar(int id, TEntidade entidade)
        {
            SqlConnection conexao = new();
            conexao.Open();
            //criar comando e relaciona com a a conexao

            SqlCommand comandoEditar = conexao.CreateCommand();
            comandoEditar.CommandText = SqlEditar;

            //adiciona paramentros
            ConfigurarParametros(comandoEditar, entidade);

            //executo a conex
            comandoEditar.ExecuteNonQuery();

            //fecha a conex
            conexao.Close();
        }

        public TEntidade Busca(int id)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();
            //criar comando e relaciona com a a conexao

            SqlCommand comandoSelecao = conexao.CreateCommand();
            comandoSelecao.CommandText = SqlBuscaId;
            //adiciona paramentros
            comandoSelecao.Parameters.AddWithValue("ID", id);
            // Executo o comando criado

            SqlDataReader leitorEntidades = comandoSelecao.ExecuteReader();

            TEntidade entidade = null;

            if (leitorEntidades.Read())
                entidade = ConverterParaEntidade(leitorEntidades);
                      
            //fecha a conex
            conexao.Close();

            return entidade;
        }

        public void Deletar(int id)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();
            //criar comando e relaciona com a a conexao


            SqlCommand comandoDeletar = conexao.CreateCommand();
            comandoDeletar.CommandText = SqlDeletar;

            //adiciona paramentros
            comandoDeletar.Parameters.AddWithValue("ID", id);

            //executo a conex
            comandoDeletar.ExecuteNonQuery();

            //fecha a conex
            conexao.Close();
        }

        public void Inserir(TEntidade novaEntidade)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoInserir = conexao.CreateCommand();
            comandoInserir.CommandText = SqlInserir;
            //adiciona paramentros
            ConfigurarParametros(comandoInserir, novaEntidade);

            //executo a conex
            object id = comandoInserir.ExecuteScalar();

            novaEntidade.id = Convert.ToInt32(id);
            //fecha a conex
            conexao.Close();
        }

        public List<TEntidade> RetornarTodos()
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();



            SqlCommand comandoSelecionarTodos = conexao.CreateCommand();
            comandoSelecionarTodos.CommandText = SqlBuscarTodos;

            SqlDataReader leitorEntidades = comandoSelecionarTodos.ExecuteReader();

            List<TEntidade> entidades = new();

            while (leitorEntidades.Read())
            {
               TEntidade entidade = ConverterParaEntidade(leitorEntidades);

                entidades.Add(entidade);

            }

            //fecha a conex
            conexao.Close();

            return entidades;
        }

        public abstract TEntidade ConverterParaEntidade(SqlDataReader leitorEntidades);   
        public abstract void ConfigurarParametros(SqlCommand comandoEditar, TEntidade novaEntidade);
    }
}
