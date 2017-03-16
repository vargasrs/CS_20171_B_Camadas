using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    // aqui so vou ter classe mapeando tabelas de banco
    public class Cliente
    {
      public int ClienteID { get; set; }
      public string Nome { get; set; }
      public string Cpf { get; set; }
    }
}
