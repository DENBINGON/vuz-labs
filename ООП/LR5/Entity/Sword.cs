namespace LR5;

public class Sword : Item, IWeapon
{
    private int swordDamage;
    
    public string GetDamage() => swordDamage.ToString();

    public Sword(int swordDamage, int itemWeight, int itemCost)
    :base(itemCost: itemCost, itemWeight: itemWeight, itemName: "Меч")
    {
        this.swordDamage = swordDamage;
    }
}