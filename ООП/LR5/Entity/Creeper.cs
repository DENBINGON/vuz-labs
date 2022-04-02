namespace LR5;

public class Creeper : Entity
{

    public Creeper(int entityHealthAmount = 100, int entityCarryWeight = 1, int entityWallet = 0) 
        : base(entityWallet: entityWallet, entityCarryWeight: entityCarryWeight, entityHealthAmount: entityHealthAmount )
    {
        
    }
}