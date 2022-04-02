namespace LR5;

public class Aid : Item, IAid
{
    private int healRate;
    public int GetEffect() => healRate;

    public Aid(int healRate, int itemWeight, int itemCost)
        : base(itemCost: itemCost, itemWeight: itemWeight)
    {
        this.healRate = healRate;
    }
}