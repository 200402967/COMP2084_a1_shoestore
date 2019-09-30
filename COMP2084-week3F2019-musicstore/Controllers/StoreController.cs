using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using COMP2084_week3F2019_musicstore.Models;

namespace COMP2084_week3F2019_musicstore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse(String genre)
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        
        public IActionResult Albums()
        {
            var albums = new List<Album>();

            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Name = "Album" + i.ToString() });
            }

            return View(albums);
        }


    }
}