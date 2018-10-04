using DogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp
{
    public interface IDogRepository
    {
        List<Dog> GetAll();
    }
}
