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
            var shoeTypes = new List<shoeType>();

            for (int i = 0; i < 10; i++)
            {
                shoeTypes.Add(new shoeType { Name = "shoeType" + i.ToString() });
            }

            return View(shoeTypes);
        }


    }
}