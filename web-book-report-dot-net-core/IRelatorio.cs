using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace web_book_report_dot_net_core
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}