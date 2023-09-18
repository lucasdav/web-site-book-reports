using System.Collections.Generic;

namespace web_book_report_dot_net_core
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}