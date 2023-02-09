using System.Collections;
using System.Collections.Generic;

public struct Card {
    public enum Suit{
        none,
        spades,
        hearts,
        diamonds,
        clubs
    };

    public enum Value{
        joker=0,
        ace=1,
        two=2,
        three=3,
        four=4,
        five=5,
        six=6,
        seven=7,
        eight=8,
        nine=9,
        ten=10,
        jack=11,
        queen=12,
        king=13
    };

    public Suit suit;
    public Value value;

    public Card(Suit _suit, Value _value){
        suit = _suit;
        value = _value;
    }

    public override string ToString(){
        return suit == 0 ? "joker" : string.Format("{0} of {1}", value.ToString(), suit.ToString());
    }
};
