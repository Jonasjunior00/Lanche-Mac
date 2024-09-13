using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        
        [Required(ErrorMessage = "O nome do lanche deve ser informado!")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80,MinimumLength =10, ErrorMessage = "O {0} deve ser no minimo {1} e no máximo {2}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ser no minimo {1} e no máximo {2}")]
        public string DescriptionShort { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada!")]
        [Display(Name = "Descrição detalhada do lanche")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ser no minimo {1} e no máximo {2}")]
        public string DescriptionDetail { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = " O {0} deve ter no máximo {1} caracteres")]
        public string ImageURL { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = " O {0} deve ter no máximo {1} caracteres")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name= "Preferido?")]
        public bool IsLanchePreferred { get; set; }

        [Display(Name = "Estoque")]
        public bool InStock { get; set; }

        //prop de navegação entre cat e lanche
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
