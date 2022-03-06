using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class City : EntityBase
    {
        public string Name { get; set; }

        //RelationShipp between city and state
        public long StateId { get; set; }
        public virtual State State { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Provider> Providers { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
