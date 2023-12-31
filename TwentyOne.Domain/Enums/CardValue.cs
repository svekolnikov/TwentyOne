﻿namespace TwentyOne.Domain.Enums;

public enum CardValue
{
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 2,
    Queen = 3,
    King = 4,
    Ace = 1,
}

public static class CardValues
{
    public static readonly CardValue[] Data = new[]
    {
        CardValue.Two,
        CardValue.Three,
        CardValue.Four,
        CardValue.Five,
        CardValue.Six,
        CardValue.Seven,
        CardValue.Eight,
        CardValue.Nine,
        CardValue.Ten,
        CardValue.Jack,
        CardValue.Queen,
        CardValue.King,
        CardValue.Ace
    };
}