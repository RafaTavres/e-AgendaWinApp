namespace e_Agenda.Dominio.ModuloContato
{
    [Serializable]
    public class Contato : EntidadeBase<Contato>
    {
        public string nome { get; set; }
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato()
        {
            
        }
        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
            this.empresa = empresa;
        }

        public override void Atualizar(Contato contato)
        {
             nome = contato.nome;
             telefone = contato.telefone;
             email = contato.email;
             cargo = contato.cargo;
             empresa = contato.empresa;          
        }

        public override string ToString()
        {
            return $"Id: {id}" +
                $" | Nome {nome} " +
                $" | Empresa: {empresa} " +
                $" | Telefone {telefone} " +
                $" | E-mail {email} " +
                $" | Cargo {cargo}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Contato contato &&
                   id == contato.id &&
                   nome == contato.nome &&
                   telefone == contato.telefone &&
                   email == contato.email &&
                   cargo == contato.cargo &&
                   empresa == contato.empresa;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatório");

            if (!email.Contains('@'))
                erros.Add("O campo 'email' é deve possuir um @");

            if (string.IsNullOrEmpty(email))
                erros.Add("O campo 'email' é obrigatório");

            return erros.ToArray();
        }
    }
}
