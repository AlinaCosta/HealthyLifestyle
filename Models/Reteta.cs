using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyLifeStyle.Models
{
    public class Reteta
    {
        public int RetetaId { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public string UnitMas { get; set; }
        public int Cantitate { get; set; }
        public string Instructiuni { get; set; }
        public Dish Dish { get; set; }
        public string TimpPrep { get; set; }
        public int NrServiri { get; set; }

    }
}
