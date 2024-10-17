using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities
{
    public sealed class Produto : Entity
    {
        public Produto(string nome, string descricao, decimal preco, string imagemUrl,
            int estoque, DateTime dataCad)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            ImagemUrl = imagemUrl;
            Estoque = estoque;
            DataCadastro = dataCad;
        }

        public Produto()
        {
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public string ImagemUrl { get; private set; }
        public int Estoque { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
