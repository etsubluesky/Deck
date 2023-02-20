using Deck;
Console.WriteLine("This is the default card!");
Console.WriteLine(new Card() + "\n");

//I did not create the repeating card ask...

//This is the deck of cards. I did not create a method here.

Console.WriteLine("A deck of cards!");
Card[] deck = new Card[52];

for (int i = 0; i < deck.Length; i++)
{
    deck[i] = new Card(i);
}

foreach (var item in deck)
{
    Console.WriteLine(item);
}