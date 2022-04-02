namespace LR5;

public interface IBulglar : ITrader
{
    void Recive(Entity trader, Item item); //=> trader.Remove(item);
}