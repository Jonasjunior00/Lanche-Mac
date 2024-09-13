using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {

        [Key]
        public int CategoriaId { get; set; } //chave primaria 

        [StringLength(100,ErrorMessage = "Você excedeu o tamanho maximo.")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "Você excedeu o tamanho maximo.")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        //relacionamento 1 para N 
        public List<Lanche> Lanches { get; set; }
    }
}
