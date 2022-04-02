namespace LR5;

public interface ITrader
{
    void Recive(Entity trader, Item item);
    void GiveAway(Entity trader, Item item);
}