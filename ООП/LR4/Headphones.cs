using System;
namespace oop_3
{
    class Headphones : ProductEnt
    {
        private string headphonesColor;
        private string headphonesType;

        public Headphones(int cost = 0, string color = "Unknow",
            string type = "Unknow")
        {
            productName = "Наушники";
            productCost = cost;
            headphonesColor = color;
            headphonesType = type;
        }

        public override string GetItem()
        {
            return $"ID: {productId}\nНаименование: {productName}\n" +
                $"Цвет: {headphonesColor}\nТип: {headphonesType}\n" +
                $"Стоимость: {productCost}\n";
        }

        public override void AddItem()
        {
            basket.Add(new Headphones(productCost, headphonesColor, headphonesType));
        }
    }
}
