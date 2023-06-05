
using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.Dominio.ModuloDespesas
{
    [Serializable]
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;

        public decimal? valor;

        public DateTime data;

        public string? formaDePagamento;

        public List<Categoria> categorias;

        public Despesa()
        {
            
        }
        public Despesa(string descricao, decimal? valor, DateTime data, string? formaDePagamento, List<Categoria> categorias)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.formaDePagamento = formaDePagamento;
            this.categorias = categorias;
        }

        public override void Atualizar(Despesa despesa)
        {
            descricao = despesa.descricao;
            valor = despesa.valor;
            data = despesa.data;
            formaDePagamento = despesa.formaDePagamento;
            categorias = despesa.categorias;
        }

        public override string ToString()
        {
            return $"A Despesa {descricao}, com valor {valor} é para {data.ToString("dd/MMM/yyyy")}";
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo 'descricao' é obrigatório");

            if (string.IsNullOrEmpty(valor.ToString()))
                erros.Add("O campo 'valor' é obrigatório e deve ser um número");

            if (string.IsNullOrEmpty(formaDePagamento))
                erros.Add("O campo 'forma De Pagamento' é obrigatório");

            if (categorias.Count ==0)
                erros.Add("Deve ter no mínimo uma categoria");

            return erros.ToArray();
        }
    }
}
