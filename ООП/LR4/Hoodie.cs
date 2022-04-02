using System;
namespace oop_3
{
    class Hoodie : ProductEnt
    {
        private int hoodieSize;
        private bool hoodieCap;
        private string hoodieGender;

        public Hoodie(int cost = 0, int size = 0,
            bool cap = false, string gender = "Unknow")
        {
            productName = "Толстовка";
            productCost = cost;
            hoodieCap = cap;
            hoodieGender = gender;
            hoodieSize = size;
        }

        public override string GetItem()
        {
            return $"ID: {productId}\nНаименование: {productName}\n" +
                $"Размер: {hoodieSize}\nПол: {hoodieGender}\n" +
                $"Капюшон: {hoodieCap}\nСтоимость: {productCost}\n";
        }

        public override void AddItem()
        {
            basket.Add(new Hoodie(productCost, hoodieSize, hoodieCap, hoodieGender));
        }
    }
}