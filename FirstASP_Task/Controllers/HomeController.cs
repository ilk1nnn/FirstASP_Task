using FirstASP_Task.Entities;
using FirstASP_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace FirstASP_Task.Controllers
{
    public class HomeController : Controller
    {

        List<Drink> drinks = new List<Drink>
        {
                new Drink
                {
                    DrinkId= 1,
                    DrinkName = "Water"
                },
                new Drink
                {
                    DrinkId= 2,
                    DrinkName = "Juice"
                },
                new Drink
                {
                    DrinkId= 3,
                    DrinkName = "Beer"
                },
                new Drink
                {
                    DrinkId= 4,
                    DrinkName = "Vodka"
                }
        };


        List<HotMeal> hotMeals = new List<HotMeal>
        {
                new HotMeal
                {
                    HotMealId= 1,
                    HotMealName = "Soup"
                },
                new HotMeal
                {
                    HotMealId= 2,
                    HotMealName = "Sweet & Sour Pork"
                },
                new HotMeal
                {
                    HotMealId= 3,
                    HotMealName = "Green Beans"
                },
                new HotMeal
                {
                    HotMealId= 4,
                    HotMealName = "SoupCarrot Cake"
                }
        };


        List<FastFood> fastFoods = new List<FastFood>
        {
            new FastFood
            {
                FastFoodId= 1,
                FastFoodName = "Burger"
            },
            new FastFood
            {
                FastFoodId= 2,
                FastFoodName = "French Fries"
            },
            new FastFood
            {
                FastFoodId= 3,
                FastFoodName = "Doner"
            },
            new FastFood
            {
                FastFoodId= 4,
                FastFoodName = "Shaurma"
            }
        };



        public IActionResult Index()
        {
            dynamic mymodel = new AllElementsViewModel();
            mymodel.Drinks = GetDrinks();
            mymodel.HotMeals = GetHotMeals();
            mymodel.FastFoods = GetFastFoods();
            return View(mymodel);
        }



        public IActionResult HotMeals(int id = -1)
        {
            if (id == -1)
            {
                return View(GetHotMeals());
            }
            else
            {
                List<HotMeal> list = new List<HotMeal>();
                var data = GetHotMeals().FirstOrDefault(d => d.HotMealId == id);
                list.Add(data);
                return View(list);
            }
        }


        public List<HotMeal> GetHotMeals()
        {
            return hotMeals;
        }


        //public ViewResult Drink(int id = -1)
        //{
        //    if (id == -1)
        //    {
        //        return View(GetDrinks());
        //    }
        //    else
        //    {
        //        var data = GetDrinks().FirstOrDefault(d => d.DrinkId == id);
        //        return View(data);
        //    }
        //}

        //public ViewResult HotMeal(int id = -1)
        //{
        //    if (id == -1)
        //    {
        //        return View(GetHotMeals());
        //    }
        //    else
        //    {
        //        var data = GetHotMeals().FirstOrDefault(d => d.HotMealId == id);
        //        return View(data);
        //    }
        //}


        //public ViewResult FastFood(int id = -1)
        //{
        //    if (id == -1)
        //    {
        //        return View(GetFastFoods());
        //    }
        //    else
        //    {
        //        var data = GetFastFoods().FirstOrDefault(d => d.FastFoodId == id);
        //        return View(data);
        //    }
        //}

        public IActionResult Drinks(int id = -1)
        {
            if(id == -1)
            {
                return View(GetDrinks());
            }
            else
            {
                List<Drink> list = new List<Drink>();
                var data = GetDrinks().FirstOrDefault(d => d.DrinkId == id);
                list.Add(data);
                return View(list);
            }
        }

        public List<Drink> GetDrinks()
        {
            return drinks;
        }


        public IActionResult FastFoods(int id = -1)
        {
            if (id == -1)
            {
                return View(GetFastFoods());
            }
            else
            {
                List<FastFood> list = new List<FastFood>();
                var data = GetFastFoods().FirstOrDefault(d => d.FastFoodId == id);
                list.Add(data);
                return View(list);
            }
        }

        public List<FastFood> GetFastFoods()
        {
            return fastFoods;
        }




    }
}