﻿using TwentyOne.Domain.Enums;
using TwentyOne.Domain.ValueObjects;

namespace TwentyOne.Persistence;

public class Data
{
    public List<Card> Cards { get; } = new ();

    public void Init()
    {
        var spades = "♠️";
        var clubs = "♣️";
        var hearts = "♥️";
        var diamonds = "♦️";
        
        foreach (var value in CardValues.Data)
        {
            Cards.Add(new Card(new Suit(spades, Suits.Spades), value));
            Cards.Add(new Card(new Suit(clubs, Suits.Clubs), value));
            Cards.Add(new Card(new Suit(hearts, Suits.Hearts), value));
            Cards.Add(new Card(new Suit(diamonds, Suits.Diamonds), value));
        }
    }
}