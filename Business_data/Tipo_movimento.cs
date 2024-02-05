using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Business_data
{
    internal class Tipo_movimento
    {
        [Key]
        public int Id { get; set; } // Definindo o Id como chave primária
        public string Descricao { get; set; }

        public List<Movimento> Movimentos { get; set; } // um para muitos com movimento
    }
}
