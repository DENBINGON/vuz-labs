namespace LR6;

/*Разработать приложение, реализующее логику службы доставки интернет-магазина,
в котором имеется класс «Заказ» с полями «Цена товара», «Цена доставки»,
«Название товара», «Вес товара».

Перегрузить:

- Операторы сравнения (по весу товара);

- Оператор + (при сложении двух заказов возвращается новый экземпляр класса «Заказ», 
у которого «Вес товара», «Цена товара» равен сумме соответствующих полей слагаемых товаров, 
«Название товара» является строкой, в которой перечислены через запятую названия слагаемых товаров, 
а «Цена доставки» - равна наибольшей из двух слагаемых товаров);

- Автоматическое преобразование типов (к типу double, цена товара + цена доставки).*/

public class Order
{   
    private string productTitle;
    private int productCost;
    private int productWeight;
    private int deliveryCost;

    public static bool operator <(Order item_1, Order item_2)
    {
        return item_1.productWeight < item_2.productWeight;
    }

    public static bool operator >(Order item_1, Order item_2)
    {
        return item_1.productWeight > item_2.productWeight;
    }

    public static Order operator +(Order item_1, Order item_2)
    {
        return new Order(
            $"{item_1.productTitle}, {item_2.productTitle}",
            item_1.productCost + item_2.productCost,
            item_1.productWeight + item_2.productWeight,
            item_1.deliveryCost > item_2.deliveryCost ? item_1.deliveryCost : item_2.deliveryCost
        );
    }

    public static implicit operator double(Order order)
    {
        return order.deliveryCost + order.productCost;
    }
    
    public Order(string productTitle, int productCost, int productWeight, int deliveryCost)
    {
        this.deliveryCost = deliveryCost;
        this.productCost = productCost;
        this.productTitle = productTitle;
        this.productWeight = productWeight;
    }
}