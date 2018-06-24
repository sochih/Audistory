using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelecter : MonoBehaviour {

    // Use this for initialization

    public static CharacterSelecter Instance;
    public CanvasGroup canvasGroup; 
	private void Awake()
	{
        Instance = this;
        canvasGroup = GetComponent<CanvasGroup>();
        Hide();
	}

    public Action<Character> callBackFunc; 
    public void Open (  Action<Character> action){
        this.callBackFunc = action;
        Show();
    }

    public void Select (int i) {
        var c = (Character)i;
        Hide();
        if (callBackFunc != null){
            callBackFunc(c);
        }
    }


	public void Hide (){
        canvasGroup.alpha =  0;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false; 
    }
    void Show (){
        canvasGroup.alpha =  1;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true; 
    }
}
