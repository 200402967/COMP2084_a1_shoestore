using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using COMP2084_a1_shoestore.Models;

namespace COMP2084_a1_shoestore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse(String footwear)
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }


        public IActionResult shoeTypes()
        {
            var ShoeType = new List<ShoeType>();

            for (int i = 0; i < 10; i++)
            {
                ShoeType.Add(new ShoeType { Name = "ShoeType" + i.ToString() });
            }

            return View(ShoeType);
        }


    }
}