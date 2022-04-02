namespace LR5;

public class Doctor : Entity, IDoctor
{
    public void Heal(Entity entity, IAid item)
    {
        entity.AddHealth(Convert.ToInt32(item.GetEffect()));
    }

    public Doctor(int entityHealthAmount = 1, int entityCarryWeight = 1, int entityWallet = 0) 
        : base(entityWallet: entityWallet, entityCarryWeight: entityCarryWeight, entityHealthAmount: entityHealthAmount )
    {
        
    }
}