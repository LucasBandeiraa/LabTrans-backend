using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public ICollection<Wallet> Wallets { get; set; }
    }
}
