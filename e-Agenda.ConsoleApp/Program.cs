using e_Agenda.Dominio.ModuloContato;
using Microsoft.Data.SqlClient;

namespace e_Agenda.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //obter conexao
            //Contato contato = ObterContato();
            List<Contato> contatos = SelecionarTodos();
            foreach (Contato item in contatos)
            {
                Console.WriteLine($"{item.id} nome {item.nome}");
            }
        }

        private static List<Contato> SelecionarTodos()
        {
            SqlConnection conexao = new();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=E_AgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";
            conexao.Open();

            string sqlSelecionarTodos = @"SELECT 
                                    [ID], 
                                    [NOME], 
                                    [TELEFONE] 
                                 FROM 
                                    TBCONTATO ";

            SqlCommand comandoSelecionarTodos = new();
            comandoSelecionarTodos.Connection = conexao;
            comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

            SqlDataReader leitorContatos = comandoSelecionarTodos.ExecuteReader();

            List<Contato> contatos = new();

            while(leitorContatos.Read())
            {
                int idContato = Convert.ToInt32(leitorContatos["ID"]);
                string nome = Convert.ToString(leitorContatos["NOME"]);
                string telefone = Convert.ToString(leitorContatos["TELEFONE"]);

                Contato contato = new();
                contato.id = idContato;
                contato.nome = nome;
                contato.telefone = telefone;

                contatos.Add(contato);

            }

            //fecha a conex
            conexao.Close();

            return contatos;
        }
        private static void Excluir(int idSelecionado)
        {
            SqlConnection conexao = new();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=E_AgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";
            conexao.Open();
            //criar comando e relaciona com a a conexao

            string sqlExcluir = @"DELETE FROM [TBCONTATO] 
                                    WHERE [ID] = @ID;
                                    ";

            SqlCommand comandoExcluir = new();
            comandoExcluir.Connection = conexao;
            comandoExcluir.CommandText = sqlExcluir;

            //adiciona paramentros
            comandoExcluir.Parameters.AddWithValue("ID", idSelecionado);

            //executo a conex
            comandoExcluir.ExecuteNonQuery();

            //fecha a conex
            conexao.Close();
        }
        private static void Inserir(Contato novoContato)
        {
            SqlConnection conexao = new();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=E_AgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";
            conexao.Open();
            //criar comando e relaciona com a a conexao

            string sqlInsert = @"INSERT INTO [TBCONTATO]
                    (
                        [NOME],
                        [TELEFONE]
                    )
                VALUES 
                    (
                        @N,
                        @T
                    );

             select SCOPE_IDENTITY();";

            SqlCommand comandoInserir = new();
            comandoInserir.Connection = conexao;
            comandoInserir.CommandText = sqlInsert;
           
            //adiciona paramentros
            comandoInserir.Parameters.AddWithValue("N", novoContato.nome);
            comandoInserir.Parameters.AddWithValue("T", novoContato.telefone);

            //executo a conex
            comandoInserir.ExecuteNonQuery();

            //fecha a conex
            conexao.Close();
        }

        private static void Editar(Contato novoContato)
        {
            SqlConnection conexao = new();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=E_AgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";
            conexao.Open();
            //criar comando e relaciona com a a conexao

            string sqlEditar = @"UPDATE [TBContato]
		                        SET
			                        [Nome] = @N,
			                        [Telefone] = @T

		                        WHERE 
			                        [ID] = @ID;
                        ";

            SqlCommand comandoEditar = new();
            comandoEditar.Connection = conexao;
            comandoEditar.CommandText = sqlEditar;

            //adiciona paramentros
            comandoEditar.Parameters.AddWithValue("ID", novoContato.id);
            comandoEditar.Parameters.AddWithValue("N", novoContato.nome);
            comandoEditar.Parameters.AddWithValue("T", novoContato.telefone);

            //executo a conex
            comandoEditar.ExecuteScalar();

            //fecha a conex
            conexao.Close();
        }

        private static Contato sqlSelecionarPorID(int idSelecionado)
        {
            SqlConnection conexao = new();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=E_AgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";
            conexao.Open();

            //criar comando e relaciona com a a conexao
            string sqlSelecionarPorID = @"SELECT 
                                            [ID] , 
                                            [NOME], 
                                            [TELEFONE] 
                                         FROM 
                                               TBCONTATO 
                                         WHERE 
                                               [ID] = @ID;";

            SqlCommand comandoSelecao = new();
            comandoSelecao.Connection = conexao;
            comandoSelecao.CommandText = sqlSelecionarPorID;

            //adiciona paramentros
            comandoSelecao.Parameters.AddWithValue("ID",idSelecionado);

            // Executo o comando criado
            
            SqlDataReader leitorContatos = comandoSelecao.ExecuteReader();

            Contato contato = null;

            if (leitorContatos.Read())
            {
                int idContato = Convert.ToInt32(leitorContatos["ID"]);
                string nome = Convert.ToString(leitorContatos["NOME"]);
                string telefone = Convert.ToString(leitorContatos["TELEFONE"]);

                contato = new();
                contato.id = idContato;
                contato.nome = nome;
                contato.telefone = telefone;
                
            }

            //fecha a conex
            conexao.Close();

            return contato;


        }

        private static Contato ObterContato()
        {
            Contato contato = new();
            string nome = Console.ReadLine();
            string telefone = Console.ReadLine();
            contato.nome = nome;
            contato.telefone = telefone;

            return contato;
        }
    }
}