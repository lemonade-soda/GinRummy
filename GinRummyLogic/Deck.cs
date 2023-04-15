/*using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;*/

namespace GinRummyLogic;

public class Deck
{
    private readonly Random _random = new Random();
    public List<Card> Cards { get; set; } = new List<Card>();

    private readonly List<Card.Suit> _suits =
        new List<Card.Suit>() {Card.Suit.Spades, Card.Suit.Clubs, Card.Suit.Diamonds, Card.Suit.Hearts};

    private readonly List<Card.Rank> _ranks = new List<Card.Rank>()
    {
        Card.Rank.Ace, Card.Rank.Two, Card.Rank.Three, Card.Rank.Four,
        Card.Rank.Five, Card.Rank.Six, Card.Rank.Seven, Card.Rank.Eight,
        Card.Rank.Nine, Card.Rank.Ten, Card.Rank.Jack, Card.Rank.Queen,
        Card.Rank.King
    };
    
    public static bool operator ==(Deck a, Deck b)
    {
        for (var i = 0; i < a.Cards.Count; i++)
        {
            if (a.Cards[i].CardRank != b.Cards[i].CardRank || a.Cards[i].CardSuit != b.Cards[i].CardSuit)
                return false;
        }

        return true;
    }

    public static bool operator !=(Deck a, Deck b)
    {
        return !(a == b);
    }

    public Deck()
    {
        foreach (Card.Suit suit in _suits)
        {
            foreach (Card.Rank rank in _ranks)
            {
                Cards.Add(new Card(rank,suit));
            }
        }

        Shuffle(Cards);
    }

    public void Shuffle(List<Card> cards)
    {

        for (var i = 0; i < cards.Count; i++)
        {
            var j = _random.Next(i);
            Card temp = new Card(cards[i].CardRank, cards[i].CardSuit);

            cards[i] = cards[j];
            cards[j] = temp;

        }

        Cards = cards;
    }
}