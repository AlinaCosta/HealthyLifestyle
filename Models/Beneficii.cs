using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyLifeStyle.Models
{
    public class Beneficii
    {
        public int BeneficiiId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }

    }
}
