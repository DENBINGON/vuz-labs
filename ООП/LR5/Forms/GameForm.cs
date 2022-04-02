namespace LR5;

public partial class GameForm : Form
{
    //поля
    private Player _player;
    private Text text;
    private string newLine = Environment.NewLine;
    private Random _random = new Random();
    private Creeper _creeper;
    private Villager _villager;
    private Doctor _doctor;
    
    //конструктор
    public GameForm(Player player)
    {
        InitializeComponent();
        _player = player;
        ResetStats();
        text = new Text(player);
        buttonReturn.Text = text.buttonReturn;
        player.Add(new Sword(40, 7, 240));
        ResetStats();
    }
    
    //обновление статистики
    private void ResetStats()
    {
        labelName.Text = _player.playerName;
        labelHealth.Text = _player.GetHealthAmount();
        labelWallet.Text = _player.GetWallet();
        labelWeight.Text = _player.GetCarryWeight();

        textBox1.Text = "";

        foreach (Item item in _player.GetInventory())
        {
            string addableItem =
                "Название: " + item.GetName() + newLine +
                "Вес: " + item.GetWeight() + newLine +
                "Цена: " + item.GetCost() + newLine;
            if (item is IWeapon)
            {
                addableItem += "Урон: " + ((IWeapon) item).GetDamage() + newLine + newLine;
                int damage = Convert.ToInt32(((IWeapon) item).GetDamage());
            }

            if (item is IAid)
                addableItem += "Лечение: " + ((IAid) item).GetEffect() + newLine + newLine;
            textBox1.Text += addableItem;
        }
    }

    //ЕДЕМ начало
    private void button1_Click(object sender, EventArgs e)
    {
        groupBoxEnemyActivity.Hide();
        buttonTravel.Hide();
        buttonReturn.Show();
        textBoxEvent.Show();
        buttonNext.Show();
        GamePlay();
    }
    
    //выбор события
    private void GamePlay()
    {
        switch (_random.Next(0, 2))
        {
            //мирный
            case 0:
            {
                switch (_random.Next(0, 2))
                {
                    //Doctor
                    case 0:
                    {
                        textBoxEvent.Text = text.peaceEvent + newLine + text.doctorEnt;
                        groupBoxDoctorActivity.Show();
                        break;
                    }
                    //Villager
                    case 1:
                    {
                        textBoxEvent.Text = text.peaceEvent + newLine + text.villagerEnt;
                        groupBoxVillagerActivities.Show();
                        break;
                    }
                }
                break;
            }
            //враждебный
            case 1:
            {
                textBoxEvent.Text = text.enemyEvent + newLine + text.creeperEnt;
                groupBoxEnemyActivity.Show();
                buttonReturn.Hide();
                buttonNext.Hide();
                _creeper = new Creeper();
                progressBar1.Show();
                progressBar1.Value = Convert.ToInt32(_creeper.GetHealthAmount());
                break;
            }
        }
    }

    //НАЗАД домой
    private void buttonReturn_Click(object sender, EventArgs e)
    {
        HideAll();
    }
    //Скрыть все
    private void HideAll()
    {
        groupBoxEnemyActivity.Hide();
        groupBoxVillagerActivities.Hide();
        groupBoxDoctorActivity.Hide();
        buttonNext.Hide();
        textBoxEvent.Hide();
        buttonReturn.Hide();
        buttonTravel.Show();
    }

    //идем дальше
    private void buttonNext_Click(object sender, EventArgs e)
    {
        groupBoxEnemyActivity.Hide();
        groupBoxVillagerActivities.Hide();
        groupBoxDoctorActivity.Hide();
        GamePlay();
    }

    
    //Ударить нпс
    private void buttonCreeperPunch_Click(object sender, EventArgs e)
    {
        foreach (object i in _player.GetInventory())
        {
            if (i is IWeapon)
            {
                _player.Attack(_creeper, (IWeapon) i);
                break;
            }
        }

        _player.GetDamage(_random.Next(0, 12));
        if (Convert.ToInt32(_player.GetHealthAmount()) <= 0)
        {
            DeathForm deathForm = new DeathForm();
            this.Hide();
            deathForm.Show();
        }

        if (Convert.ToInt32(_creeper.GetHealthAmount()) < 0)
        {
            _creeper = null;
            groupBoxEnemyActivity.Hide();
            buttonNext.Show();
            buttonReturn.Show();
            int c = _random.Next(20, 200);
            textBoxEvent.Text = "Крипер убит! Вы нашли " + c.ToString() + " монет!";
            _player.AddMoney(c);
            progressBar1.Hide();
        }
        else progressBar1.Value = Convert.ToInt32(_creeper.GetHealthAmount());

        ResetStats();
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    //Покупаем аптечки
    private void button1_Click_1(object sender, EventArgs e)
    {
        if (_player.GetAmountMoney() >= 200 && Convert.ToInt32(_player.GetCarryWeight()) > 0)
        {
            _player.RemoveMoney(200);
            _player.Add(new Aid(20, 1, 200));
            _player.RemoveWeight(1);
            ResetStats();
        }
    }

    //Используем аптечки
    private void button2_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(_player.GetHealthAmount()) < 100)
        {
            foreach (object i in _player.GetInventory())
            {
                if (i is IAid)
                {
                    _player.AddHealth(20);
                    _player.RemoveAid();
                    _player.AddWeight(1);
                    ResetStats();
                    break;
                }
            }
        }
    }
}