using DogWalker.Models;
using System.Collections.Generic;

namespace DogWalker.Models.ViewModels
{
    public class OwnerFormViewModel
    {
        public Owner Owner { get; set; }
        public List<Neighborhood> Neighborhoods { get; set; }
    }
}