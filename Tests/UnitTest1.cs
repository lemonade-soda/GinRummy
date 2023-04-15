using GinRummyLogic;

namespace Tests;

public class ShuffleTest
{
    [Fact]
    public void TestShuffle()
    {
        Deck testDeck = new Deck();
        Deck shuffledTestDeck = new Deck();
        testDeck.Shuffle(testDeck.Cards);
        
        Assert.NotEqual(testDeck.Cards,shuffledTestDeck.Cards);
    }
}