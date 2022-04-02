namespace LR5;

public class Item
{
    //Вес
    protected int itemWeight;
    //Цена
    protected int itemCost;

    protected Item(int itemCost, int itemWeight)
    {
        this.itemCost = itemCost;
        this.itemWeight = itemWeight;
    }
}