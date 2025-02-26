using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Entities.Abstractions
{
    public abstract class Entity
    {
        public Entity()
        {
            ID = Guid.NewGuid();            
        }
        public Guid ID { get; set; }
    }
}
