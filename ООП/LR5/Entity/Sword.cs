namespace LR5;

public class Sword : Item, IWeapon
{
    private int swordDamage;
    
    public int GetDamage() => swordDamage;

    public Sword(int swordDamage, int itemWeight, int itemCost)
    :base(itemCost: itemCost, itemWeight: itemWeight)
    {
        this.swordDamage = swordDamage;
    }
}