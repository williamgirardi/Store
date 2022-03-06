using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class State : EntityBase
    {
        public string Name { get; set; }
        public string Uf { get; set; }

        //Relationship
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
    }
}
