using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace GinRummyLogic;

public class Deck
{
    private Random _random = new Random();
    public List<Card> Cards { get; } = new List<Card>();

    private readonly List<Card.Suit> _suits =
        new List<Card.Suit>() {Card.Suit.Spades, Card.Suit.Clubs, Card.Suit.Diamonds, Card.Suit.Hearts};

    private readonly List<Card.Rank> _ranks = new List<Card.Rank>()
    {
        Card.Rank.Ace, Card.Rank.Two, Card.Rank.Three, Card.Rank.Four,
        Card.Rank.Five, Card.Rank.Six, Card.Rank.Seven, Card.Rank.Eight,
        Card.Rank.Nine, Card.Rank.Ten, Card.Rank.Jack, Card.Rank.Queen,
        Card.Rank.King
    };

    public Deck()
    {
        foreach (Card.Suit suit in _suits)
        {
            foreach (Card.Rank rank in _ranks)
            {
                Cards.Add(new Card(rank,suit));
            }
        }

        Cards = Shuffle(Cards);
    }

    public List<Card> Shuffle(List<Card> cards)
    {

        for (var i = 0; i < cards.Count; i++)
        {
            var j = _random.Next(i);
            Card temp = new Card(cards[i].cardRank, cards[i].cardSuit);

            cards[i] = cards[j];
            cards[j] = temp;

        }
        return cards;
    }
}