//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desafio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereco
    {
        public string CPF { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Pais { get; set; }
        public int EnderecoId { get; set; }
        public string Descricao { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}
