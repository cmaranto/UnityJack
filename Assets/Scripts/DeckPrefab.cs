using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPrefab : MonoBehaviour
{
    public Deck deck = new Deck();
    public CardPrefab cardPrefab;
    private int inc = 0;

    // Start is called before the first frame update
    void Start()
    {        
        deck.init();
        deck.shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Card c = new Card();
        if(deck.draw(ref c)){
            CardPrefab cp = Instantiate(cardPrefab,new Vector3(inc++,1,0),Quaternion.identity);
            cp.card = c;
        } 
    }
}
