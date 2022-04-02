using System.Collections.Generic;
namespace oop_3
{
    abstract class ProductEnt
    {
        protected static List<ProductEnt> basket = new List<ProductEnt>();
        protected string productName = "Unknow" ;
        protected static int counter = 0;
        protected int productId;
        protected int productCost = 0;

        protected ProductEnt() { productId = counter++; }

        public abstract void AddItem();

        public abstract string GetItem();

        public virtual int GetOverCost()
        {
            int con = 0;
            foreach (ProductEnt obj in basket)
            {
                con += obj.productCost;
            }
            return con;
        }
    }
}

