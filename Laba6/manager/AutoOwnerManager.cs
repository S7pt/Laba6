using System.Collections.Generic;
using Laba4Task2.model;

namespace Laba4Task2.manager
{
    public class AutoOwnerManager:IAutoOwner
    {
        
        public List<AutoOwner>  FindByColourAndAutoBrand(string colour, string brand,List<AutoOwner> ownerList)
        {
            List<AutoOwner> filteredList = new List<AutoOwner>();
            foreach (AutoOwner owner in ownerList)
            {
                if (owner.getAutoColor().ToLower() == colour.ToLower() && owner.getAutoBrand().ToLower() == brand.ToLower())
                {
                    filteredList.Add(owner);
                }
            }

            return filteredList;
        }
    }
}