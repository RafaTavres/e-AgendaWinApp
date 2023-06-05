using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloDespesas;
using e_Agenda.Dominio.ModuloTarefa;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace e_Agenda.Infra.Data.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "Compartilhado\\e-Agenda.json";

        public List<Contato> contatos;
        public List<Compromisso> compromissos;
        public List<Despesa> despesas;
        public List<Categoria> categorias;
        public List<Tarefa> tarefas;

        public ContextoDados()
        {
            contatos = new List<Contato>();
            compromissos = new List<Compromisso>();
            tarefas = new List<Tarefa>();
            categorias = new List<Categoria>();
            despesas = new List<Despesa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarEntidadesDoArquivoJson();
        }

        #region Arquivos em Binário
        public void CarregarEntidadesDoArquivoEmBinario()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] entidadesEmByte = File.ReadAllBytes(NOME_ARQUIVO);

            MemoryStream entidadeStream = new MemoryStream(entidadesEmByte);

            if (File.Exists(NOME_ARQUIVO))
            {
                if (entidadesEmByte.Length > 0)
                {
                    ContextoDados ctx = (ContextoDados)serializador.Deserialize(entidadeStream);

                    this.contatos = ctx.contatos;
                    this.compromissos = ctx.compromissos;
                    this.tarefas = ctx.tarefas;
                    this.categorias = ctx.categorias;
                    this.despesas = ctx.despesas;
                }
            }
        }


        public void GravarEntidadesEmArquivoEmBinario()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream entidadeStream = new MemoryStream();

            serializador.Serialize(entidadeStream, this);

            byte[] entidadesEmByte = entidadeStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO, entidadesEmByte);
        }

        #endregion

        #region Arquivos em XML
        public void CarregarEntidadesDoArquivoEmXML()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<ContextoDados>));

            byte[] entidadEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

            MemoryStream entidadeStream = new MemoryStream(entidadEmBytes);

             
            if (File.Exists(NOME_ARQUIVO))
            {
                if (entidadEmBytes.Length > 0)
                {
                    ContextoDados ctx = (ContextoDados)serializador.Deserialize(entidadeStream);

                    this.contatos = ctx.contatos;
                    this.compromissos = ctx.compromissos;
                    this.tarefas = ctx.tarefas;
                    this.categorias = ctx.categorias;
                    this.despesas = ctx.despesas;
                }
            }

        }


        public void GravarEntidadesEmArquivoEmXML()
        {

            XmlSerializer serializador = new XmlSerializer(typeof(List<ContextoDados>));

            MemoryStream entidadeStream = new MemoryStream();

            serializador.Serialize(entidadeStream, this);

            byte[] entidadesEmByte = entidadeStream.ToArray();
                
            File.WriteAllBytes(NOME_ARQUIVO, entidadesEmByte);
        }

        #endregion

        #region Arquivos em JSON

        public void GravarEntidadesEmArquivoJson()
        {
            JsonSerializerOptions opcoes = ObterConfiguracoes();
            string entidadesJson = JsonSerializer.Serialize(this, opcoes);
            File.WriteAllText(NOME_ARQUIVO, entidadesJson);
        }

        private void CarregarEntidadesDoArquivoJson()
        {
            JsonSerializerOptions opcoes = ObterConfiguracoes();

            string entidadesJson = File.ReadAllText(NOME_ARQUIVO);

            if (File.Exists(NOME_ARQUIVO))
            {
                if (entidadesJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(entidadesJson, opcoes);

                    this.contatos = ctx.contatos;
                    this.compromissos = ctx.compromissos;
                    this.tarefas = ctx.tarefas;
                    this.categorias = ctx.categorias;
                    this.despesas = ctx.despesas;
                }
            }
                        
        }

        public JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }

        #endregion
    }
}
