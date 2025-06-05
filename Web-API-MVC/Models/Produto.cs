using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API_MVC.Models
{
    [Table("Produto")]
    public class Produto
    {   
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("IdCategoria")]
        [Display(Name = "IdCategoria")]
        public int IdCategoria { get; set; }

        [ForeignKey(nameof(IdCategoria))]
        public virtual Categoria? Categoria { get; set; }
    }
}
