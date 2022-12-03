using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCrudMvcSql.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Produto")]
        public string Name { get; set; }
    }
}
