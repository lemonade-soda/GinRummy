namespace GinRummyLogic;

public class Card
{
    public Rank cardRank;
    public Suit cardSuit;

    public Card(Rank rank, Suit suit)
    {
        cardRank = rank;
        cardSuit = suit;
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