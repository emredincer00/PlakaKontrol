using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Vehicle: BaseEntity
    {
        public string LicensePlate { get; set; }

        public string Information { get; set; }


        public override string ToString()
        {
            
            return $"{LicensePlate} = {Information}\n";
        }

        //Relational Properties

    }
}
