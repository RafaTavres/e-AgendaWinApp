using e_Agenda.Dominio.Compartilhado;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace e_Agenda.Infra.Dados.Sql.ModuloContato
{
    public class RepositorioContatoSql : RepositorioBaseEmSql<Contato> ,IRepositorioContato
    {

        public override string SqlInserir => @"INSERT INTO [TBCONTATO]
                    (
                        [NOME],
                        [TELEFONE]
                    )
                VALUES 
                    (
                        @NOME,
                        @T
                    );

             select SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT 
                                    [ID], 
                                    [NOME], 
                                    [TELEFONE] 
                                 FROM 
                                    TBCONTATO ";

        public override string SqlDeletar => @"DELETE FROM [TBCONTATO] 
                                    WHERE [ID] = @ID;
                                    ";

        public override string SqlBuscaId => @"SELECT 
                                            [ID] , 
                                            [NOME], 
                                            [TELEFONE] 
                                         FROM 
                                               TBCONTATO 
                                         WHERE 
                                               [ID] = @ID;";

        public override string SqlEditar => @"UPDATE [TBContato]
		                        SET
			                        [Nome] = @NOME
			                        [Telefone] = @TELEFONE

		                        WHERE 
			                        [ID] = @ID;
                        ";

        public override Contato ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            Contato contato = new();

            int idContato = Convert.ToInt32(leitorEntidades["ID"]);
            string nome = Convert.ToString(leitorEntidades["NOME"]);
            string telefone = Convert.ToString(leitorEntidades["TELEFONE"]);

            contato.id = idContato;
            contato.nome = nome;
            contato.telefone = telefone;

            return contato;
        }

        public override void ConfigurarParametros(SqlCommand comandoEditar, Contato novoContato)
        {
            comandoEditar.Parameters.AddWithValue("ID", novoContato.id);
            comandoEditar.Parameters.AddWithValue("NOME", novoContato.nome);
            comandoEditar.Parameters.AddWithValue("T", novoContato.telefone);
        
        }
    }
}
