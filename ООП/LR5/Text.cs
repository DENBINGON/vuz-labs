namespace LR5;

public class Text
{
    private string N = Environment.NewLine;
    public string welcomeMessage { get; }
    public string buttonReturn { get; }
    public string enemyEvent = "Путешествуя Вы встретили врага!";
    public string peaceEvent = "Путешествуя Вы встретили мирного жителя!";
    public string creeperEnt = "Это крипер! Убей его или он убъет тебя!";
    public string villagerEnt = "Это торговец! Ты можешь купить у него некоторые предметы!";
    public string doctorEnt = "Это доктор! Он может вылечить тебя если у тебя есть аптечка!";

    public Text(Player player)
    {
        switch (player.Class)
        {
            case 0:
            {
                welcomeMessage =
                    "Добро пожаловать!"+N+"Ваш отец бывший правитель королевства Нарта слег с тяжелой болезнью и" +
                                 " Вам нужно возглавить государство в лице регента!";
                buttonReturn =
                    "Вернутся в Нарту!";
                break;
            }
            case 1:
            {
                welcomeMessage =
                    "Добро пожаловать!"+N+"Вы один из самых удачных полководцев, из сложившейся ситуации в королевстве Нарта - " +
                    "королевство Марден объявило войну что бы отобрать земли.";
                buttonReturn =
                    "Вернутся в Марден!";
                break;
            }
        }
    }
}
