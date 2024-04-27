using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public Client(int Id, string Name, string Address, string Phone, bool Active)
        {

            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Active = Active;

        }

        public Client() { }

    }
}
