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
    public class Compromisso : EntidadeBase
    {
        public string assunto;
        public string local;
        public DateTime data;
        public DateTime horaDeInicio;
        public DateTime horaDoTermino;
        public Contato contatorelacionado;
        public bool ehRemoto;

        public Compromisso(string assunto, string local, DateTime data, DateTime horaDeInicio, DateTime horaDoTermino, bool ehRemoto,Contato contato)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaDeInicio = horaDeInicio;
            this.horaDoTermino = horaDoTermino;
            this.ehRemoto = ehRemoto;
            this.contatorelacionado = contato;
        }

        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Compromisso compromisso = (Compromisso)entidadeAtualizada;
            assunto = compromisso.assunto;
            local = compromisso.local;
            data = compromisso.data;
            horaDeInicio = compromisso.horaDeInicio;
            horaDoTermino = compromisso.horaDoTermino;
            contatorelacionado = compromisso.contatorelacionado;
            ehRemoto = compromisso.ehRemoto;
            contatorelacionado = compromisso.contatorelacionado;
            
        }



       public override string ToString()
        {
            return $"Id: {id} " +
                $"| Telefone do Contato: {contatorelacionado.telefone} " +
                $"| Nome do Contato: {contatorelacionado.nome}" +
                $"| Assunto {assunto} " +
                $"| Local: {local} " +
                $"| É Remoto?: {ehRemoto} " +
                $"| Data: {data.ToString("dd/MMM/yyyy")} " +
                $"| Hora De Inicio: {horaDeInicio.ToString("dd/MMM/yyyy")} " +                                
                $"| Hora De Término: {horaDoTermino.ToString("dd/MMM/yyyy")} ";
        }
    
    }
}
