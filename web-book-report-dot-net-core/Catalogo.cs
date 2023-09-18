using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_book_report_dot_net_core
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Investidor Inteligente", 30.20m));
            livros.Add(new Livro("002", "Pai Rico, Pai Pobre", 35.50m));
            livros.Add(new Livro("003", "Hábitos Atômicos", 45.50m));
            return livros;
        }
    }
}
