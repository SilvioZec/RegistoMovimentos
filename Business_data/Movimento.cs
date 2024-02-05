using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Business_data
{
    internal class Movimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public char? Marcador { get; set; }
        public string? Descricao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } //propriedade de navegacao para cliente
        public int Tipo_movimentoId { get; set; }
        public Tipo_movimento Tipo_movimento { get; set; } //propriedade de navegacao para tipo

    }
}
