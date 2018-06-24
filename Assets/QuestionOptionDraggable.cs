using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class QuestionOptionDraggable : MonoBehaviour {

    // Use this for initialization

    public Image img;
    public Transform draggingCon;
    Transform defaultContainer;

    public Color draggingColor = new Color(1f, 1f, 1f, .8f);
    public Color touchedColor = Color.yellow;


    public Vector3 defautPosition;
	void Start () {
        img = GetComponent<Image>();
        defautPosition = transform.position;
        defaultContainer = transform.parent;
	}

    // ref : https://blog.csdn.net/u011484013/article/details/62040808 

	// Update is called once per frame
	void Update () {
        if (isCol){
            img.color = touchedColor; 
        }else if (isDragging){
            img.color = draggingColor;
        }else {
            img.color = Color.white;
        }
	}

    public void OnStartDrag (BaseEventData baseEventData){
        isDragging = true;
    }

    public void OnDrag(BaseEventData baseEventData){
        isDragging = true;
        var eventData = (PointerEventData)baseEventData;
        transform.position = eventData.position;

    }

    public void OnEndDrag(BaseEventData baseEventData)
    {
         
        isDragging = false;


    }

    public bool isDragging = false;
    public bool isCol = false;

    void OnCollisionEnter2D(Collision2D coll)
    {
        isCol = true;
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        isCol = true;

    }

    void OnCollisionExit2D(Collision2D coll)
    {
        isCol = false;

    }

}
