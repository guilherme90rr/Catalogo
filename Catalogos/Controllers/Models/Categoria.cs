using System.Diagnostics;

namespace Catalogos.Controllers.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string? Nome { get; set; }

        public string? ImagemUrl { get; set; }
    }
}
