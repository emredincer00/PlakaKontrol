using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public BaseEntity()
        {
        }
    }
}
