using DogWalker.Models;
using System.Collections.Generic;

namespace DogWalker.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();

        Dog GetDogById(int id);

        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}
