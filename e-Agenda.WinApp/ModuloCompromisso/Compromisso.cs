using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto;
        public string local;
        public DateTime data;
        public DateTime horaDeInicio;
        public DateTime horaDoTermino;
        public Contato contatoRelacionado;
        public bool ehRemoto;

        public Compromisso()
        {
        }

        public Compromisso(string assunto, string local, DateTime data, DateTime horaDeInicio, DateTime horaDoTermino, bool ehRemoto,Contato contato)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaDeInicio = horaDeInicio;
            this.horaDoTermino = horaDoTermino;
            this.ehRemoto = ehRemoto;
            contatoRelacionado = contato;
        }

        public override void Atualizar(Compromisso compromisso)
        {
            assunto = compromisso.assunto;
            local = compromisso.local;
            data = compromisso.data;
            horaDeInicio = compromisso.horaDeInicio;
            horaDoTermino = compromisso.horaDoTermino;
            contatoRelacionado = compromisso.contatoRelacionado;
            ehRemoto = compromisso.ehRemoto;           
        }



       public override string ToString()
        {
            return 
                $"Id: {id} " +
                $" | Telefone do Contato: {contatoRelacionado.telefone} " +
                $" | Nome do Contato: {contatoRelacionado.nome}" +
                $" | Assunto {assunto} " +
                $" | Local: {local} " +
                $" | É Remoto?: {ehRemoto} " +
                $" | Data: {data.ToString("dd/MMM/yyyy")} " +
                $" | Hora De Inicio: {horaDeInicio.ToString("HH:mm")} " +                                
                $" | Hora De Término: {horaDoTermino.ToString("HH:mm")} ";
        }

        public override string[] Validar()
        {

            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
                erros.Add("O campo 'assunto' é obrigatório");

            if (string.IsNullOrEmpty(local))
                erros.Add("O campo 'local' é obrigatório");

            if (horaDeInicio > horaDoTermino)
                erros.Add("A hora de conclusão não pode ser menor que a hora de criação");

            return erros.ToArray();
        }
    }
}
