using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Insira um {0.ToLower()}.")]
        [StringLength(8, ErrorMessage = "{0} inválido. Corrija e tente novamente.", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Insira um {0.ToLower()}.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Insira uma {0.ToLower()}.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Insira um {0.ToLower()}.")]
        public string Bairro { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Insira um {0.ToLower()}.")]
        public string Logradouro { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "Insira um {0.ToLower()}.")]
        public string Numero { get; set; }

        [StringLength(200, ErrorMessage = "O {0.ToLower()} precisa ter entre {2} e {1} caracteres.", MinimumLength = 8)]
        public string Complemento { get; set; }

        [HiddenInput]
        public Guid IdDonoEndereco { get; set; }
    }
}
