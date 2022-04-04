namespace LR2;
class  LR2
{
    static void Main(string[] args)
    {
        Queue<int> deck = new Queue<int>(new int[] {3,4,7,6,8, 2,5, 1,9, 0});
        Queue<int> deckFirst = new Queue<int>(10);
        Queue<int> deckSecond = new Queue<int>(10);
        for (int i = 0; i < 5; i++)
        {
            deckFirst.Enqueue(deck.Dequeue());
            deckSecond.Enqueue(deck.Dequeue());
        }
        int con = 0;
        while (true)
        {
            int firstCard = deckFirst.Dequeue();
            int secondCard = deckSecond.Dequeue();
            if ((firstCard > secondCard || firstCard == 0 && secondCard == 9) && !(firstCard == 9 && secondCard == 0))
            {
                deckFirst.Enqueue(firstCard);
                deckFirst.Enqueue(secondCard);
            }
            else
            {
                deckSecond.Enqueue(secondCard);
                deckSecond.Enqueue(firstCard);
            }
            con++;
            Console.WriteLine($"Первый: {deckFirst.Count} Второй: {deckSecond.Count}");
            if (deckFirst.Count == 0 || deckSecond.Count == 0) break;
        }
        Console.WriteLine(deckFirst.Count > deckSecond.Count ? "Первый" : "Второй");
        Console.WriteLine($"За {con} ходов");
    }
}

