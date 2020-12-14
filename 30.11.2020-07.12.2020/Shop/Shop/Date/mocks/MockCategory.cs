﻿using Shop.Date.Intefaces;
using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згарания"}
                };
            }
        }
    }
}
