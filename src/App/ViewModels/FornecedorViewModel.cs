using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o seu {0.ToLower()}.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o seu {0.ToLower()}.")]
        [Phone(ErrorMessage = "Número de {0.ToLower()} inválido. Corrija e tente novamente.")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Digite o seu {0.ToLower()}.")]
        [StringLength(14, ErrorMessage = "{0} inválido. Corrija e tente novamente.", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Tipo de Documento")]
        public int TipoDocumento { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
