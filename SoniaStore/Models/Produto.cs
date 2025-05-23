using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoniaStore.Models;

[Table("produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    public int CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição", Prompt = "Descrição")]
    [StringLength(1000, ErrorMessage = "A Descrição deve possuir no máximo 30 caracteres")]
    public string Descricao { get; set; }

    [Display(Name = "Quantidade em Estoque")]
    [Range(0, int.MaxValue)]
    [Required(ErrorMessage = "Por favor, informe a quantidade em Estoque")]
    public int QtdeEstoque { get; set; }

    [Display(Name = "Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorCusto { get; set; }

    [Display(Name = "Valor de Venda")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorVenda { get; set; }

    public bool Destaque { get; set; }

    public List<ProdutoFoto> Fotos { get; set; }

    
}
