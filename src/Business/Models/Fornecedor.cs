using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Documento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
