﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобтль компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобное авто для городской жизни",
                        img = "/img/fordfesta.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и сильный",
                        longDesc = "Удобное авто для городской жизни",
                        img = "/img/BMWM3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобное авто для городской жизни",
                        img = "/img/c-class.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобное авто для городской жизни",
                        img = "/img/leaf.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згарания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
