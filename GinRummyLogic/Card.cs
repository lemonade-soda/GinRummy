namespace GinRummyLogic;

public class Card
{
    public readonly Rank CardRank;
    public readonly Suit CardSuit;

    public Card(Rank rank, Suit suit)
    {
        CardRank = rank;
        CardSuit = suit;
    }


    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }
}