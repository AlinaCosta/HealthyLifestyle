using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyLifeStyle.Models
{
    public class InfoNutritionale
    {
        public int InfoNutritionaleId { get; set; }
        public int Cantitate { get; set; }
        public string UnitMas { get; set; }
        public string Nume { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }

    }
}
