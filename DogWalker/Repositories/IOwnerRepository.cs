using DogWalker.Models;
using System.Collections.Generic;

namespace DogWalker.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
    }
}
