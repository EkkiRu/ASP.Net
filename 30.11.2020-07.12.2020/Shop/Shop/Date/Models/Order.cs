using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите имя")]
        public string name { get; set; }

        [Display(Name = "Введите фамилие")]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите фамилие")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Введите адрес")]
        public string adress { get; set; }

        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(12)]
        [Required(ErrorMessage = "Длина номера 11 символов")]
        public string phone { get; set; }

        [Display(Name = "Введите E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина мейл не менее 25 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        
        public List<OrderDetail> orderDetails { get; set; }
    }
}
