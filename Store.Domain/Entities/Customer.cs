using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string nome, string email, Guid id): base(id)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}