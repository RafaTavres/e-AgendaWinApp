using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public Categoria(string titulo)
        {
            this.titulo = titulo;
        }

        public string titulo;

        public override void Atualizar(Categoria entidadeAtualizada)
        {
            titulo = entidadeAtualizada.titulo;
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return $"{titulo} ";
        }
    }
}
