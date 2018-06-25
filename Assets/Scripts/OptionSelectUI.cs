using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ObjectOption
{
    RAG = 0,
    LAMP = 1,
    TRASH = 2,
    TV = 3,
    TELE = 4,
    FAN = 5
}

public class OptionSelectUI : MonoBehaviour {
    public int index;
    public ObjectOption option;
    public bool isSet = false;
    //[HideInInspector] 
    public Image objectImage;
    // Use this for initialization


    Dictionary<ObjectOption, Sprite> objectSpriteDict  {
        get {
            return ASGlobal.Instance.objectSpriteDict ;    
        }
    }

    void Start()
    {
        //objectImage =  GetComponent<Image>();
    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public void Select()
    {
        ObjectSelecter.Instance.Open(UpdateImage);
    }

    void UpdateImage(int i)
    {
        isSet = true;
        ObjectOption c = (ObjectOption)i;
        Sprite sprite;
        objectSpriteDict.TryGetValue(c, out sprite);
        objectImage.sprite = sprite;
        objectImage.color = Color.white;
    }

}
