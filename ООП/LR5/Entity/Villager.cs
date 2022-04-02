namespace LR5;

public class Villager : Entity, ITrader
{
    public void Recive(Entity trader, Item item)
    {
        trader.Add(item);
    }
    public void GiveAway(Entity trader, Item item)
    {
        trader.Remove(item);
    }

    public Villager(int entityHealthAmount = 1, int entityCarryWeight = 1, int entityWallet = 0) 
        : base(entityWallet: entityWallet, entityCarryWeight: entityCarryWeight, entityHealthAmount: entityHealthAmount )
    {
        
    }
}