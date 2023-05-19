﻿using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }
        public abstract string ToolTipFiltrar { get; }
        public abstract string ToolTipAdicionarItens { get; }
        public abstract string ToolTipEditarItens { get; }

        public abstract bool BotaoInserirAtivado { get; }
        public abstract bool BotaoDeletarAtivado { get; }
        public abstract bool BotaoEditarAtivado { get; }
        public abstract bool BotaoFiltrarAtivado { get; }
        public abstract bool BotaoAdicionarItensAtivado { get; }
        public abstract bool BotaoEditarItensAtivado { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Filtrar();

        public abstract void Deletar();
        public abstract void AdicionarItemsNaListaDeTarefa();
        public abstract void EditarItensDaTarefa();
        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

    }
}
