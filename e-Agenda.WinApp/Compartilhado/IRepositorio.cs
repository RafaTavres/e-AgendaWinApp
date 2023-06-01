﻿using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public interface IRepositorio<TEntidade>
    {
        void Inserir(TEntidade novaEntidade);
        void Atualizar(int id, TEntidade entidade);
        void Deletar(int id);
        List<TEntidade> RetornarTodos();
        TEntidade Busca(int id);

    }

}
