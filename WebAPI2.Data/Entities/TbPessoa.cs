using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI2.Data.Entities
{
    public partial class TbPessoa
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public int? Idade { get; set; }
        public string Foto { get; set; }
        public string Cep { get; set; }
    }
}
