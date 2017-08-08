using HealthyLifeStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyLifeStyle.ViewModels
{
    public class DishesListViewModel
    {
        public IEnumerable<Dish> Dishes { get; set; }
    }
}
