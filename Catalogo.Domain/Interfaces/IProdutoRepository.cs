﻿using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task<Produto> GetByIdAsync(int? id);
        Task<Produto> CreateAsync(Produto product);
        Task<Produto> UpdateAsync(Produto product);
        Task<Produto> RemoveAsync(Produto product);
    }
}
