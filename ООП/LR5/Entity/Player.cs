using System.Security.Cryptography;

namespace LR5;

public class Player : Entity, IFighter
{
    public int Class { get; }
    public string playerName { get; }
    
    public void Attack(Entity entity, IWeapon weapon)
    {
        entity.GetDamage(Convert.ToInt32(weapon.GetDamage()));
    }
    
    public Player(int Class, string Name, int entityHealthAmount = 1, int entityCarryWeight = 1, int entityWallet = 0) 
        : base(entityWallet: entityWallet, entityCarryWeight: entityCarryWeight, entityHealthAmount: entityHealthAmount )
    {
        this.Class = Class;
        this.playerName = Name;
    } 
}