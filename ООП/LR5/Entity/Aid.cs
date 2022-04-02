namespace LR5;

public class Aid : Item, IAid
{
    private int healRate;
    public string GetEffect() => healRate.ToString();

    public Aid(int healRate, int itemWeight, int itemCost)
        : base(itemCost: itemCost, itemWeight: itemWeight, itemName:"Аптечка")
    {
        this.healRate = healRate;
    }
}