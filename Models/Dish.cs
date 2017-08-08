using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyLifeStyle.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Nume { get; set; }
        public string ScurtaDescriere { get; set; }
        public string LungaDescriere { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public int TipDietaId { get; set; }
        public TipDieta TipDieta { get; set; }
        public InfoNutritionale InfoNutritionale { get; set; }
        public Beneficii Beneficii { get; set; }
        public Reteta Reteta { get; set; }


    }
}
