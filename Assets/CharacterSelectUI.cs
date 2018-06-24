using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectUI : MonoBehaviour {


    public Image charImage;

    public Sprite father; 
    public Sprite mother ; 
    public Sprite brother  ; 
    public Sprite sister  ; 
    public Sprite grandma  ;



    /*
     * FATHER = 0,
    MOTHER = 1,
    BROTHER = 2,
    SISTER = 3,
    GRANDMA = 4
    */

    // Use this for initialization

    Dictionary<Character, Sprite> charSpriteDict;
    ConversationBubData conversationBubData;  
	void Start () {
        charSpriteDict = new Dictionary<Character, Sprite>(){
            {Character.MOTHER  , mother},
            {Character.FATHER  , father},
            {Character.BROTHER  , brother},
            {Character.SISTER  , sister},
            {Character.GRANDMA  , grandma},
        };

        conversationBubData = GetComponent<ConversationBubUI>().conversationBub; 
	}

	// Update is called once per frame
	void Update () {
		
	}
    public void Select() {
        CharacterSelecter.Instance.Open(UpdateImage);
    }

    void UpdateImage (Character c){
        Sprite sprite; 
        charSpriteDict.TryGetValue(c , out  sprite);
        charImage.sprite = sprite;
        conversationBubData.character = c;
    }

    void HandleAction(Character c)
    {
    }

}
