using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Controllers
{
    public class HomeController : Controller
    {
        private IDogRepository dogRepo;

        public HomeController(IDogRepository dogRepo)
        {
            this.dogRepo = dogRepo;
        }

        public object Index()
        {
            dogRepo.GetAll();
            return View();
        }
    }
}
