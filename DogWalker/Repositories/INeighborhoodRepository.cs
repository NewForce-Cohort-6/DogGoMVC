using DogWalker.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace DogWalker.Repositories
{
    public interface INeighborhoodRepository
    {
        List<Neighborhood> GetAllNeighborhoods();
        Neighborhood GetNeighborhoodById(int id);
        void AddNeighborhood(Neighborhood neighborhood);
        void UpdateNeighborhood(Neighborhood neighborhood);
        void DeleteNeighborhood(int id);
    }
}
