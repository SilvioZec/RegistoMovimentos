using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Business_code
{
    internal class Saldo
    {
        public int Id { get; set; }
        public string? Nif { get; set; }
        public string Nome_Cliente { get; set; }
        public string Saldo_tipo { get; set; }
        public decimal Valor { get; set; }

    }
}
