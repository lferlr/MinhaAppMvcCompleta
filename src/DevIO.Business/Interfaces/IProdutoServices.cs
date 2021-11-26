﻿using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoServices
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
