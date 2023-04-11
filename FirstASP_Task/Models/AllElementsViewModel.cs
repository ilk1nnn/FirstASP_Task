using FirstASP_Task.Entities;

namespace FirstASP_Task.Models
{
    public class AllElementsViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public IEnumerable<HotMeal> HotMeals { get; set; }
        public IEnumerable<FastFood> FastFoods { get; set; }

    }
}
