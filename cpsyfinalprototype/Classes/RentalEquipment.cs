using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsyfinalprototype.Classes
{
    public class RentalEquipment
    {
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double DailyRentalCost { get; set; }


        public RentalEquipment(int EquipmentId) 
        {
            this.EquipmentId = EquipmentId;

        }


    }
}
