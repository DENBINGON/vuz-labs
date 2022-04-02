namespace LR6;

/*Разработать класс «Силовая установка звездолёта»,
 содержащий поля «Тип» (химическая, плазменная, фотонная и т.п.), «Тяга (кг)».
 
Перегрузить:
- Операторы сравнения (по величине тяги);
- Оператор «+» (при сложении двух силовых установок возвращается третья,
где величина тяги равняется сумме тяг слагаемых силовых установок,
а тип равняется «Гибридная», если слагаемые силовые установки различаются по типу,
либо равен типу слагаемых силовых установок, если их типы равны между собой).*/

public class StarshipPropulsionSystem
{
    private string systemType;
    private int systemThrust;

    public static StarshipPropulsionSystem operator +(StarshipPropulsionSystem item_1, StarshipPropulsionSystem item_2)
    {
        return new StarshipPropulsionSystem(
            item_1.systemType == item_2.systemType ? item_1.systemType : "Гибридная",
            item_1.systemThrust + item_2.systemThrust
        );
    }

    public static bool operator <(StarshipPropulsionSystem item_1, StarshipPropulsionSystem item_2)
    {
        return item_1.systemThrust < item_2.systemThrust;
    }

    public static bool operator >(StarshipPropulsionSystem item_1, StarshipPropulsionSystem item_2)
    {
        return item_1.systemThrust > item_2.systemThrust;
    }

    public static bool operator <=(StarshipPropulsionSystem item_1, StarshipPropulsionSystem item_2)
    {
        return item_1.systemThrust <= item_2.systemThrust;
    }

    public static bool operator >=(StarshipPropulsionSystem item_1, StarshipPropulsionSystem item_2)
    {
        return item_1.systemThrust >= item_2.systemThrust;
    }

    public StarshipPropulsionSystem(string systemType, int systemThrust)
    {
        this.systemThrust = systemThrust;
        this.systemType = systemType;
    }
}