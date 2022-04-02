namespace LR5
{

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

        public string GetWallet() => entityWallet.ToString();
        public string GetCarryWeight() => entityCarryWeight.ToString();
        public string GetHealthAmount() => entityHealthAmount.ToString();
        public List<object> GetInventory() => entityInventory;
        public void AddMoney(int money) => entityWallet += money;
        public void RemoveMoney(int money) => entityWallet -= money;
        public int GetAmountMoney() => entityWallet;
        public void AddWeight(int i) => entityCarryWeight += i;
        public void RemoveWeight(int i) => entityCarryWeight -= i;

        public void Add(object obj)
        {
            entityInventory.Add(obj);
        }

        public void RemoveAid()
        {
            entityInventory.RemoveAt(entityInventory.Count-1);
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
}