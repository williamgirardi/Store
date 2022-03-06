using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public Situation Situation { get; set; }
    }
}
