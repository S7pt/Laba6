using System.Collections.Generic;
using Laba4Task2.model;

namespace Laba4Task2.manager
{
    public interface IAutoOwner
    { 
        public List<AutoOwner> FindByColourAndAutoBrand(string colour, string brand, List<AutoOwner> ownerList);
    }
}