using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Documento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
