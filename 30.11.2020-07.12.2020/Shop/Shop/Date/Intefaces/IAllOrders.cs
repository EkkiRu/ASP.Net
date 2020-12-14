using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Intefaces
{
    public interface IAllOrders
    {
        void creatOrder(Order order);
    }
}
