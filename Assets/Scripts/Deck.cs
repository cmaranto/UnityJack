using System;
using System.Collections;
using System.Collections.Generic;

public class Deck {

    private List<Card> cards = new List<Card>(52);
    private static Random rng = new Random();

    public void init(){
        cards.Clear();
        foreach(Card.Suit s in Enum.GetValues(typeof(Card.Suit))){
            if(s == Card.Suit.none)continue;
            foreach(Card.Value v in Enum.GetValues(typeof(Card.Value))){
                if(v == Card.Value.joker)continue;
                cards.Add(new Card(s,v));
            }
        }
    }

    public void shuffle(){      
        int n = cards.Count;  
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            Card card = cards[k];  
            cards[k] = cards[n];  
            cards[n] = card;  
        }  
    }

    public bool empty(){
        return cards.Count == 0;
    }

    public bool draw(ref Card c){
        if(empty())return false;
        c = cards[0];
        cards.RemoveAt(0);
        return true;
    }
};
