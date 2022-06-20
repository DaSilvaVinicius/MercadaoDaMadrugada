using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o {0.ToLower()} do produto.")]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Descreva o seu produto.")]
        [StringLength(1000, ErrorMessage = "A {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; }

        public string Imagem { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Digite o {0.ToLower()} do produto.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Digite a {0.ToLower()} de produtos.")]
        public int Quantidade { get; set; }

        public bool EstoqueDisponivel { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }
     
        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "Digite o {0.ToLower()} do produto.")]
        public Guid IdFornecedor { get; set; }
    }
}
