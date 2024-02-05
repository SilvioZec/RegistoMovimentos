using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Business_data
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string? Nif { get; set; }
        public string Designacao { get; set; }
        public char? Marcador { get; set; }
        public List<Movimento> Movimentos { get; set;} //relacionamento um para muitos com movimentos
    }
}
