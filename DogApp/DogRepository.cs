using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogApp.Models;

namespace DogApp
{
    public class DogRepository : IDogRepository
    {

        List<Dog> allDogs = new List<Dog>()
            {
                new Dog(){Id = 1, Name = "Neko"},
                new Dog(){Id = 2, Name = "Andrey"},
                new Dog(){Id = 3, Name = "Maggie"},
            };

        public Dog FindById(int id)
        {
            return allDogs[id - 1];
        }

        public List<Dog> GetAll()
        {
                     
            return allDogs;
        }
    }
}
