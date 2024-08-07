using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreInventorySystem.AllMenu
{
    public class PatternMenu
    {
        protected Store MyStore;

        public PatternMenu(Store store)
        {
            MyStore = store;
        }

        virtual public void Run(){}
    }
}