using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CursoMVC.Models
{
    public class Categoria : Model
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        //public List<Produto> Produtos { get; set; }
    }
}
