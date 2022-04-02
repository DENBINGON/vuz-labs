namespace LR5;

public class Player : Entity, IFighter
{

    public void Attack(Entity entity, IWeapon weapon)
    {
        entity.GetDamage(weapon.GetDamage());
    }
    
    public Player(int entityHealthAmount = 1, int entityCarryWeight = 1, int entityWallet = 0) 
        : base(entityWallet: entityWallet, entityCarryWeight: entityCarryWeight, entityHealthAmount: entityHealthAmount )
    {
        
    } 
}