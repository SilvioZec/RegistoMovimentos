using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Business_code
{
    internal class Movimento_datagrid
    {

        public int Id { get; set; }
        public string Data { get; set; }
        public decimal Valor { get; set; }
        public char? Marcador { get; set; }
        public string? Descricao { get; set; }
        public string Cliente { get; set; }
        public string TipoMovimento { get; set; }
        public decimal Saldo_parcial { get; set; }

    }
}
