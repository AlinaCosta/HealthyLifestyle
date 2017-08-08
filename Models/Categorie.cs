using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyLifeStyle.Models
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Nume { get; set; }
        public List<Dish> Dish { get; set; }

    }
}
