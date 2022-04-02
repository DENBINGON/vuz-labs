namespace LR5;

//Базовый класс существа
public class Entity
{
    //Количество здоровья
    protected int entityHealthAmount;
    //Переносимый вес
    protected int entityCarryWeight;
    //Кошелек
    protected int entityWallet;
    //Инвентарь
    protected List<object> entityInventory;

    public void AddHealth(int heal) => entityHealthAmount += heal;
    public void GetDamage(int dmg) => entityHealthAmount -= dmg;
    public void Add(object obj)
    {
        entityInventory.Add(obj);
    }

    public void Remove(object obj)
    {
        entityInventory.Remove(obj);
    }
    
    protected Entity(int entityHealthAmount = 1, int entityCarryWeight = 1, int entityWallet = 0)
    {
        this.entityHealthAmount = entityHealthAmount;
        this.entityWallet = entityWallet;
        this.entityCarryWeight = entityCarryWeight;
        this.entityInventory = new List<object>();
    }
}