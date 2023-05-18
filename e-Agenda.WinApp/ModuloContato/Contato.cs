using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string nome;
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
            this.empresa = empresa;
        }

        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Contato contato= (Contato)entidadeAtualizada;
             nome = contato.nome;
             telefone = contato.telefone;
             email = contato.email;
             cargo = contato.cargo;
             empresa = contato.empresa;          
        }

        public override string ToString()
        {
            return $"Id: {id}| Nome {nome} | Empresa: {empresa} | Telefone {telefone} | E-mail {email} | Cargo {cargo}";
        }
    }
}
