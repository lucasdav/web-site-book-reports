using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_book_report_dot_net_core
{
    public class Livro
    {
    public Livro(string codigo, string nome, decimal preco)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
    }

    public string Codigo { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    }
}
