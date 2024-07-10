using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSistemaDePedidos.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public String? Nome { get; set; }
        public String? Telefone { get; set; }
        public String? CEP { get; set; } 
        public String? Estado { get; set; }
        public String? Cidade { get; set; }
        public String? Email { get; set;}
    }
}
