// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace SoniaStore.ViewModels;

// public class ProdutoUpSertVM
// {
//     [Key]
//     public int Id { get; set; }

//     [Display(Name = "Categoria")]
//     [Required(ErrorMessage = "Por favor, informe a Categoria")]
//     public int CategoriaId { get; set; }

//     [Required(ErrorMessage = "Por favor, informe o Nome")]
//     [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
//     public string Nome { get; set; }

//     [Display(Name = "Descrição", Prompt = "Descrição")]
//     [StringLength(1000, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
//     public string Descricao { get; set; }

//     [Display(Name = "Estoque")]
//     [Required(ErrorMessage = "Por favor, informe a quantidade em estoque")]
//     [Range(0, int.MaxValue)]
//     public int QtdeEstoque { get; set; }

//     [Display(Name = "Valor de Custo")]
//     [Range(0, double.MaxValue)]
//     [Required(ErrorMessage = "Por favor, informe o valor de custo")]
//     [Column(TypeName = "decimal(10,2)")]
//     public decimal ValorCusto { get; set; }

//     [Display(Name = "Valor de Venda")]
//     [Range(0, double.MaxValue)]
//     [Required(ErrorMessage = "Por favor, informe o valor de venda")]
//     [Column(TypeName = "decimal(10,2)")]
//     public decimal ValorVenda { get; set; }

//     public bool Destaque { get; set; } = false;

//     public List<FotoVM> Fotos { get; set; }
// }

// public class FotoVM
// {
//     public IFormFile Arquivo { get; set; }
//     public string Descricao { get; set; }
// }