using DogWalker.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogWalker.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
    }
}
