namespace LR5;

public class Item
{
    //Вес
    protected int itemWeight;
    //Цена
    protected int itemCost;

    protected string itemName;

    public string GetName() => itemName;
    public string GetCost() => itemCost.ToString();
    public string GetWeight() => itemWeight.ToString();



    protected Item(int itemCost, int itemWeight, string itemName)
    {
        this.itemCost = itemCost;
        this.itemWeight = itemWeight;
        this.itemName = itemName;
    }
}