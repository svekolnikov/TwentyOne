using TwentyOne.Domain.Enums;
using TwentyOne.Domain.ValueObjects;

namespace TwentyOne.Persistence;

public class Data
{
    public HashSet<Card> Cards { get; private set; } = new ();

    public void Init()
    {
        for (int i = 0; i < 4; i++) // 4 suits
        {
            for (int j = 0; j <= CardValues.Data.Length; j++)
            {
                Cards.Add(new Card((Suits)i, CardValues.Data[j]));
            }
        }
    }
}