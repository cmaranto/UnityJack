using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPrefab : MonoBehaviour
{
    public Card card;
    public SpriteRenderer face;

    public override string ToString(){
        return card.ToString();
    }

    string toFilenameString(){
        return string.Format("CardArt/{0}_{1}", card.suit.ToString(), card.value.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {        
        //load image
        var sprite = Resources.Load<Sprite>(toFilenameString());
        Debug.Log(toFilenameString());
        face.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100)){
            transform.position = hit.point;
        }    
    }
}
