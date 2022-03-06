using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class PersonBase : EntityBase
    {
        public string Name { get; set; }
        //public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int HomeNumber { get; set; }
        public string District { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }        
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Observation { get; set; }

        //Relationship
        public long CityId { get; set; }
        public virtual City City { get; set; }
        public long StateId { get; set; }
        public virtual State State { get; set; }
    }
}
