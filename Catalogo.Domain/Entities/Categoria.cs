using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities
{
    public sealed class Categoria : Entity
    {
        public Categoria(string nome, string imagemUrl)
        {
            Nome = nome;
            ImagemUrl = imagemUrl;
        }

        public Categoria(int id, string nome, string imagemUrl)
        {
            Id = id;
            Nome = nome;
            ImagemUrl = imagemUrl;
        }

        public string Nome { get; private set; }
        public string ImagemUrl { get; private set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
